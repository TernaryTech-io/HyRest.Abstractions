using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

public partial class AdministrativeUserRequestModel
{
    [JsonPropertyName("Username")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [System.ComponentModel.DataAnnotations.StringLength(74)]
    public string Username { get; set; }
}