
using Refit;

namespace HyRest.API;

public interface IHylandIdentityServiceAuthenticationAPI : IHylandRestAPI
{
    [Post("/connect/token")]
    Task<ApiResponse<IAuthenticationToken>> GetAuthToken([Body] FormUrlEncodedContent formBody);

    [Post("/diagnostics")]
    Task HealthCheck();
}