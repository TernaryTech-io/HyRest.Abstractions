
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Instance data for keywords on a document
/// </summary>
public partial class KeywordCollectionModel : OnBaseItem
{
    /// <summary>
    /// Guid string to ensure integrity of restricted keyword values.
    /// </summary>
    public string? KeywordGuid { get; set; }
    /// <summary>
    /// An array of T items.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<KeywordGroupModel> Items { get; set; } = [];
}

/// <summary>
/// A group of keyword values.
/// </summary>    
public partial class KeywordGroupModel : OnBaseItem
{
    /// <summary>
    /// The keyword type group identifier, 'typeGroupId'. This field will be omitted when
    /// <br/>not associated with a `SingleInstance` or `MultiInstance` type
    /// <br/>group.
    /// </summary>
    [JsonPropertyName("typeGroupId")]
    public override string Id { get => base.Id; set => base.Id = value; }

    /// <summary>
    /// The identifier for the group of keywords. This field will be omitted
    /// <br/>when not associated with a `MultiInstance` type group.  This field must be omitted
    /// <br/>if creating a new instance of a `MultiInstance` type group.
    /// </summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>
    /// The identifier used to track restricted keyword data and assign it to
    /// <br/>an instance of a 'MultiInstance' type group.  This field is required for
    /// <br/>restricted keyword values existing on a 'MultiInstance' type group and is provided
    /// <br/>by the GET Keywords on a document or GET Default Keywords response.
    /// </summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }
    /// <summary>
    /// An array of keywords in the group.
    /// </summary>
    [JsonPropertyName("keywords")]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<KeywordModel> Keywords { get; set; } = [];
}