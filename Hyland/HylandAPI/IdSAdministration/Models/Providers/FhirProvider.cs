using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class FhirProtocolSettings
{
    [JsonPropertyName("DiscoveryDocumentEndPoint")]
    public string DiscoveryDocumentEndPoint { get; set; }

    [JsonPropertyName("ClientIds")]
    public ICollection<string> ClientIds { get; set; } = [];
}

public partial class FhirProvider : IAuthProvider
{
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Type")]
    public AuthProviderType Type { get; set; } = AuthProviderType.Fhir;

    [JsonPropertyName("ProtocolSettings")]
    public FhirProtocolSettings ProtocolSettings { get; set; }
}
