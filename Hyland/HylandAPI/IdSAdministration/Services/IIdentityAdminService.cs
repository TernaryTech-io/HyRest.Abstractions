using HyRest.Hyland;

namespace HyRest.Hyland.IdentityAdministration;

public interface IIdentityAdminService : IHylandService
{
    Task<ICollection<string>?> ListAdminUsersAsync(string tenantId, string version);
    Task AddAdminUserAsync(string tenantId, AdministrativeUserRequestModel body, string version);
    Task RemoveAdminUserAsync(string tenantId, string username, string version);
    Task<ICollection<ApiResource>> ListApiResourcesAsync(string tenantId, string version);
    Task<ApiResource?> CreateApiResourceAsync(string tenantId, CreateModifyApiResource body, string version);
    Task GetApiResourceAsync(string tenantId, string apiResourceId, string version);
    Task<ApiResource> UpdateApiResourceAsync(string tenantId, string apiResourceId, CreateModifyApiResource body, string version);
    Task DeleteApiResourceAsync(string tenantId, string apiResourceId, string version);
    Task<ICollection<IdNamePair>?> ListClientsAsync(string tenantId, string version);
    Task<Client?> CreateClientAsync(string tenantId, CreateModifyClient body, string version);
    Task GetClientAsync(string tenantId, string clientId, string version);
    Task<Client?> UpdateClientAsync(string tenantId, string clientId, CreateModifyClient body, string version);
    Task DeleteClientAsync(string tenantId, string clientId, string version);
    Task<ClientSecret> CreateClientSecretAsync(string tenantId, ClientSecret body, string version);
    Task<ICollection<IdNamePair>?> ListProvidersAsync(string tenantId, string version);
    Task<object?> CreateProviderAsync(string tenantId, object body, string version);
    Task<object?> GetProviderAsync(string tenantId, string providerId, string version);
    Task<object?> UpdateProviderAsync(string tenantId, string providerId, object body, string version);
    Task DeleteProviderAsync(string tenantId, string providerId, string version);
    Task<ICollection<IdNamePair>> ListTenantsAsync(string version);
    Task<TenantModel?> GetTenantAsync(string tenantId, string version);
    Task<TenantModel?> CreateTenantAsync(CreateModifyTenant body, string version);
    public Task<TenantModel?> UpdateTenantAsync(string tenantId, CreateModifyTenant body, string version);
    public Task DeleteTenantAsync(string tenantId, string version);

}