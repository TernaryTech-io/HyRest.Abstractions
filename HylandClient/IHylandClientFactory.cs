namespace HyRest;

public interface IHylandClientFactory
{
    IHylandApiClient ApiClient { get; }
    IHylandAuthClient AuthClient { get; }
    IHylandClientOptions ClientOptions { get; }
    TApi CreateClient<TApi>() where TApi : IHylandRestAPI;
}
