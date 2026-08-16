using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// A list of keyword dataset values
/// </summary>    
public partial class KeywordDatasetCollectionModel : OnBaseBaseCollection<KeywordDatasetValueModel>
{

}

public partial class KeywordDatasetValueModel : OnBaseBase
{
    /// <summary>
    /// Dataset sequence number
    /// </summary>
    [JsonPropertyName("keywordSeqNum")]
    public string KeywordSeqNum { get; set; }

    /// <summary>
    /// Dataset value
    /// </summary>
    [JsonPropertyName("keywordValue")]
    public string KeywordValue { get; set; }
}