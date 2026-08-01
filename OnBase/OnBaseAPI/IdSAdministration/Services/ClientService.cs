using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyRest.Identity.Administration;

public class ClientService
{
    private readonly IHylandIdentityServiceAdministrationAPI _api;
    private const string DefaultVersion = "1";

    internal ClientService(IHylandIdentityServiceAdministrationAPI api) => _api = api;

    public Task<ICollection<IdNamePair>> ListAsync(string tenantId, string version = DefaultVersion)
        => _api.ClientsGet(tenantId, version);

    public Task<Client> CreateAsync(string tenantId, CreateModifyClient body, string version = DefaultVersion)
        => _api.ClientsPost(tenantId, version, body);

    public Task GetAsync(string tenantId, string clientId, string version = DefaultVersion)
        => _api.ClientsGet2(tenantId, clientId, version);

    public Task<Client> UpdateAsync(string tenantId, string clientId, CreateModifyClient body, string version = DefaultVersion)
        => _api.ClientsPut(tenantId, clientId, version, body);

    public Task DeleteAsync(string tenantId, string clientId, string version = DefaultVersion)
        => _api.ClientsDelete(tenantId, clientId, version);

    public Task CreateSecretAsync(string tenantId, ClientSecret body, string version = DefaultVersion)
        => _api.Secret(version, tenantId, body);
}
