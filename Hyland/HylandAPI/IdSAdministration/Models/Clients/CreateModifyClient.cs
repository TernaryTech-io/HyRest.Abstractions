using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class CreateModifyClient
{
    [JsonPropertyName("Enabled")]
    public bool Enabled { get; set; } = true;

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
    public ICollection<string> RedirectUris { get; set; } = [];

    [JsonPropertyName("AllowedFrameAncestors")]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<string> AllowedFrameAncestors { get; set; } = [];

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
    public SecretSettingsModel SecretSettings { get; set; } = new SecretSettingsModel();

    [JsonPropertyName("SecuritySettings")]
    [System.ComponentModel.DataAnnotations.Required]
    public SecuritySettings SecuritySettings { get; set; } = new SecuritySettings();
    public static implicit operator CreateModifyClient(Client model)
    {
        var c = new CreateModifyClient();
        c.Enabled = model.Enabled;
        c.ClientName = model.ClientName;
        c.Description = model.Description;
        c.ProtocolType = model.ProtocolType;
        c.IncludeXFrameOptions = model.IncludeXFrameOptions;
        c.RedirectUris = model.RedirectUris;
        c.AllowedFrameAncestors = model.AllowedFrameAncestors;
		c.TokenSettings = model.TokenSettings;
		c.LogoutSettings = model.LogoutSettings;
		c.PkceSettings = model.PkceSettings;
        c.DeviceFlowSettings = model.DeviceFlowSettings;
		c.SecretSettings = model.SecretSettings;
        c.SecuritySettings = model.SecuritySettings;
        return c;        
    }
 }