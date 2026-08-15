using Microsoft.Extensions.Logging;

namespace HyRest;


public abstract class OnBaseAppBase : IOnBaseApp
{
    private IHylandClientOptions _options;
    private ILogger<IOnBaseApp> _logger;
    private IHylandClientFactory _clientFactory;
    public OnBaseAppBase(ILogger<IOnBaseApp> logger, IHylandClientFactory clientFactory)
    {
        _logger = logger;
        _clientFactory = clientFactory;
        _options = _clientFactory.ClientOptions;

    }
    public virtual IHylandClientFactory ClientFactory => _clientFactory;
    public virtual IHylandClientOptions ClientOptions => _options;
    public virtual ILogger<IOnBaseApp> Logger => _logger;
    public virtual IOnBaseSession Session { get; protected set; }
    public virtual IOnBaseCore Core { get; protected set; }
    public virtual IOnBaseWorkView WorkView { get; protected set; }
    public virtual IOnBaseAdministration? Administration { get; protected set; }
    public abstract bool IsConnected { get; }
}

public interface IOnBaseApp
{
    public TimeSpan RequestTimeOut => TimeSpan.FromSeconds(ClientOptions.RequestTimeOut);
    IHylandClientFactory ClientFactory { get; }
    IHylandClientOptions ClientOptions { get; }
    ILogger<IOnBaseApp> Logger { get; }
    IOnBaseSession Session { get; }
    IOnBaseCore Core { get; }
    IOnBaseWorkView WorkView { get; }
    IOnBaseAdministration? Administration { get; }
    bool IsConnected { get; }
}