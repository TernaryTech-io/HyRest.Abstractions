using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class SsoGroupMapping
{
    [JsonPropertyName("ClientId")]
    public string ClientId { get; set; }

    [JsonPropertyName("Groups")]
    public ICollection<string> Groups { get; set; } = [];
}
