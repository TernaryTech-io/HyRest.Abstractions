using System.Net;

namespace HyRest;

public interface IOnBaseApiClient : IHylandApiClient
{
    CookieContainer CookieContainer { get; }
    bool IsActive { get; }
    Task RefreshSessionAsync();
    IOnBaseApiClient WithCookieContainer(CookieContainer cookieContainer);
}

