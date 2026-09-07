using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class SecretSettingsModel
{
    [JsonPropertyName("ClientSecrets")]
    public ICollection<ClientSecret> ClientSecrets { get; set; } = [];

    [JsonPropertyName("RequireClientSecret")]
    public bool RequireClientSecret { get; set; } = true;
}
