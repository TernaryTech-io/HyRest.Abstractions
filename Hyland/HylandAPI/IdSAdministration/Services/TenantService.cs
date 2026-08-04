using System.Threading.Tasks;

namespace HyRest.Identity.Administration;

public class TenantService
{
    private readonly IHylandIdentityServiceAdministrationAPI _api;
    private const string DefaultVersion = "1";

    internal TenantService(IHylandIdentityServiceAdministrationAPI api) => _api = api;

    public Task ListAsync(string version = DefaultVersion)
        => _api.TenantsGet(version);

    public Task GetAsync(string tenantId, string version = DefaultVersion)
        => _api.TenantsGet2(tenantId, version);

    public Task<IOTenant> CreateAsync(CreateModifyTenant body, string version = DefaultVersion)
        => _api.TenantsPost(version, body);

    public Task<IOTenant> UpdateAsync(string tenantId, CreateModifyTenant body, string version = DefaultVersion)
        => _api.TenantsPut(tenantId, version, body);

    public Task DeleteAsync(string tenantId, string version = DefaultVersion)
        => _api.TenantsDelete(tenantId, version);
}
