using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// A collection of Filter Bars.
/// </summary>
public partial class FilterBarCollectionModel : OnBaseItemTypeCollection<FilterBarModel>
{

}

/// <summary>
/// Information about a Filter Bar.
/// </summary>
public partial class FilterBarModel : OnBaseItemType
{

    /// <summary>
    /// Used in tooltips to describe the Filter Bar
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Specifies whether the Filter Bar is used for User-Defined Filters.
    /// </summary>
    [JsonPropertyName("allowNewItems")]
    public bool AllowNewItems { get; set; }
}

/// <summary>
/// A collection of Filter Bar Items.
/// </summary>    
public partial class FilterBarItemCollectionModel : OnBaseItemTypeCollection<FilterBarItemModel>
{
        
}

/// <summary>
/// Information about a Filter Bar Item.
/// </summary>
public partial class FilterBarItemModel : OnBaseItemType
{
    /// <summary>
    /// Used in tooltips to describe the Filter Bar Item.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Id of the Filter that this Filter Bar Item uses.
    /// </summary>
    [JsonPropertyName("filterId")]
    public string FilterId { get; set; }
}



/// <summary>
/// Used to constrain Filter backed Data Set.
/// </summary>
public partial class FilterDataSetModel : HylandBase
{
    /// <summary>
    /// Identifier for an object.
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("constraints")]
    public ICollection<ConstraintModel> Constraints { get; set; } = [];

    [JsonPropertyName("searchTerm")]
    public string SearchTerm { get; set; }

    /// <summary>
    /// The maximum results to be returned by this query.
    /// </summary>
    [JsonPropertyName("maxResults")]
    public string MaxResults { get; set; }
}

/// <summary>
/// A collection of FilterUserOverrideModels.
/// </summary>
public partial class FilterUserOverrideCollectionModel : HylandBase
{

    [JsonPropertyName("items")]
    public ICollection<FilterUserOverrideModel> Items { get; set; }
}

/// <summary>
/// Information about a filter user override.
/// </summary>
public partial class FilterUserOverrideModel : HylandBase
{

    [JsonPropertyName("columnWidth")]
    public string ColumnWidth { get; set; }

    [JsonPropertyName("filterViewAttributeId")]
    public string FilterViewAttributeId { get; set; }

    [JsonPropertyName("horizontalAlignment")]
    public FilterUserOverrideModelHorizontalAlignment HorizontalAlignment { get; set; }

    [JsonPropertyName("groupNum")]
    public string GroupNum { get; set; }

    [JsonPropertyName("sequenceNum")]
    public string SequenceNum { get; set; }

    [JsonPropertyName("sortDirection")]
    public FilterUserOverrideModelSortDirection SortDirection { get; set; }

    [JsonPropertyName("sortOrder")]
    public string SortOrder { get; set; }

    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
}