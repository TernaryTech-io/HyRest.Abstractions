using Refit;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace HyRest.OnBase.ApiServices;

public abstract partial class OnBaseService<TApi> : IOnBaseService
    where TApi : class, IHylandRestAPI
{
    protected TimeSpan TimeOut => TimeSpan.FromSeconds(ClientFactory.ClientOptions.RequestTimeOut);
    public Task<TOut?> Run<TOut>(Task<ApiResponse<TOut>> task, CancellationToken cancellationToken = default)
        where TOut : class
        => Run<TApi, TOut>((api, ct) => task, cancellationToken);
    public Task Run(Task<IApiResponse> task, CancellationToken cancellationToken = default)
        => Run<TApi>((api, ct) => task, cancellationToken);

    protected async Task<TOut?> Run<TAPI, TOut>(Func<TAPI, CancellationToken, Task<ApiResponse<TOut>>> function, CancellationToken token = default)
        where TAPI : IHylandRestAPI
        where TOut : class
    {
        ApiResponse<TOut>? res = null;
        while (!token.IsCancellationRequested)
        {
            Logger.LogDebug("Starting API request for {TaskType}", typeof(TOut).Name);
            TAPI api;
            if (Api is TAPI a)
                api = a;
            else
                api = ClientFactory.CreateClient<TAPI>();
            res = await function(api, token);
            var exception = HandleResponse<TOut>(res, token).WaitAsync(TimeOut).Result;
            if (exception != null)
                throw exception.InnerException?.InnerException ?? exception.InnerException ?? exception;
            if (res.Headers != null && res.Content is HylandBase b)
            {
                foreach (var h in res.Headers)
                {
                    b.AdditionalProperties.Add(h.Key, h.Value);
                }
            }
            return res.Content;
        }
        return null;        
    }    
    protected async Task Run<TAPI>(Func<TAPI, CancellationToken, Task<IApiResponse>> function, CancellationToken token = default)
        where TAPI : IHylandRestAPI
    {
        var stopwatch = Stopwatch.StartNew();
        IApiResponse? res = null;
        while (!token.IsCancellationRequested)
        {
            Logger.LogDebug("Starting API request for Task");
            TAPI api;
            if (Api is TAPI a)
                api = a;
            else
                api = ClientFactory.CreateClient<TAPI>();
            res = await function(api, token);
            var exception = HandleResponse<IApiResponse>(res, token).WaitAsync(TimeOut).Result;
            if (exception != null)
                throw exception.InnerException?.InnerException ?? exception.InnerException ?? exception;
            break;
        }
    }
    private void ExtractCookie(IApiResponse response)
    {
        if (response.Headers != null && response.Headers.Any(h => h.Key == "Set-Cookie"))
        {
            var setcookies = response.Headers.Where(h => h.Key == "Set-Cookie");
            if (ClientFactory.ApiClient.CookieContainer != null)
                ClientFactory.ApiClient.CookieContainer.SetCookies(new Uri(ClientFactory.ClientOptions.ApiBaseUrl), setcookies.First().Value.First());
        }
        return;
    }
    private async Task<Exception?> HandleResponse<TOut>(IApiResponse res, CancellationToken token)
        where TOut : class
    {
        var stopwatch = Stopwatch.StartNew();
        while (!token.IsCancellationRequested)
        {
            try
            {
                stopwatch.Stop();
                // Log request details at trace level
                Logger.LogTrace(
                    "API Request completed - Method: {Method}, URL: {RequestUri}, Duration: {Duration}ms",
                    res.RequestMessage?.Method,
                    res.RequestMessage?.RequestUri,
                    stopwatch.ElapsedMilliseconds);
                if (res.IsSuccessStatusCode)
                {
                    // Log successful response at debug level
                    Logger.LogDebug(
                        "API request succeeded - Status: {StatusCode}, Type: {ResponseType}, Duration: {Duration}ms",
                        (int)res.StatusCode,
                        typeof(TOut).Name,
                        stopwatch.ElapsedMilliseconds);

                    // Log response headers at trace level
                    if (res.Headers != null)
                    {
                        Logger.LogTrace(
                            "Response headers: {Headers}",
                            string.Join(", ", res.Headers.Select(h => $"{h.Key}={string.Join(";", h.Value)}")));
                    }

                    if (res.Error != null)
                    {
                        Logger.LogWarning(
                            "API request succeeded but error present - Status: {StatusCode}, Error: {Error}, Duration: {Duration}ms",
                            (int)res.StatusCode,
                            res.Error.Message,
                            stopwatch.ElapsedMilliseconds);
                    }
                    ExtractCookie(res);
                }
                else if (res.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    // Log failed response at warning level
                    Logger.LogWarning(
                        "API request failed - Status: {StatusCode}, ReasonPhrase: {ReasonPhrase}, URL: {RequestUri}, Duration: {Duration}ms",
                        (int)res.StatusCode,
                        res.ReasonPhrase,
                        res.RequestMessage?.RequestUri,
                        stopwatch.ElapsedMilliseconds);
                    return null;
                }
                else if (res.StatusCode.HasValue && (int)res.StatusCode == 403)
                {
                    // Log failed response at warning level
                    Logger.LogWarning(
                        "API request failed - Status: {StatusCode}, ReasonPhrase: {ReasonPhrase}, URL: {RequestUri}, Duration: {Duration}ms",
                        (int)res.StatusCode,
                        res.ReasonPhrase,
                        res.RequestMessage?.RequestUri,
                        stopwatch.ElapsedMilliseconds);
                    return null;
                }
                else
                {
                    // Log failed response at warning level
                    Logger.LogWarning(
                        "API request failed - Status: {StatusCode}, ReasonPhrase: {ReasonPhrase}, URL: {RequestUri}, Duration: {Duration}ms",
                        res.StatusCode.HasValue ? (int)res.StatusCode.Value : 0,
                        res.ReasonPhrase,
                        res.RequestMessage?.RequestUri,
                        stopwatch.ElapsedMilliseconds);

                    if (res.Error != null)
                    {
                        return res.Error;
                    }
                }
            }
            catch (TaskCanceledException ex) when (token.IsCancellationRequested)
            {
                stopwatch.Stop();
                Logger.LogWarning(
                    "API request cancelled: {message} - Type: {ResponseType}, Duration: {Duration}ms",
                    ex.Message,
                    typeof(TOut).Name,
                    stopwatch.ElapsedMilliseconds);
                return ex;
            }
            catch (TimeoutException ex)
            {
                stopwatch.Stop();
                Logger.LogError(
                    ex,
                    "API request timed out - Type: {ResponseType}, Duration: {Duration}ms, Message: {Message}",
                    typeof(TOut).Name,
                    stopwatch.ElapsedMilliseconds,
                    ex.Message);
                return ex;
            }
            catch (ApiException ex)
            {
                stopwatch.Stop();
                Logger.LogError(
                    ex,
                    "API request error - Status: {StatusCode}, Type: {ResponseType}, URL: {RequestUri}, Duration: {Duration}ms, Content: {Content}",
                    (int)ex.StatusCode,
                    typeof(TOut).Name,
                    ex.RequestMessage?.RequestUri,
                    stopwatch.ElapsedMilliseconds,
                    ex.Content);
                return ex;
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Logger.LogError(
                    ex,
                    "Unexpected error during API request - Type: {ResponseType}, Duration: {Duration}ms, Message: {Message}",
                    typeof(TOut).Name,
                    stopwatch.ElapsedMilliseconds,
                    ex.Message);
                return ex;
            }
            break;
        }
        return null;
    }
}