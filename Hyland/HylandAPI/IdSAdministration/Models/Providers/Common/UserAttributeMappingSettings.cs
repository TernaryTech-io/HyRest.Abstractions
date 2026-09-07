using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class UserAttributeMappingSettings
{
    [JsonPropertyName("userid")]
    public string UserId { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("realName")]
    public string RealName { get; set; }

    [JsonPropertyName("group")]
    public string Group { get; set; }
}
