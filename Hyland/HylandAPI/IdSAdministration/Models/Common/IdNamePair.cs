using System.Text.Json.Serialization;

namespace HyRest.Hyland.IdentityAdministration;

/// <summary>Reference to an object with an Id and Name</summary>
public partial class IdNamePair
{
    /// <summary>Id of the object</summary>
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    /// <summary>Name of the object</summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>Type of the object</summary>
    [JsonPropertyName("Type")]
    public string Type { get; set; }
}

