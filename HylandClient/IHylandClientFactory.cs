using System.Net;

namespace HyRest;
public interface IHylandClientFactory
{
    CookieContainer? CookieContainer { get; }
    TApi CreateClient<TApi>() where TApi : IHylandRestAPI;
}