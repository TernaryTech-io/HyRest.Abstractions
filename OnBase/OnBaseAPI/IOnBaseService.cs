using HyRest.Cache;
using Microsoft.Extensions.Logging;

namespace HyRest.OnBase.ApiServices;

public abstract partial class OnBaseService<TApi> : IOnBaseService
    where TApi : class, IHylandRestAPI
{
    private readonly ILogger<IOnBaseService> _logger;
    private readonly IHylandClientFactory _hylandClientFactory;
    private readonly IOnBaseAppCache _cache;
    protected string? CachePrefix => _hylandClientFactory?.AuthClient?.UserInfo?.ToString();
    public OnBaseService(IOnBaseAppCache cache, IHylandClientFactory hylandClientFactory, ILogger<IOnBaseService> logger)
    {
        _hylandClientFactory = hylandClientFactory;
        _cache = cache;
        _logger = logger;
    }    
    public TApi Api => _hylandClientFactory.CreateClient<TApi>();
    IHylandRestAPI IOnBaseService.Api => Api;
    public ILogger<IOnBaseService> Logger => _logger;
    public IOnBaseAppCache Cache => _cache;
    public IHylandClientFactory ClientFactory => _hylandClientFactory;
    public IHylandClientOptions Options => _hylandClientFactory.ClientOptions;

}

public interface IOnBaseService
{
    IHylandRestAPI Api { get; }
    IOnBaseAppCache Cache { get; }
    ILogger<IOnBaseService> Logger { get; }
    IHylandClientFactory ClientFactory { get; }
    IHylandClientOptions Options { get; }
}