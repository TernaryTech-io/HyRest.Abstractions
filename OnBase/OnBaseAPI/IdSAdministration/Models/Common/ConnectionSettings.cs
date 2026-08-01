using System.Text.Json.Serialization;

namespace HyRest.Identity
{
    public partial class ConnectionSettings
    {
        [JsonPropertyName("ConnectionString")]
        public string ConnectionString { get; set; }

        [JsonPropertyName("Provider")]
        public ConnectionProvider Provider { get; set; }
    }
}