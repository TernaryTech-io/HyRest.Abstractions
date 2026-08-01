
using Refit;

namespace HyRest.Identity.Administration;

public partial interface IHylandIdentityServiceAdministrationAPI : IHylandRestAPI
{
    /// <summary>Get the Identity Service configuration as a JSON</summary>
    [Get("/api/v{version}")]
    Task Api(string version);

    /// <summary>A way to test if the controller is responsive.</summary>
    [Post("/api/v{version}/isalive")]
    Task IsalivePost(string version);

    /// <summary>A way to test if the controller is responsive.</summary>
    [Put("/api/v{version}/isalive")]
    Task IsalivePut(string version);

    /// <summary>A way to test if the controller is responsive.</summary>
    [Delete("/api/v{version}/isalive")]
    Task IsaliveDelete(string version);

    /// <summary>A way to test if the controller is responsive.</summary>
    [Get("/api/v{version}/isalive")]
    Task IsaliveGet(string version);

    /// <summary>Get the list of Administrative Users assigned to the specified tenant</summary>
    [Get("/api/v{version}/tenants/{tenantId}/admins")]
    Task AdminsGet(string tenantId, string version);

    /// <summary>Add a new username to the list of Administrative Users for the tenant</summary>
    [Headers("Content-Type: application/json")]
    [Post("/api/v{version}/tenants/{tenantId}/admins")]
    Task AdminsPost(string tenantId, string version, [Body] AdministrativeUserRequest body);

    /// <summary>Delete a username from the list of Administrative Users for the tenant</summary>
    [Delete("/api/v{version}/tenants/{tenantId}/admins/{username}")]
    Task AdminsDelete(string tenantId, string username, string version);

    /// <summary>Get a list of api resources assigned to the specified tenant</summary>
    [Headers("Accept: text/plain, application/json, text/json")]
    [Get("/api/v{version}/tenants/{tenantId}/apiresources")]
    Task<ICollection<ApiResource>> ApiresourcesGet(string tenantId, string version);

    /// <summary>Create a new api resources in the configuration</summary>
    [Headers("Accept: text/plain, application/json, text/json", "Content-Type: application/json")]
    [Post("/api/v{version}/tenants/{tenantId}/apiresources")]
    Task<ApiResource> ApiresourcesPost(string tenantId, string version, [Body] CreateModifyApiResource body);

    /// <summary>Get an ApiResource from the configurations</summary>
    [Get("/api/v{version}/tenants/{tenantId}/apiresources/{apiResourceId}")]
    Task ApiresourcesGet2(string tenantId, string apiResourceId, string version);

    /// <summary>Modify an ApiResource</summary>
    [Headers("Accept: text/plain, application/json, text/json", "Content-Type: application/json")]
    [Put("/api/v{version}/tenants/{tenantId}/apiresources/{apiResourceId}")]
    Task<ApiResource> ApiresourcesPut(string tenantId, string apiResourceId, string version, [Body] CreateModifyApiResource body);

    /// <summary>Delete an ApiResource from the configuration</summary>
    [Delete("/api/v{version}/tenants/{tenantId}/apiresources/{apiResourceId}")]
    Task ApiresourcesDelete(string tenantId, string apiResourceId, string version);

    /// <summary>Get a list of Ids and Names of clients assigned to the specified tenant</summary>
    [Headers("Accept: text/plain, application/json, text/json")]
    [Get("/api/v{version}/tenants/{tenantId}/clients")]
    Task<ICollection<IdNamePair>> ClientsGet(string tenantId, string version);

    /// <summary>Create a new client in the configuration</summary>
    [Headers("Accept: text/plain, application/json, text/json", "Content-Type: application/json")]
    [Post("/api/v{version}/tenants/{tenantId}/clients")]
    Task<Client> ClientsPost(string tenantId, string version, [Body] CreateModifyClient body);

    /// <summary>Get a client from the configuration</summary>
    [Get("/api/v{version}/tenants/{tenantId}/clients/{clientId}")]
    Task ClientsGet2(string tenantId, string clientId, string version);

    /// <summary>Modify a client</summary>
    [Headers("Accept: text/plain, application/json, text/json", "Content-Type: application/json")]
    [Put("/api/v{version}/tenants/{tenantId}/clients/{clientId}")]
    Task<Client> ClientsPut(string tenantId, string clientId, string version, [Body] CreateModifyClient body);

    /// <summary>Delete a client from the configuration</summary>
    [Delete("/api/v{version}/tenants/{tenantId}/clients/{clientId}")]
    Task ClientsDelete(string tenantId, string clientId, string version);

    /// <summary>Creates a new client secret.</summary>
    [Headers("Content-Type: application/json")]
    [Post("/api/v{version}/tenants/{tenantId}/clients/secret")]
    Task Secret(string version, string tenantId, [Body] ClientSecret body);

    /// <summary>Process the usercode and authorize the device code authentication request</summary>
    [Headers("Content-Type: application/json")]
    [Post("/api/usercode")]
    Task Usercode([Body] string body);

    /// <summary>Initialize the operational database</summary>
    [Post("/Initialization/InitOpDbAsync")]
    Task InitOpDbAsync([Query, AliasAs("OperationalDbConnString")] string operationalDbConnString, [Query, AliasAs("ProviderType")] string providerType);

    /// <summary>Get a list of Ids and Names of providers assigned to the specified tenant</summary>
    [Headers("Accept: text/plain, application/json, text/json")]
    [Get("/api/v{version}/tenants/{tenantId}/providers")]
    Task<ICollection<IdNamePair>> ProvidersGet(string tenantId, string version);

    /// <summary>Add a provider to the configuration</summary>
    [Headers("Accept: text/plain, application/json, text/json", "Content-Type: application/json")]
    [Post("/api/v{version}/tenants/{tenantId}/providers")]
    Task<object> ProvidersPost(string tenantId, string version, [Body(BodySerializationMethod.Serialized)] object body);

    /// <summary>Get a provider out of the configuration if it exists</summary>
    [Headers("Accept: text/plain, application/json, text/json")]
    [Get("/api/v{version}/tenants/{tenantId}/providers/{providerId}")]
    Task<object> ProvidersGet2(string tenantId, string providerId, string version);

    /// <summary>Modify a provider in the configuration</summary>
    [Headers("Accept: text/plain, application/json, text/json", "Content-Type: application/json")]
    [Put("/api/v{version}/tenants/{tenantId}/providers/{providerId}")]
    Task<object> ProvidersPut(string tenantId, string providerId, string version, [Body(BodySerializationMethod.Serialized)] object body);

    /// <summary>Delete a provider from the configuration</summary>
    [Delete("/api/v{version}/tenants/{tenantId}/providers/{providerId}")]
    Task ProvidersDelete(string tenantId, string providerId, string version);

    /// <summary>Return a list of acceptable attribute names</summary>
    [Get("/api/v{version}/userattributetypes")]
    Task Userattributetypes(string version);

    /// <summary>Post metadata to create new</summary>
    [Multipart]
    [Post("/api/saml2/external/metadata")]
    Task Metadata(StreamPart metadataFile);

    /// <summary>Get Metadata Location</summary>
    [Get("/api/saml2/external/metadata/location/{metadataLocation}")]
    Task Location([AliasAs("metadataLocation")] string metadataLocationPath, [Query, AliasAs("metadataLocation")] string metadataLocationQuery);

    /// <summary>Get a list of names of configured tenants</summary>
    [Get("/api/v{version}/tenants")]
    Task TenantsGet(string version);

    /// <summary>Add a tenant to the configuration</summary>
    [Headers("Accept: text/plain, application/json, text/json", "Content-Type: application/json")]
    [Post("/api/v{version}/tenants")]
    Task<IOTenant> TenantsPost(string version, [Body] CreateModifyTenant body);

    /// <summary>Get a tenant with the given Id</summary>
    [Get("/api/v{version}/tenants/{tenantId}")]
    Task TenantsGet2(string tenantId, string version);

    /// <summary>Delete the tenant with the given Id from the configuration</summary>
    [Delete("/api/v{version}/tenants/{tenantId}")]
    Task TenantsDelete(string tenantId, string version);

    /// <summary>Modify the tenant object in the configuration</summary>
    [Headers("Accept: text/plain, application/json, text/json", "Content-Type: application/json")]
    [Put("/api/v{version}/tenants/{tenantId}")]
    Task<IOTenant> TenantsPut(string tenantId, string version, [Body] CreateModifyTenant body);

    /// <summary>Upload manually managed SCIM groups CSV file</summary>
    [Multipart]
    [Post("/api/v{version}/tenants/{tenantId}/mmgroups/import")]
    Task Import(string tenantId, string version, [AliasAs("ContentType")] string contentType, [AliasAs("ContentDisposition")] string contentDisposition, [AliasAs("Headers")] IDictionary<string, IEnumerable<string>> headers, [AliasAs("Length")] long? length, [AliasAs("Name")] string name, [AliasAs("FileName")] string fileName);

    /// <summary>Get all manually managed SCIM groups</summary>
    [Get("/api/v{version}/tenants/{tenantId}/mmgroups")]
    Task Mmgroups(string tenantId, string version);
}
