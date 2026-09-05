using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

/// <summary>
/// Deserializes/serializes the polymorphic "Providers" collection on a tenant by inspecting
/// the "Type" discriminator of each entry and mapping it to the matching <see cref="IAuthProvider"/> implementation.
/// </summary>
public class JsonProviderConverter : JsonConverter<ICollection<IAuthProvider>>
{
    public override ICollection<IAuthProvider>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;

        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException($"Expected start of array while reading '{nameof(IAuthProvider)}' collection.");

        var providers = new List<IAuthProvider>();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
                break;

            using var document = JsonDocument.ParseValue(ref reader);
            var root = document.RootElement;

            if (!root.TryGetProperty("Type", out var typeProperty))
                throw new JsonException("Provider entry is missing the required 'Type' discriminator property.");

            var providerType = (AuthProviderType)typeProperty.GetInt32();
            var rawText = root.GetRawText();

            IAuthProvider? provider = providerType switch
            {
                AuthProviderType.Saml2 => JsonSerializer.Deserialize<Saml2Provider>(rawText, options),
                AuthProviderType.Cas => JsonSerializer.Deserialize<CasProvider>(rawText, options),
                AuthProviderType.WsFederation => JsonSerializer.Deserialize<WsFederationProvider>(rawText, options),
                AuthProviderType.TokenExchange => JsonSerializer.Deserialize<TokenExchangeProvider>(rawText, options),
                AuthProviderType.Fhir => JsonSerializer.Deserialize<FhirProvider>(rawText, options),
                _ => throw new JsonException($"Unknown provider type '{providerType}'.")
            };

            if (provider is not null)
                providers.Add(provider);
        }

        return providers;
    }

    public override void Write(Utf8JsonWriter writer, ICollection<IAuthProvider> value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var provider in value)
        {
            JsonSerializer.Serialize(writer, provider, provider.GetType(), options);
        }
        writer.WriteEndArray();
    }
}
