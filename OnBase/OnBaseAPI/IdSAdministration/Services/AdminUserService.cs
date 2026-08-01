using System.Threading.Tasks;

namespace HyRest.Identity.Administration;

public class AdminUserService
{
    private readonly IHylandIdentityServiceAdministrationAPI _api;
    private const string DefaultVersion = "1";

    internal AdminUserService(IHylandIdentityServiceAdministrationAPI api) => _api = api;

    public Task ListAsync(string tenantId, string version = DefaultVersion)
        => _api.AdminsGet(tenantId, version);

    public Task AddAsync(string tenantId, AdministrativeUserRequest body, string version = DefaultVersion)
        => _api.AdminsPost(tenantId, version, body);

    public Task RemoveAsync(string tenantId, string username, string version = DefaultVersion)
        => _api.AdminsDelete(tenantId, username, version);
}
