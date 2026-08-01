using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Identity
{
    public partial class CreateModifyClient
    {
        [JsonPropertyName("Enabled")]
        public bool Enabled { get; set; } = false;

        [JsonPropertyName("ClientName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[A-Za-z0-9_ -]+$")]
        public string ClientName { get; set; }

        [JsonPropertyName("Description")]
        [System.ComponentModel.DataAnnotations.StringLength(256)]
        public string Description { get; set; }

        [JsonPropertyName("ProtocolType")]
        public string ProtocolType { get; set; } = "oidc";

        [JsonPropertyName("IncludeXFrameOptions")]
        public bool IncludeXFrameOptions { get; set; } = false;

        [JsonPropertyName("RedirectUris")]
        public ICollection<string> RedirectUris { get; set; }

        [JsonPropertyName("AllowedFrameAncestors")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<string> AllowedFrameAncestors { get; set; } = new System.Collections.ObjectModel.Collection<string>();

        [JsonPropertyName("TokenSettings")]
        [System.ComponentModel.DataAnnotations.Required]
        public TokenSettings TokenSettings { get; set; } = new TokenSettings();

        [JsonPropertyName("LogoutSettings")]
        [System.ComponentModel.DataAnnotations.Required]
        public LogoutSettings LogoutSettings { get; set; } = new LogoutSettings();

        [JsonPropertyName("AuthenticationRestrictionSettings")]
        [System.ComponentModel.DataAnnotations.Required]
        public AuthenticationRestrictionSettings AuthenticationRestrictionSettings { get; set; } = new AuthenticationRestrictionSettings();

        [JsonPropertyName("PkceSettings")]
        [System.ComponentModel.DataAnnotations.Required]
        public PkceSettings PkceSettings { get; set; } = new PkceSettings();

        [JsonPropertyName("DeviceFlowSettings")]
        [System.ComponentModel.DataAnnotations.Required]
        public DeviceFlowSettings DeviceFlowSettings { get; set; } = new DeviceFlowSettings();

        [JsonPropertyName("SecretSettings")]
        [System.ComponentModel.DataAnnotations.Required]
        public SecretSettings SecretSettings { get; set; } = new SecretSettings();

        [JsonPropertyName("SecuritySettings")]
        [System.ComponentModel.DataAnnotations.Required]
        public SecuritySettings SecuritySettings { get; set; } = new SecuritySettings();
    }
}