using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// A collection of Filters.
/// </summary>
public partial class FilterTypeCollectionModel : OnBaseItemTypeCollection<FilterTypeModel>
{

}

/// <summary>
/// Information about a Filter.
/// </summary>
public partial class FilterTypeModel : OnBaseItemType
{
    /// <summary>
    /// Id of a Class.
    /// </summary>
    [JsonPropertyName("classId")]
    public string? ClassId { get; set; }

    /// <summary>
    /// The result columns that will be returned from query execution.
    /// </summary>
    [JsonPropertyName("columnAttributes")]
    public ICollection<ColumnModel> ColumnAttributes { get; set; } = [];

    [JsonPropertyName("entryAttributes")]
    public ICollection<EntryConstraintModel> EntryConstraints { get; set; } = [];

    [JsonPropertyName("fixedAttributes")]
    public ICollection<ConstraintModel> FixedConstraints { get; set; } = [];

    /// <summary>
    /// The Attributes by which to sort the data.
    /// </summary>
    [JsonPropertyName("sortAttributes")]
    public ICollection<SortModel> SortAttributes { get; set; } = [];
}

/// <summary>
/// Denotes a column address that should be returned by a query.
/// </summary>
public partial class ColumnModel : HylandBase
{    
    [JsonPropertyName("heading")]
    public string? Heading { get; set; }
    [JsonPropertyName("dataType")]
    public AttributeTypeDataType DataType { get; set; }
    [JsonPropertyName("width")]
    public string? Width { get; set; }
    /// <summary>
    /// Path to the Attribute representing the desired column.
    /// </summary>
    [JsonPropertyName("dataAddress")]
    public string DataAddress { get; set; }
}

public partial class EntryConstraintModel : HylandBase
{
    /// <summary>
    /// String used to prompt the user for a Value.
    /// </summary>
    [JsonPropertyName("prompt")]
    public string? Prompt { get; set; }
    /// <summary>
    /// Path to the Attribute used in the user constraint.
    /// </summary>
    [JsonPropertyName("dataAddress")]
    public string? DataAddress { get; set; }

    [JsonPropertyName("dataType")]
    public AttributeTypeDataType DataType { get; set; }

    [JsonPropertyName("dataSetOptions")]
    public DataSetOptions DataSetOptions { get; set; }

    [JsonPropertyName("operator")]
    public Operator Operator { get; set; }

    /// <summary>
    /// If the entry constraint is a dataset, this will be the id of that dataset
    /// </summary>
    [JsonPropertyName("dataSetId")]
    public string? DataSetId { get; set; }
}


/// <summary>
/// Information about a Fixed Constraint.
/// </summary>    
public partial class ConstraintModel : HylandBase
{
    /// <summary>
    /// Path to the Attribute used in the Fixed Constraint.
    /// </summary>
    [JsonPropertyName("dataAddress")]
    public string? DataAddress { get; set; }

    /// <summary>
    /// Value of the Constraint. Macros that are supported in Filter Constraints may be used.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("operator")]
    public Operator Operator { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("connector")]
    public Connector Connector { get; set; }

    /// <summary>
    /// The number of open parenthesis characters that are to be placed before this where clause.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("leftParenthesisCount")]
    public ConstraintModelLeftParenthesisCount LeftParenthesisCount { get; set; }

    /// <summary>
    /// The number of close parenthesis characters that are to be placed after this where clause.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("rightParenthesisCount")]
    public ConstraintModelRightParenthesisCount RightParenthesisCount { get; set; }
}

/// <summary>
/// Information about a sort for a Filter.
/// </summary>    
public partial class SortModel : HylandBase
{
    /// <summary>
    /// Path to the Attribute used in the sort.
    /// </summary>
    [JsonPropertyName("dataAddress")]
    public string DataAddress { get; set; }

    [JsonPropertyName("sortOrder")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SortOrder SortOrder { get; set; }
}
