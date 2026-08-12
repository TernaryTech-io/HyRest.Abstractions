using System.Net;

namespace HyRest;

public interface IHylandApiClient
{
    HttpClient HttpClient { get; }
    CookieContainer CookieContainer { get; }
    bool IsActive { get; }
    Task RefreshSessionAsync();
    IHylandApiClient WithCookieContainer(CookieContainer cookieContainer);

}

