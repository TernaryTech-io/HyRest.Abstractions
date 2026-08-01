using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Identity
{
    using System = global::System;

    
    public partial class IdsClient
    {
        [JsonPropertyName("TokenSettings")]
        public TokenSettings TokenSettings { get; set; }

        [JsonPropertyName("LogoutSettings")]
        public LogoutSettings LogoutSettings { get; set; }

        [JsonPropertyName("AuthenticationRestrictionSettings")]
        public AuthenticationRestrictionSettings AuthenticationRestrictionSettings { get; set; }

        [JsonPropertyName("PkceSettings")]
        public PkceSettings PkceSettings { get; set; }

        [JsonPropertyName("DeviceFlowSettings")]
        public DeviceFlowSettings DeviceFlowSettings { get; set; }

        [JsonPropertyName("SecretSettings")]
        public SecretSettings SecretSettings { get; set; }

        [JsonPropertyName("SecuritySettings")]
        public SecuritySettings SecuritySettings { get; set; }

        [JsonPropertyName("Enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("ClientId")]
        public string ClientId { get; set; }

        [JsonPropertyName("ClientName")]
        public string ClientName { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("ProtocolType")]
        public string ProtocolType { get; set; }

        [JsonPropertyName("IncludeXFrameOptions")]
        public bool IncludeXFrameOptions { get; set; }

        [JsonPropertyName("AllowedFrameAncestors")]
        public ICollection<string> AllowedFrameAncestors { get; set; }

        [JsonPropertyName("RedirectUris")]
        public ICollection<string> RedirectUris { get; set; }
    }
}