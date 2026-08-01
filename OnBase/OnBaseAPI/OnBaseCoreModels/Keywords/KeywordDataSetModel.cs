using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HyRest.API.Models;

/// <summary>
/// A list of keyword dataset values
/// </summary>    
public partial class KeywordDatasetCollectionModel : HylandBase
{

    /// <summary>
    /// An array of keyword data set.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<KeywordDatasetValueModel> Items { get; set; }
}

public partial class KeywordDatasetValueModel : HylandBase
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