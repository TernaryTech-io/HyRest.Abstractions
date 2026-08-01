using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Used to execute a query without requiring a filterId.
/// </summary>
public partial class DynamicFilterModelV2 : HylandBase
{
    /// <summary>
    /// Id of a Class.
    /// </summary>
    [JsonPropertyName("classId")]
    public string ClassId { get; set; }

    /// <summary>
    /// The collection of Constraints that will be used by the query to constrain object results. If using a macro, The baseObject will be used to resolve it if necessary.
    /// </summary>
    [JsonPropertyName("constraints")]
    public ICollection<ConstraintModelV2> Constraints { get; set; }

    /// <summary>
    /// The result columns that will be returned from query execution.
    /// </summary>
    [JsonPropertyName("columns")]
    public ICollection<ColumnModel> Columns { get; set; }

    /// <summary>
    /// The Attributes by which to sort the data.
    /// </summary>
    [JsonPropertyName("sorts")]
    public ICollection<SortModel> Sorts { get; set; }

    /// <summary>
    /// The context for which to apply to any Constraints the Filter uses.
    /// </summary>
    [JsonPropertyName("baseObject")]
    public ObjectModel BaseObject { get; set; }

    /// <summary>
    /// Id of the source Attribute to use for Related Object lookups, if blank or 0, this will use the default.
    /// </summary>
    [JsonPropertyName("sourceAttribute")]
    public string SourceAttribute { get; set; }

    /// <summary>
    /// The maximum results to be returned by this query.
    /// </summary>
    [JsonPropertyName("maxResults")]
    [System.ComponentModel.DataAnnotations.Range(1, int.MaxValue)]
    public int MaxResults { get; set; } = 2000;

    /// <summary>
    /// Whether the results should include distinct values.
    /// </summary>
    [JsonPropertyName("returnDistinctResults")]
    public string ReturnDistinctResults { get; set; } = "false";

    /// <summary>
    /// Whether the value of each filter column should truncate after 255 characters. When true, column values will truncate and return with '...' at the end of string.
    /// </summary>
    [JsonPropertyName("truncateTextFields")]
    public string TruncateTextFields { get; set; } = "true";
}

/// <summary>
/// Information required for executing a Filter.
/// </summary>
public partial class ExecuteFilterSettingsModelV2 : HylandBase
{
    /// <summary>
    /// ID for the Filter that is to be executed.
    /// </summary>
    [JsonPropertyName("filterId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string FilterId { get; set; }

    /// <summary>
    /// The context for which to apply to any Constraints the Filter uses.
    /// </summary>
    [JsonPropertyName("baseObject")]
    public ObjectModel BaseObject { get; set; }

    /// <summary>
    /// The collection of Constraints that will be used by the query to constrain object results. If using a macro, The baseObject will be used to resolve it if necessary.
    /// </summary>
    [JsonPropertyName("constraints")]
    public ICollection<ConstraintModelV2> Constraints { get; set; }

    /// <summary>
    /// The maximum results to be returned by this query. If the filter has a Maximum Results value configured, its value will take precedence over the value in the request.
    /// </summary>
    [JsonPropertyName("maxResults")]
    [System.ComponentModel.DataAnnotations.Range(1, int.MaxValue)]
    public int MaxResults { get; set; } = 2000;

    /// <summary>
    /// Whether the value of each filter column should truncate after 255 characters. When true, column values will truncate and return with '...' at the end of string.
    /// </summary>
    [JsonPropertyName("truncateTextFields")]
    public string TruncateTextFields { get; set; } = "true";
}

/// <summary>
/// Information about a Constraint.
/// </summary>
public partial class ConstraintModelV2 : HylandBase
{
    /// <summary>
    /// Path to the Attribute used in the Constraint.
    /// </summary>
    [JsonPropertyName("dataAddress")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DataAddress { get; set; }

    /// <summary>
    /// Value of the Constraint. Macros that are supported in Filter Constraints may be used.
    /// </summary>
    [JsonPropertyName("value")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Value { get; set; }

    [JsonPropertyName("operator")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public Operator Operator { get; set; }

    [JsonPropertyName("connector")]
    public Connector Connector { get; set; }

    /// <summary>
    /// Boolean indicating if an open parenthesis should be added to this where clause.
    /// </summary>
    [JsonPropertyName("leftParenthesis")]
    public bool LeftParenthesis { get; set; } = false;

    /// <summary>
    /// Boolean indicating if a closing parenthesis should be added to this where clause.
    /// </summary>
    [JsonPropertyName("rightParenthesis")]
    public bool RightParenthesis { get; set; } = false;
}