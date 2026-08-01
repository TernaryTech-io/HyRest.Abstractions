using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Configuration information for a Data Set.
/// </summary>    
public partial class DataSetModel : HylandBase
{
    /// <summary>
    /// Identifier for the data set.
    /// </summary>
    [JsonPropertyName("dataSetId")]
    public string DataSetId { get; set; }

    [JsonPropertyName("dataSetType")]
    public DataSetType DataSetType { get; set; }

    /// <summary>
    /// If this Data Set is a normal Data Set, and this Data Set has a parent Data Set, then this will be the identifier for that Data Set that is the parent.
    /// </summary>
    [JsonPropertyName("parentDataSetId")]
    public string ParentDataSetId { get; set; }

    /// <summary>
    /// If the Data Set is a Filter-backed Data Set, then this value will be the identifier for the Filter that is to be used.
    /// </summary>
    [JsonPropertyName("filterId")]
    public string FilterId { get; set; }
}

/// <summary>
/// A collection of Data Set Values.
/// </summary>
public partial class DataSetValueCollectionModel : HylandBase
{
    /// <summary>
    /// True when result set exceeds maximum results requested. No results are returned when hasExceededMaxResults is true.
    /// </summary>
    [JsonPropertyName("hasExceededMaxResults")]
    public bool HasExceededMaxResults { get; set; }

    /// <summary>
    /// The maximum allowed results in effect when resolving this result set.
    /// </summary>
    [JsonPropertyName("maximumResultsAllowed")]
    public int MaximumResultsAllowed { get; set; }

    [JsonPropertyName("items")]
    public ICollection<DataSetValueModel> Items { get; set; } 
}

/// <summary>
/// Contains a display value and a backing value for a specified Data Set.
/// </summary>
public partial class DataSetValueModel : HylandBase
{

    /// <summary>
    /// Localized value that is displayed in the client.
    /// </summary>
    [JsonPropertyName("displayValue")]
    public string DisplayValue { get; set; }

    /// <summary>
    /// Database value for the option.
    /// </summary>
    [JsonPropertyName("backingValue")]
    public string BackingValue { get; set; } 
}
