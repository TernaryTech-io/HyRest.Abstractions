using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AccessTokenType
{
    _0 = 0,
    _1 = 1,
}
