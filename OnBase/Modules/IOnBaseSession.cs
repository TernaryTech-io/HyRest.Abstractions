namespace HyRest.Session;
public interface IOnBaseSession : IOnBaseModule
{
    Task InitiateAsync();
    void Initiate();
    Task HeartbeatAsync();
    void Heatbeat();
    Task DisconnectAsync();
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
