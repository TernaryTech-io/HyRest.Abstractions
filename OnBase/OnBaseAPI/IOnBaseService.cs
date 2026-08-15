using HyRest.Cache;
using Microsoft.Extensions.Logging;

namespace HyRest.OnBase.ApiServices;

public abstract partial class OnBaseService<TApi> : IOnBaseService
    where TApi : class, IHylandRestAPI
{
    private readonly IHylandClientFactory _hylandClientFactory;
    private readonly IOnBaseAppCache _cache;    
    public OnBaseService(IOnBaseAppCache cache, IHylandClientFactory hylandClientFactory)
    {
        _hylandClientFactory = hylandClientFactory;
        _cache = cache;
    }
    public TApi Api { get; }
    IHylandRestAPI IOnBaseService.Api => Api;
    public virtual ILogger<IOnBaseService> Logger { get; }
    public IOnBaseAppCache Cache { get; }
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