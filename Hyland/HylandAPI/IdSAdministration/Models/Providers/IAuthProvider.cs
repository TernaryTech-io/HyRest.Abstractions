using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public interface IAuthProvider
{
    [JsonPropertyName("Id")]
    string Id { get; set; }

    [JsonPropertyName("Name")]
    string Name { get; set; }

    [JsonPropertyName("Type")]
    AuthProviderType Type { get; set; }
}
