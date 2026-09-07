using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class TokenExchangeMetadata
{
    [JsonPropertyName("CacheDurationInSeconds")]
    public int CacheDurationInSeconds { get; set; }
}

public partial class TokenExchangeProtocolSettings
{
    [JsonPropertyName("Metadata")]
    public TokenExchangeMetadata Metadata { get; set; }

    [JsonPropertyName("Issuer")]
    public string Issuer { get; set; }

    [JsonPropertyName("SubjectTokenType")]
    public string SubjectTokenType { get; set; }
}

public partial class TokenExchangeProvider : IAuthProvider
{
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Type")]
    public AuthProviderType Type { get; set; } = AuthProviderType.TokenExchange;

    [JsonPropertyName("ProtocolSettings")]
    public TokenExchangeProtocolSettings ProtocolSettings { get; set; }

    [JsonPropertyName("UserAttributeMappingSettings")]
    public UserAttributeMappingSettings UserAttributeMappingSettings { get; set; }

    [JsonPropertyName("UserProvisioningSettings")]
    public UserProvisioningSettings UserProvisioningSettings { get; set; }

    [JsonPropertyName("ClaimTransformationSettings")]
    public ClaimTransformationSettings ClaimTransformationSettings { get; set; }
}
