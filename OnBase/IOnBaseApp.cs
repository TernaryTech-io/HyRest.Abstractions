using Microsoft.Extensions.Logging;

namespace HyRest;


public abstract class OnBaseAppBase : IOnBaseApp
{
    private IHylandClientOptions _options;
    private ILogger<IOnBaseApp> _logger;
    private IOnBaseClientFactory _clientFactory;
    public OnBaseAppBase(ILogger<IOnBaseApp> logger, IOnBaseClientFactory clientFactory)
    {
        _logger = logger;
        _clientFactory = clientFactory;
        _options = _clientFactory.ClientOptions;

    }
    public virtual IOnBaseClientFactory ClientFactory => _clientFactory;
    public virtual IHylandClientOptions ClientOptions => _options;
    IHylandClientFactory IHyRestApp.ClientFactory => _clientFactory;
    public virtual ILogger<IOnBaseApp> Logger => _logger;
    ILogger IHyRestApp.Logger => _logger;
    public virtual IOnBaseSession Session { get; protected set; }
    public virtual IOnBaseCore Core { get; protected set; }
    public virtual IOnBaseWorkView WorkView { get; protected set; }
    public virtual IOnBaseAdministration? Administration { get; protected set; }
    public abstract bool IsConnected { get; }
}

public interface IOnBaseApp : IHyRestApp
{
    IOnBaseSession Session { get; }
    IOnBaseCore Core { get; }
    IOnBaseWorkView WorkView { get; }
    IOnBaseAdministration? Administration { get; }
}