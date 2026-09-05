using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ConnectionProvider
{
    _1 = 1,
    _2 = 2,
}

