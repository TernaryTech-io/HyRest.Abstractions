using Microsoft.Extensions.Logging;

namespace HyRest;

public interface IHyRestApp
{
    public TimeSpan RequestTimeOut => TimeSpan.FromSeconds(ClientOptions.RequestTimeOut);
    IHylandClientFactory ClientFactory { get; }
    IHylandClientOptions ClientOptions { get; }
    ILogger Logger { get; }
    bool IsConnected { get; }
}
