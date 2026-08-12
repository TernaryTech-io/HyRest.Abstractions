using System.Net;

namespace HyRest;
public interface IHylandClientFactory
{
    IHylandApiClient ApiClient  { get; }
    IHylandAuthClient AuthClient { get; }
    TApi CreateClient<TApi>() where TApi : IHylandRestAPI;
}