using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class PkceSettings
{
    [JsonPropertyName("RequirePkce")]
    public bool RequirePkce { get; set; } = false;

    [JsonPropertyName("AllowPlainTextPkce")]
    public bool AllowPlainTextPkce { get; set; } = false;
}

