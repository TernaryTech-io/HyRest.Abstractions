using Refit;

namespace HyRest.Identity.Administration;

public class IdentityAdminClient
{
    public TenantService Tenants { get; }
    public ClientService Clients { get; }
    public ApiResourceService ApiResources { get; }
    public ProviderService Providers { get; }
    public AdminUserService Admins { get; }

    public IdentityAdminClient(IHylandIdentityServiceAdministrationAPI api)
    {
        Tenants = new TenantService(api);
        Clients = new ClientService(api);
        ApiResources = new ApiResourceService(api);
        Providers = new ProviderService(api);
        Admins = new AdminUserService(api);
    }


    //public static IdentityAdminClient Create(string adminBaseUrl, HylandAuthClient auth)
    //{
    //    var handler = new BearerTokenHandler(() => auth.AuthToken?.AccessToken);
    //    var httpClient = new HttpClient(handler) { BaseAddress = new Uri(adminBaseUrl) };
    //    var api = RestService.For<IHylandIdentityServiceAdministrationAPI>(httpClient);
    //    return new IdentityAdminClient(api);
    //}
}
