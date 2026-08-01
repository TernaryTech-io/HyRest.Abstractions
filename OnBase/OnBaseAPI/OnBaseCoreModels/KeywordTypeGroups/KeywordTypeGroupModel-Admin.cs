using System.Collections.ObjectModel;
using System.Text.Json.Serialization;


namespace HyRest.API.Models;

/// <summary>
/// Keyword Type Group data.
/// </summary>

public partial class KeywordTypeGroupModel : OnBaseItemType
{
    /// <summary>
    /// This keyset allows mutliple keysets to be selected when therer are duplicate rows for the same primary.
    /// </summary>
    [JsonPropertyName("multiInstanceKeywordTypeGroup")]
    public bool MultiInstanceKeywordTypeGroup { get; set; }

    /// <summary>
    /// This keygroup stores NULL values in the table.
    /// </summary>
    [JsonPropertyName("nullAllowed")]
    public bool NullAllowed { get; set; }

    /// <summary>
    /// The document date is stored in the keygroup table.
    /// </summary>
    [JsonPropertyName("dateStored")]
    public bool DateStored { get; set; }
}


public partial class KeywordTypeGroupPOST : KeywordTypeGroupModel
{

    /// <summary>
    /// An array of keyword types and squence numbers on keyword type groups.
    /// </summary>
    [JsonPropertyName("keywordTypes")]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<KeywordTypeKeywordTypeGroupAssignment> KeywordTypes { get; set; } = new Collection<KeywordTypeKeywordTypeGroupAssignment>();

}