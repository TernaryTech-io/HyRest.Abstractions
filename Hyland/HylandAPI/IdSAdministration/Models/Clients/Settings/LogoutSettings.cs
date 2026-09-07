using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class LogoutSettings
{
    [JsonPropertyName("PostLogoutRedirectUris")]
    public ICollection<string> PostLogoutRedirectUris { get; set; } = [];

    [JsonPropertyName("FrontChannelLogoutUri")]
    public string FrontChannelLogoutUri { get; set; }

    [JsonPropertyName("FrontChannelLogoutSessionRequired")]
    public bool FrontChannelLogoutSessionRequired { get; set; } = true;

    [JsonPropertyName("BackChannelLogoutUri")]
    public string BackChannelLogoutUri { get; set; }

    [JsonPropertyName("BackChannelLogoutSessionRequired")]
    public bool BackChannelLogoutSessionRequired { get; set; } = true;
}
