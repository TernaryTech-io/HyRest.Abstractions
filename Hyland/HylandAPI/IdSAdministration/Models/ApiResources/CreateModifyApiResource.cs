using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class CreateModifyApiResource : IHylandItem
{
    [JsonPropertyName("Enabled")]
    public bool Enabled { get; set; } = false;

    [JsonPropertyName("DisplayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("Name")]
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 1)]
    public string Name { get; set; }

    [JsonPropertyName("Scopes")]
    public ICollection<string> Scopes { get; set; }

    [JsonPropertyName("UserClaims")]
    public ICollection<string> UserClaims { get; set; }

    [JsonPropertyName("ApiSecrets")]
    public ICollection<ClientSecret> ApiSecrets { get; set; }

    public static implicit operator CreateModifyApiResource(ApiResource apiResource)
    {
        var m = new CreateModifyApiResource();
        m.Enabled = apiResource.Enabled;
        m.DisplayName = apiResource.DisplayName;
        m.Name = apiResource.Name;
        m.Scopes = apiResource.Scopes;
        m.UserClaims = apiResource.UserClaims;
        m.ApiSecrets = apiResource.ApiSecrets;
        return m;
    }
}