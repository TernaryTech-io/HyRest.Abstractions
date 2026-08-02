using Microsoft.Extensions.Logging;
using HyRest.CaseManagement;
using HyRest.Session;

namespace HyRest;


public abstract class OnBaseAppBase : IOnBaseApp
{
    public abstract IHylandClientFactory ClientFactory { get; }
    public abstract IHylandClientOptions ClientOptions { get; }
    public abstract ILogger<IOnBaseApp> Logger { get; }
    public virtual IOnBaseSession Session { get; }
    public virtual IOnBaseCore Core { get; }
    public virtual IOnBaseWorkView WorkView { get; }
    public abstract bool IsConnected { get; }
}

public interface IOnBaseApp
{
    IHylandClientFactory ClientFactory { get; }
    IHylandClientOptions ClientOptions { get; }
    ILogger<IOnBaseApp> Logger { get; }
    IOnBaseSession Session { get; }
    IOnBaseCore Core { get; }
    IOnBaseWorkView WorkView { get; }
    bool IsConnected { get; }
}