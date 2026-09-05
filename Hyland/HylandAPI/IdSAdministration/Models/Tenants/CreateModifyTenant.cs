using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class CreateModifyTenant
{
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("AdministrativeUsers")]
    public ICollection<string> AdministrativeUsers { get; set; }

    [JsonPropertyName("AdministrativeGroups")]
    public ICollection<string> AdministrativeGroups { get; set; }

    [JsonPropertyName("ManuallyManagedGroups")]
    public ICollection<string> ManuallyManagedGroups { get; set; }

    [JsonPropertyName("Connection")]
    public ConnectionSettings Connection { get; set; }

    [JsonPropertyName("Clients")]
    public ICollection<Client> Clients { get; set; }

    [JsonPropertyName("Providers")]
    public object Providers { get; set; }

    [JsonPropertyName("ApiResources")]
    public ICollection<ApiResource> ApiResources { get; set; }

    [JsonPropertyName("ScimEndpoint")]
    public string ScimEndpoint { get; set; }

    [JsonPropertyName("EnableLocalLogin")]
    public bool EnableLocalLogin { get; set; }

    public static implicit operator CreateModifyTenant(TenantModel model)
    {
        var c = new CreateModifyTenant();
        c.Name = model.Name;
        c.AdministrativeGroups = model.AdministrativeGroups;
        c.AdministrativeUsers = model.AdministrativeUsers;
        c.Clients = model.Clients;
        c.Connection = new ConnectionSettings();
        c.ApiResources = model.ApiResources;
        c.ScimEndpoint = model.ScimEndpoint;
        c.ManuallyManagedGroups = model.ManuallyManagedGroups;
        c.Providers = model.Providers;
        c.EnableLocalLogin = model.EnableLocalLogin;
        return c;

    }
}

