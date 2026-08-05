using System.Net;

namespace HyRest;
public interface IHylandClientFactory
{
    UserInfo? UserInfo { get; }
    CookieContainer? CookieContainer { get; }
    TApi CreateClient<TApi>() where TApi : IHylandRestAPI;
}