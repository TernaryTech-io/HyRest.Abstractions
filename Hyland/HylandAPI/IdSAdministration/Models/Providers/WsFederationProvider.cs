using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class WsFederationProtocolSettings
{
    [JsonPropertyName("Metadata")]
    public string Metadata { get; set; }

    [JsonPropertyName("Realm")]
    public string Realm { get; set; }
}

public partial class WsFederationProvider : IAuthProvider
{
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Type")]
    public AuthProviderType Type { get; set; } = AuthProviderType.WsFederation;

    [JsonPropertyName("ProtocolSettings")]
    public WsFederationProtocolSettings ProtocolSettings { get; set; }

    [JsonPropertyName("UserAttributeMappingSettings")]
    public UserAttributeMappingSettings UserAttributeMappingSettings { get; set; }

    [JsonPropertyName("UserProvisioningSettings")]
    public UserProvisioningSettings UserProvisioningSettings { get; set; }

    [JsonPropertyName("ClaimTransformationSettings")]
    public ClaimTransformationSettings ClaimTransformationSettings { get; set; }
}
