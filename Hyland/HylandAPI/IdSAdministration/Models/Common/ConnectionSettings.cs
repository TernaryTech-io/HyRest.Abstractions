using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class ConnectionSettings
{
    [JsonPropertyName("ConnectionString")]
    public string ConnectionString { get; set; }

    [JsonPropertyName("Provider")]
    public ConnectionProvider Provider { get; set; }
}