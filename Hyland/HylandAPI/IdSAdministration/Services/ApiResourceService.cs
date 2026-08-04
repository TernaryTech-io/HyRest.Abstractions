using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyRest.Identity.Administration;

public class ApiResourceService
{
    private readonly IHylandIdentityServiceAdministrationAPI _api;
    private const string DefaultVersion = "1";

    internal ApiResourceService(IHylandIdentityServiceAdministrationAPI api) => _api = api;

    public Task<ICollection<ApiResource>> ListAsync(string tenantId, string version = DefaultVersion)
        => _api.ApiresourcesGet(tenantId, version);

    public Task<ApiResource> CreateAsync(string tenantId, CreateModifyApiResource body, string version = DefaultVersion)
        => _api.ApiresourcesPost(tenantId, version, body);

    public Task GetAsync(string tenantId, string apiResourceId, string version = DefaultVersion)
        => _api.ApiresourcesGet2(tenantId, apiResourceId, version);

    public Task<ApiResource> UpdateAsync(string tenantId, string apiResourceId, CreateModifyApiResource body, string version = DefaultVersion)
        => _api.ApiresourcesPut(tenantId, apiResourceId, version, body);

    public Task DeleteAsync(string tenantId, string apiResourceId, string version = DefaultVersion)
        => _api.ApiresourcesDelete(tenantId, apiResourceId, version);
}
