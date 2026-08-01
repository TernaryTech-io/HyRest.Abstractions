using System.Text.Json.Serialization;

namespace HyRest;

public class HyRestConverterAttribute<T> : JsonConverterAttribute
    where T : JsonConverter
{
    public HyRestConverterAttribute() : base(typeof(T))
    {

    }
}