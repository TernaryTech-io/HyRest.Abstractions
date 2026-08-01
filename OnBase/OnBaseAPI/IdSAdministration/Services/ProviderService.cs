using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyRest.Identity.Administration;

public class ProviderService
{
    private readonly IHylandIdentityServiceAdministrationAPI _api;
    private const string DefaultVersion = "1";

    internal ProviderService(IHylandIdentityServiceAdministrationAPI api) => _api = api;

    public Task<ICollection<IdNamePair>> ListAsync(string tenantId, string version = DefaultVersion)
        => _api.ProvidersGet(tenantId, version);

    public Task<object> CreateAsync(string tenantId, object body, string version = DefaultVersion)
        => _api.ProvidersPost(tenantId, version, body);

    public Task<object> GetAsync(string tenantId, string providerId, string version = DefaultVersion)
        => _api.ProvidersGet2(tenantId, providerId, version);

    public Task<object> UpdateAsync(string tenantId, string providerId, object body, string version = DefaultVersion)
        => _api.ProvidersPut(tenantId, providerId, version, body);

    public Task DeleteAsync(string tenantId, string providerId, string version = DefaultVersion)
        => _api.ProvidersDelete(tenantId, providerId, version);
}
