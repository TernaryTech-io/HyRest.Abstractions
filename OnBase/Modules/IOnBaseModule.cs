using Microsoft.Extensions.Logging;
using Refit;
using System.Diagnostics;

namespace HyRest;

public abstract class OnBaseModule : IOnBaseModule
{
    protected OnBaseModule(IOnBaseApp app)
    {
        _app = app;
    }
    private readonly IOnBaseApp _app;
    public IOnBaseApp App => _app;
    public async Task Run<TApi>(Func<TApi,CancellationToken,Task<IApiResponse>> function, CancellationToken token = default)
        where TApi : IHylandRestAPI
    {
        var stopwatch = Stopwatch.StartNew();
        IApiResponse? res = null;        
        #pragma warning disable CS0168 // Variable is declared but never used
        try
        {
            App.Logger.LogDebug("Starting API request for Task");
            var api = App.ClientFactory.CreateClient<TApi>();
            res = await function(api,token);
            stopwatch.Stop();

            // Log request details at trace level
            App.Logger.LogTrace(
                "API Request completed - Method: {Method}, URL: {RequestUri}, Type: Task, Duration: {Duration}ms",
                res.RequestMessage?.Method,
                res.RequestMessage?.RequestUri,
                stopwatch.ElapsedMilliseconds);
            if (res.IsSuccessStatusCode)
            {
                // Log successful response at debug level
                App.Logger.LogDebug(
                    "API request succeeded - Status: {StatusCode}, Type: Task, Duration: {Duration}ms",
                    (int)res.StatusCode,
                    stopwatch.ElapsedMilliseconds);

                // Log response headers at trace level
                if (res.Headers != null)
                {
                    App.Logger.LogTrace(
                        "Response headers: {Headers}",
                        string.Join(", ", res.Headers.Select(h => $"{h.Key}={string.Join(";", h.Value)}")));
                }

                if (res.Error != null)
                {
                    App.Logger.LogWarning(
                        "API request succeeded but error present - Status: {StatusCode}, Error: {Error}, Duration: {Duration}ms",
                        (int)res.StatusCode,
                        res.Error.Message,
                        stopwatch.ElapsedMilliseconds);
                }

                ExtractCookie(res);
                return;
            }
            else
            {
                // Log failed response at warning level
                App.Logger.LogWarning(
                    "API request failed - Status: {StatusCode}, Type: Task, ReasonPhrase: {ReasonPhrase}, URL: {RequestUri}, Duration: {Duration}ms",
                    res.StatusCode.HasValue ? (int)res.StatusCode.Value : 0,
                    res.ReasonPhrase,
                    res.RequestMessage?.RequestUri,
                    stopwatch.ElapsedMilliseconds);

                if (res.Error != null)
                {
                    throw res.Error;
                }
            }
        }
        catch (TaskCanceledException ex) when (token.IsCancellationRequested)
        {
            stopwatch.Stop();
            App.Logger.LogWarning(
                "API request cancelled - Type: Task, Duration: {Duration}ms",
                stopwatch.ElapsedMilliseconds);
            throw;
        }
        catch (TimeoutException ex)
        {
            stopwatch.Stop();
            App.Logger.LogError(
                ex,
                "API request timed out - Type: Task, Duration: {Duration}ms, Message: {Message}",
                stopwatch.ElapsedMilliseconds,
                ex.Message);
            throw;
        }
        catch (ApiException ex)
        {
            stopwatch.Stop();
            App.Logger.LogError(
                ex,
                "API request error - Status: {StatusCode}, Type: Task, URL: {RequestUri}, Duration: {Duration}ms, Content: {Content}",
                (int)ex.StatusCode,
                ex.RequestMessage?.RequestUri,
                stopwatch.ElapsedMilliseconds,
                ex.Content);
            throw;
        }
        catch (Exception ex)
        {
            stopwatch.Stop();
            App.Logger.LogError(
                ex,
                "Unexpected error during API request - Duration: {Duration}ms, Message: {Message}",
                stopwatch.ElapsedMilliseconds,
                ex.Message);
            throw;
        }
        #pragma warning restore CS0168 // Variable is declared but never used
        throw new Exception("Shouldn't make it this far");
    }
    public async Task<TOut?> Run<TApi,TOut>(Func<TApi, CancellationToken,Task<ApiResponse<TOut>>> function, CancellationToken token = default)
        where TApi : IHylandRestAPI
        where TOut : class, IHylandBase
    {
        var stopwatch = Stopwatch.StartNew();
        ApiResponse<TOut>? res = null;

        try
        {
            App.Logger.LogDebug("Starting API request for {TaskType}", typeof(TOut).Name);
            var api = App.ClientFactory.CreateClient<TApi>();
            res = await function(api, token);
            stopwatch.Stop();

            // Log request details at trace level
            App.Logger.LogTrace(
                "API Request completed - Method: {Method}, URL: {RequestUri}, Duration: {Duration}ms",
                res.RequestMessage?.Method,
                res.RequestMessage?.RequestUri,
                stopwatch.ElapsedMilliseconds);
            if (res.IsSuccessStatusCode)
            {
                // Log successful response at debug level
                App.Logger.LogDebug(
                    "API request succeeded - Status: {StatusCode}, Type: {ResponseType}, Duration: {Duration}ms",
                    (int)res.StatusCode,
                    typeof(TOut).Name,
                    stopwatch.ElapsedMilliseconds);

                // Log response headers at trace level
                if (res.Headers != null)
                {
                    App.Logger.LogTrace(
                        "Response headers: {Headers}",
                        string.Join(", ", res.Headers.Select(h => $"{h.Key}={string.Join(";", h.Value)}")));
                }

                if (res.Error != null)
                {
                    App.Logger.LogWarning(
                        "API request succeeded but error present - Status: {StatusCode}, Error: {Error}, Duration: {Duration}ms",
                        (int)res.StatusCode,
                        res.Error.Message,
                        stopwatch.ElapsedMilliseconds);
                }
                
                if(res.Headers != null)
                {
                    foreach (var h in res.Headers)
                    {
                        res.Content?.AdditionalProperties.Add(h.Key, h.Value);
                    }
                }   

                ExtractCookie(res);
                return res.Content ?? throw new Exception("The expected Content from the request was null");
            }
            else if(res.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                // Log failed response at warning level
                App.Logger.LogWarning(
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
                App.Logger.LogWarning(
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
                App.Logger.LogWarning(
                    "API request failed - Status: {StatusCode}, ReasonPhrase: {ReasonPhrase}, URL: {RequestUri}, Duration: {Duration}ms",
                    res.StatusCode.HasValue ? (int)res.StatusCode.Value : 0,
                    res.ReasonPhrase,
                    res.RequestMessage?.RequestUri,
                    stopwatch.ElapsedMilliseconds);

                if (res.Error != null)
                {
                    throw res.Error;
                }
            }
        }
        catch (TaskCanceledException ex) when (token.IsCancellationRequested)
        {
            stopwatch.Stop();
            App.Logger.LogWarning(
                "API request cancelled: {message} - Type: {ResponseType}, Duration: {Duration}ms",
                ex.Message,
                typeof(TOut).Name,
                stopwatch.ElapsedMilliseconds);
            throw;
        }
        catch (TimeoutException ex)
        {
            stopwatch.Stop();
            App.Logger.LogError(
                ex,
                "API request timed out - Type: {ResponseType}, Duration: {Duration}ms, Message: {Message}",
                typeof(TOut).Name,
                stopwatch.ElapsedMilliseconds,
                ex.Message);
            throw;
        }
        catch (ApiException ex)
        {
            stopwatch.Stop();
            App.Logger.LogError(
                ex,
                "API request error - Status: {StatusCode}, Type: {ResponseType}, URL: {RequestUri}, Duration: {Duration}ms, Content: {Content}",
                (int)ex.StatusCode,
                typeof(TOut).Name,
                ex.RequestMessage?.RequestUri,
                stopwatch.ElapsedMilliseconds,
                ex.Content);
            throw;
        }
        catch (Exception ex)
        {
            stopwatch.Stop();
            App.Logger.LogError(
                ex,
                "Unexpected error during API request - Type: {ResponseType}, Duration: {Duration}ms, Message: {Message}",
                typeof(TOut).Name,
                stopwatch.ElapsedMilliseconds,
                ex.Message);
            throw;
        }
        throw new Exception("Shouldn't make it this far");
    }
    private void ExtractCookie(IApiResponse response)
    {
        if(response.Headers != null && response.Headers.Any(h => h.Key == "Set-Cookie"))
        {
            var setcookies = response.Headers.Where(h => h.Key == "Set-Cookie");   
            if(App.ClientFactory.CookieContainer != null)
                App.ClientFactory.CookieContainer.SetCookies(new Uri(App.ClientOptions.ApiBaseUrl), setcookies.First().Value.First());
        }
        return;
    }
}

/// <summary>
/// Represents the base OnBase module, for Document Management, WorkView, etc
/// </summary>
public interface IOnBaseModule
{
    IOnBaseApp App { get; }
    Task<TOut?> Run<TApi,TOut>(Func<TApi,CancellationToken,Task<ApiResponse<TOut>>> function, CancellationToken token = default)
        where TApi : IHylandRestAPI
        where TOut : class, IHylandBase;
    Task Run<TApi>(Func<TApi, CancellationToken,Task<IApiResponse>> function, CancellationToken token = default)
        where TApi : IHylandRestAPI;
}