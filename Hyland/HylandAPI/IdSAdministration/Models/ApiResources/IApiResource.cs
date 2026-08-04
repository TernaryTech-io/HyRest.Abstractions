using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Identity
{        
    public partial class ApiResource
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("Enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("Scopes")]
        public ICollection<string> Scopes { get; set; }

        [JsonPropertyName("UserClaims")]
        public ICollection<string> UserClaims { get; set; }

        [JsonPropertyName("ApiSecrets")]
        public ICollection<ClientSecret> ApiSecrets { get; set; }
    }
}
