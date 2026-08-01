using System.Text.Json;
using System.Text.Json.Serialization;

namespace HyRest.Utilities
{
    /// <summary>
    /// For converting HyRest Types to JSON for out APIs that might consume this library.
    /// </summary>
    public static class JsonUtility
    {
        public static JsonSerializerOptions Options => new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };
        public static string? Serialize<TObject>(TObject item)
            where TObject : class, IOnBaseRestService
            => JsonSerializer.Serialize(item, Options);
        public static string? Serialize(object item)
            => JsonSerializer.Serialize(item, Options);
    }
}
