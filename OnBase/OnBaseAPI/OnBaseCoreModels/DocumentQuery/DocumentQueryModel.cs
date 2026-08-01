
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Represents the result of a query
/// </summary>
public partial class QueryResultsModel : OnBaseItemCollection<DocumentResultModel>
{

}

/// <summary>
/// Document metadata.
/// </summary>
public partial class DocumentResultModel : OnBaseItem
{
    /// <summary>
    /// An array of Display columns returned from executing a query.
    /// </summary>
    [JsonPropertyName("displayColumns")]
    public ICollection<DisplayColumnModel> DisplayColumns { get; set; } = [];
}

/// <summary>
/// Display column values.
/// </summary>

public partial class DisplayColumnModel : HylandBase
{
    /// <summary>
    /// Index representing the Display column configuration
    /// <br/>associated with this Display column.
    /// </summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }
    [JsonPropertyName("values")]
    public ICollection<string> Values { get; set; } = [];
}

/// <summary>
/// Represents the information required to execute a query.
/// </summary>
public partial class QueryInformationModel : HylandBase
{
    /// <summary>
    /// An array of query types.
    /// </summary>
    [JsonPropertyName("queryType")]
    public ICollection<QueryTypeModel> QueryType { get; set; } = [];

    /// <summary>
    /// Limits the number of results that the execution of
    /// <br/>a query can create.
    /// </summary>
    [JsonPropertyName("maxResults")]
    public int MaxResults { get; set; }

    /// <summary>
    /// An array of keywords used to execute a query.
    /// </summary>
    [JsonPropertyName("queryKeywordCollection")]
    public ICollection<QueryKeywordModel> QueryKeywordCollection { get; set; } = [];

    /// <summary>
    /// An array of date ranges used to execute a query.
    /// </summary>
    [JsonPropertyName("documentDateRangeCollection")]
    public ICollection<DateRange> DocumentDateRangeCollection { get; set; } = [];

    /// <summary>
    /// An array of user defined display columns. If the
    /// <br/>query already has display columns defined, the predefined
    /// <br/>display columns will be ignored and the user defined
    /// <br/>display columns will be used.
    /// </summary>
    [JsonPropertyName("userDisplayColumns")]
    public ICollection<UserDefinedDisplayColumn> UserDisplayColumns { get; set; } = [];
}

/// <summary>
/// Represents a range of dates.
/// </summary>
public partial class DateRange : HylandBase
{
    /// <summary>
    /// The starting date of the date range.
    /// <br/>If no start date is present, a default minimum date will be used.
    /// </summary>
    [JsonPropertyName("start")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset Start { get; set; }

    /// <summary>
    /// The ending date of the date range.
    /// <br/>If no end date is present, a default maximum date will be used.
    /// </summary>
    [JsonPropertyName("end")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset End { get; set; }
}

/// <summary>
/// The type of query to execute.  DocumentType, DocumentTypeGroup, and CustomQuery type queries are supported.
/// <br/>See the /custom-queries documentation for which CustomQuery types are supported.
/// </summary>
public partial class QueryTypeModel : HylandBase
{
    /// <summary>
    /// The type of query to execute.  DocumentType, DocumentTypeGroup, and CustomQuery type queries are supported.
    /// <br/>See the /custom-queries documentation for which CustomQuery types are supported.
    /// </summary>
    [JsonPropertyName("type")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public QueryType Type { get; set; }

    /// <summary>
    /// An array of ids for the query
    /// </summary>
    [JsonPropertyName("ids")]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<string> Ids { get; set; } = [];
}

/// <summary>
/// Represents a keyword required to execute a query.
/// </summary>
public partial class QueryKeywordModel : HylandBase
{
    /// <summary>
    /// The keyword type Id for the keyword.
    /// </summary>
    [JsonPropertyName("typeId")]
    public string Id { get; set; }

    /// <summary>
    /// The keyword value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Represents the operator for the keyword value of
    /// <br/>this query keyword. Defaults to Equal if not present.
    /// </summary>
    [JsonPropertyName("operator")]
    public QueryKeywordOperator Operator { get; set; }

    /// <summary>
    /// Represents the relation of this query keyword to
    /// <br/>other query keywords. Defaults to And if not present.
    /// </summary>
    [JsonPropertyName("relation")]
    public QueryKeywordRelation Relation { get; set; }

}

/// <summary>
/// Represents a DisplayColumn that the user has defined for this query.
/// </summary>
public partial class UserDefinedDisplayColumn : HylandBase
{

    /// <summary>
    /// The keyword type Id for the DisplayColumn. If the
    /// <br/>DisplayColumn is not of type Keyword, this property can be
    /// <br/>omitted and only the displayColumnType is required.
    /// </summary>
    [JsonPropertyName("keywordTypeId")]
    public string? KeywordTypeId { get; set; }

    /// <summary>
    /// The attribute type for the Display Column.
    /// </summary>
    [JsonPropertyName("displayColumnType")]
    public UserDefinedDisplayColumnType DisplayColumnType { get; set; }

}

/// <summary>
/// Query handle information corresponding to a query.
/// </summary>
public partial class QueriesPostResponseModel : OnBaseItem
{

}

/// <summary>
/// Represents a collection of configurations of
/// <br/>a Display Column.
/// </summary>
public partial class DisplayColumnConfigurationCollectionModel : OnBaseItemCollection<DisplayColumnConfiguration>
{

}

/// <summary>
/// Represents the configuration of a Display Column.
/// </summary>
public partial class DisplayColumnConfiguration : OnBaseItem
{
    [JsonIgnore]
    private new string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    /// <summary>
    /// Index representing the Display column configuration
    /// <br/>associated with this Display column.
    /// </summary>
    [JsonPropertyName("index")]
    public int Index { get; set; }

    /// <summary>
    /// Describes the type of Display Column. If the value is `Keyword` than the `keywordTypeId` will be populated as well.
    /// </summary>
    [JsonPropertyName("type")]
    public DisplayColumnConfigurationType Type { get; set; }

    /// <summary>
    /// The Header value for the Display Column.
    /// </summary>
    [JsonPropertyName("heading")]
    public string? Heading { get; set; }

    /// <summary>
    /// The Keyword Type associated with the Display Column.
    /// <br/>Only necessary if the Display Column Type is "Keyword".
    /// </summary>
    [JsonPropertyName("keywordTypeId")]
    public string? KeywordTypeId { get; set; }
}