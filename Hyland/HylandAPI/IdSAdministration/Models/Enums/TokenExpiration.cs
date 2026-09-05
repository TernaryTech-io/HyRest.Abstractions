using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TokenExpiration
{
    _0 = 0,
    _1 = 1,
}
