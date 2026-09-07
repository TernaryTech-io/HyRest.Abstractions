using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class UserProvisioningSettings
{
    [JsonPropertyName("UserProvisioningEnabled")]
    public bool UserProvisioningEnabled { get; set; }

    [JsonPropertyName("UserProvisioningCreateEnabled")]
    public bool UserProvisioningCreateEnabled { get; set; }

    [JsonPropertyName("UserProvisioningUpdateEnabled")]
    public bool UserProvisioningUpdateEnabled { get; set; }

    [JsonPropertyName("DefaultSsoGroupMapping")]
    public ICollection<SsoGroupMapping> DefaultSsoGroupMapping { get; set; } = [];
}
