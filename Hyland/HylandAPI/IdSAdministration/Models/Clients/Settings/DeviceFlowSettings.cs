using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class DeviceFlowSettings
{
    [JsonPropertyName("UserCodeType")]
    public string UserCodeType { get; set; }

    [JsonPropertyName("DeviceCodeLifetime")]
    public int DeviceCodeLifetime { get; set; } = 300;
}