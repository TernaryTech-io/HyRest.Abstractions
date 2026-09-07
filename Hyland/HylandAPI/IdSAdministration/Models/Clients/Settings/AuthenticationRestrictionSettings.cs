using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class AuthenticationRestrictionSettings
{
    [JsonPropertyName("EnableLocalLogin")]
    public bool EnableLocalLogin { get; set; } = true;

    [JsonPropertyName("IdentityProviderRestrictions")]
    public ICollection<string> IdentityProviderRestrictions { get; set; } = [];

    [JsonPropertyName("UserSsoLifetime")]
    public int? UserSsoLifetime { get; set; }

    [JsonPropertyName("AllowOfflineAccess")]
    public bool AllowOfflineAccess { get; set; } = false;

    [JsonPropertyName("AllowAccessTokensViaBrowser")]
    public bool AllowAccessTokensViaBrowser { get; set; } = false;

    [JsonPropertyName("AllowedGrantTypes")]
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public ICollection<string> AllowedGrantTypes { get; set; } = [];

    [JsonPropertyName("AllowedScopes")]
    [System.ComponentModel.DataAnnotations.Required]
    [System.ComponentModel.DataAnnotations.MinLength(1)]
    public ICollection<string> AllowedScopes { get; set; } = [];
}

