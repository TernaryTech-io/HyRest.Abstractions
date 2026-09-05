using System.Net;

namespace HyRest;
public interface IOnBaseClientFactory : IHylandClientFactory
{
    new IOnBaseApiClient ApiClient  { get; }
    IHylandApiClient IHylandClientFactory.ApiClient => ApiClient;
}