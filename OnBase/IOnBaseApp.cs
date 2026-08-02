using Microsoft.Extensions.Logging;
using HyRest.CaseManagement;
using HyRest.Session;
using HyRest.Administration;

namespace HyRest;


public abstract class OnBaseAppBase : IOnBaseApp
{
    public abstract IHylandClientFactory ClientFactory { get; }
    public abstract IHylandClientOptions ClientOptions { get; }
    public abstract ILogger<IOnBaseApp> Logger { get; }
    public virtual IOnBaseSession Session { get; protected set; }
    public virtual IOnBaseCore Core { get; protected set; }
    public virtual IOnBaseWorkView WorkView { get; protected set; }
    public virtual IOnBaseAdministration Administration { get; protected set; }
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
    IOnBaseAdministration Administration { get; }
    bool IsConnected { get; }
}