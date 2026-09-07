using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class ClaimTransformationSettings
{
    [JsonPropertyName("StripDomainFromUserName")]
    public bool StripDomainFromUserName { get; set; }
}
