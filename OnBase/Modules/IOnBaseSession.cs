using Microsoft.Extensions.Logging;

namespace HyRest.OnBase.Session;
public interface IOnBaseSession : IOnBaseModule
{
    Task InitiateAsync(CancellationToken token = default);
    void Initiate();
    Task HeartbeatAsync(CancellationToken token = default);
    void Heatbeat();
    Task DisconnectAsync(CancellationToken token = default);
    void Disconnect();
    ISessionCookie? Cookie { get; }
    bool IsActive { get; }
}

public interface ISessionCookie
{
    string SessionId { get; }
    DateTime Expiration { get; }
    public bool Expired { get; }
}
