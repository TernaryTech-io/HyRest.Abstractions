using System.Text.Json.Serialization;

namespace HyRest.Identity
{
    public partial class Client
    {
        [JsonPropertyName("Enabled")]
        public bool Enabled { get; set; } = false;

        [JsonPropertyName("ClientId")]
        public required string ClientId { get; set; }

        [JsonPropertyName("ClientName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 5)]
        public required string ClientName { get; set; }

        [JsonPropertyName("Description")]
        [System.ComponentModel.DataAnnotations.StringLength(256)]
        public string? Description { get; set; }

        [JsonPropertyName("ProtocolType")]
        public string ProtocolType { get; set; } = "oidc";

        [JsonPropertyName("IncludeXFrameOptions")]
        public bool IncludeXFrameOptions { get; set; } = false;

        [JsonPropertyName("RedirectUris")]
        public ICollection<string> RedirectUris { get; set; } = [];

        [JsonPropertyName("AllowedFrameAncestors")]
        public ICollection<string> AllowedFrameAncestors { get; set; } = [];

        [JsonPropertyName("TokenSettings")]
        public TokenSettings? TokenSettings { get; set; }

        [JsonPropertyName("LogoutSettings")]
        public LogoutSettings? LogoutSettings { get; set; }

        [JsonPropertyName("AuthenticationRestrictionSettings")]
        public AuthenticationRestrictionSettings AuthenticationRestrictionSettings { get; set; }

        [JsonPropertyName("PkceSettings")]
        public PkceSettings? PkceSettings { get; set; }

        [JsonPropertyName("DeviceFlowSettings")]
        public DeviceFlowSettings? DeviceFlowSettings { get; set; }

        [JsonPropertyName("SecretSettings")]
        public SecretSettings? SecretSettings { get; set; }

        [JsonPropertyName("SecuritySettings")]
        public SecuritySettings? SecuritySettings { get; set; }
    }
}