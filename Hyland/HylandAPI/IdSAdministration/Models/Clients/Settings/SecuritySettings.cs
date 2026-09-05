using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class SecuritySettings
{
    [JsonPropertyName("AllowedCorsOrigins")]
    public List<string> AllowedCorsOrigins { get; set; } = [];
}
