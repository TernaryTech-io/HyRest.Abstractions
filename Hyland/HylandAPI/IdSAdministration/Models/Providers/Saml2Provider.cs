using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class Saml2SecuritySettings
{
    [JsonPropertyName("EncryptionCertificatePath")]
    public string EncryptionCertificatePath { get; set; }

    [JsonPropertyName("SigningCertificatePath")]
    public string SigningCertificatePath { get; set; }

    [JsonPropertyName("SigningAlgorithm")]
    public string SigningAlgorithm { get; set; }

    [JsonPropertyName("WantAssertionsSigned")]
    public bool WantAssertionsSigned { get; set; }

    [JsonPropertyName("MinimumIncomingSigningAlgorithm")]
    public string MinimumIncomingSigningAlgorithm { get; set; }
}

public partial class Saml2BindingsSettings
{
    [JsonPropertyName("AuthenticationRequestBinding")]
    public int AuthenticationRequestBinding { get; set; }

    [JsonPropertyName("AssertionBinding")]
    public int AssertionBinding { get; set; }
}

public partial class Saml2ProtocolSettings
{
    [JsonPropertyName("IdentityProvider")]
    public string IdentityProvider { get; set; }

    [JsonPropertyName("ExternalIdPMetadataLocation")]
    public string ExternalIdPMetadataLocation { get; set; }

    [JsonPropertyName("SecuritySettings")]
    public Saml2SecuritySettings SecuritySettings { get; set; }

    [JsonPropertyName("BindingsSettings")]
    public Saml2BindingsSettings BindingsSettings { get; set; }
}

public partial class Saml2Provider : IAuthProvider
{
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Type")]
    public AuthProviderType Type { get; set; } = AuthProviderType.Saml2;

    [JsonPropertyName("ProtocolSettings")]
    public Saml2ProtocolSettings ProtocolSettings { get; set; }

    [JsonPropertyName("UserAttributeMappingSettings")]
    public UserAttributeMappingSettings UserAttributeMappingSettings { get; set; }

    [JsonPropertyName("UserProvisioningSettings")]
    public UserProvisioningSettings UserProvisioningSettings { get; set; }

    [JsonPropertyName("ClaimTransformationSettings")]
    public ClaimTransformationSettings ClaimTransformationSettings { get; set; }
}
