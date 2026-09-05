using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class CasProtocolSettings
{
    [JsonPropertyName("IdentityProvider")]
    public string IdentityProvider { get; set; }

    [JsonPropertyName("ProtocolVersion")]
    public int ProtocolVersion { get; set; }
}

public partial class CasProvider : IAuthProvider
{
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Type")]
    public AuthProviderType Type { get; set; } = AuthProviderType.Cas;

    [JsonPropertyName("ProtocolSettings")]
    public CasProtocolSettings ProtocolSettings { get; set; }

    [JsonPropertyName("UserAttributeMappingSettings")]
    public UserAttributeMappingSettings UserAttributeMappingSettings { get; set; }

    [JsonPropertyName("UserProvisioningSettings")]
    public UserProvisioningSettings UserProvisioningSettings { get; set; }

    [JsonPropertyName("ClaimTransformationSettings")]
    public ClaimTransformationSettings ClaimTransformationSettings { get; set; }
}
