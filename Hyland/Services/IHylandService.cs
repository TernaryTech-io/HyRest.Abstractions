using Microsoft.Extensions.Logging;

namespace HyRest.Hyland;

public abstract partial class HylandService<TApi> : IHylandService
    where TApi : class, IHylandRestAPI
{
    private readonly ILogger<IHylandService> _logger;
    private readonly IHylandClientFactory _hylandClientFactory;
    public HylandService(IHylandClientFactory hylandClientFactory, ILogger<IHylandService> logger)
    {
        _hylandClientFactory = hylandClientFactory;
        _logger = logger;
    }
    public TApi Api => _hylandClientFactory.CreateClient<TApi>();
    IHylandRestAPI IHylandService.Api => Api;
    public ILogger<IHylandService> Logger => _logger;
    public IHylandClientFactory ClientFactory => _hylandClientFactory;
    public IHylandClientOptions Options => _hylandClientFactory.ClientOptions;

}

public interface IHylandService
{
    IHylandRestAPI Api { get; }
    ILogger<IHylandService> Logger { get; }
    IHylandClientFactory ClientFactory { get; }
    IHylandClientOptions Options { get; }
}