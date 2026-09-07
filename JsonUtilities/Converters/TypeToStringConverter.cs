using HyRest.Hyland.IdentityAdministration;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HyRest.Utilities;

public class EnumToStringWithSpace<TEnum> : JsonConverter<TEnum>
    where TEnum : Enum
{
    public override TEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return default;

        if (reader.TokenType != JsonTokenType.String)
            throw new JsonException("Expected a string for Stream.");
        string value = reader.GetString() ?? string.Empty;
        value = value.Replace(" ", "_");

        if (Enum.TryParse(typeof(TEnum), value, out object? result))
            return (TEnum)result;
        else
            return default;
    }
    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }
        writer.WriteStringValue(value.ToString().Replace("_", " "));
    }
}
public class StreamToBase64StringConverter : JsonConverter<Stream>
{
    public override Stream? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;

        if (reader.TokenType != JsonTokenType.String)
            throw new JsonException("Expected a string for Stream.");

        string base64String = reader.GetString() ?? string.Empty;
        if (string.IsNullOrEmpty(base64String))
            return new MemoryStream();

        byte[] bytes = Convert.FromBase64String(base64String);
        return new MemoryStream(bytes);
    }

    public override void Write(Utf8JsonWriter writer, Stream value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }

        using var memoryStream = new MemoryStream();
        value.CopyTo(memoryStream);
        byte[] bytes = memoryStream.ToArray();
        string base64String = Convert.ToBase64String(bytes);
        writer.WriteStringValue(base64String);
    }
}

public class StructToStringConverter<T> : JsonConverter<T>
    where T : struct, IBaseStruct
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
            throw new JsonException("Expected a string for Type.");

        string strValue = reader.GetString() ?? string.Empty;
        var item = T.MapByValue(strValue);
        return (T)item;
    }
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}

public class TypeToStringConverter : JsonConverter<Type>
{
    public override Type Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
            throw new JsonException("Expected a string for Type.");

        string value = reader.GetString() ?? string.Empty;
        Type type = Type.GetType(value) ?? throw new Exception("Could not determine type.");
        return type;
    }   

    public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.FullName);
    }
}

