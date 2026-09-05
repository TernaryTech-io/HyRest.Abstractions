using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class TenantModel : IHylandItem
{
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("ScimEndpoint")]
    public string ScimEndpoint { get; set; }

    [JsonPropertyName("EnableLocalLogin")]
    public bool EnableLocalLogin { get; set; }

    [JsonPropertyName("Clients")]
    public ICollection<Client> Clients { get; set; } = [];

    [JsonPropertyName("Providers")]
    [JsonConverter(typeof(JsonProviderConverter))]
    public ICollection<IAuthProvider> Providers { get; set; }

    [JsonPropertyName("AdministrativeUsers")]
    public ICollection<string> AdministrativeUsers { get; set; }

    [JsonPropertyName("AdministrativeGroups")]
    public ICollection<string> AdministrativeGroups { get; set; }

    [JsonPropertyName("ApiResources")]
    public ICollection<ApiResource> ApiResources { get; set; }

    [JsonPropertyName("ManuallyManagedGroups")]
    public ICollection<string> ManuallyManagedGroups { get; set; }
}
