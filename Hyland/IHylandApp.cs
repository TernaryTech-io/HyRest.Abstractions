using Microsoft.Extensions.Logging;

namespace HyRest.Hyland;

public abstract class HylandAppBase : IHylandApp
{
    private IHylandClientOptions _options;
    private ILogger<IHylandApp> _logger;
    private IHylandClientFactory _clientFactory;
    public HylandAppBase(ILogger<IHylandApp> logger, IHylandClientFactory clientFactory)
    {
        _logger = logger;
        _clientFactory = clientFactory;
        _options = _clientFactory.ClientOptions;
    }
    public virtual IHylandClientFactory ClientFactory => _clientFactory;
    public virtual IHylandClientOptions ClientOptions => _options;
    public virtual ILogger<IHylandApp> Logger => _logger;
    ILogger IHyRestApp.Logger => _logger;
    public abstract bool IsConnected { get; }
}

public interface IHylandApp : IHyRestApp
{
    
}
