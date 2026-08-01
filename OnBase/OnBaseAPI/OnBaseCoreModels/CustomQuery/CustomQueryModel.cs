using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An array of custom queries.
/// </summary>
public partial class CustomQueryCollectionModel : OnBaseItemTypeCollection<CustomQueryModel>
{

}
/// <summary>
/// Custom query metadata
/// </summary>
public partial class CustomQueryModel : OnBaseItemType
{
    /// <summary>
    /// Information describing the usage and/or purpose of the custom query
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    [JsonPropertyName("dateOptions")]
    public CustomQueryDateOptions? DateOptions { get; set; }

    /// <summary>
    /// The type of this custom query.
    /// <br/>
    /// <br/>`DocumentType` is a query configured to limit the results to preselected document type(s).
    /// <br/>
    /// <br/>`DocumentTypeGroup` is a query configured to limit the results to preselected document type group(s).
    /// <br/>
    /// <br/>`Keyword` is a query configured to limit the results to preselected keyword type(s).
    /// <br/>
    /// <br/>`SQL` is a query configured with a SQL statement.
    /// </summary>
    [JsonPropertyName("queryType")]
    public CustomQueryQueryType QueryType { get; set; }

}

/// <summary>
/// Date options set on a custom query
/// </summary>
public partial class CustomQueryDateOptions : HylandBase
{
    /// <summary>
    /// Date search option on the custom query
    /// </summary>
    [JsonPropertyName("dateSearch")]
    public CustomQueryDateSearchOptions DateSearch { get; set; }

    [JsonPropertyName("defaultDateRange")]
    public CustomQueryDefaultDateRangeModel? DefaultDateRange { get; set; }
}

/// <summary>
/// Represents default date set on the custom query. This is set when date search option is set to 'SingleDate' or 'DateRange'.
/// </summary>
public partial class CustomQueryDefaultDateRangeModel : HylandBase
{
    /// <summary>
    /// Default start date.
    /// <br/>format - date
    /// </summary>
    [JsonPropertyName("start")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset Start { get; set; }

    /// <summary>
    /// Default end date.
    /// <br/>This is equal to `defaultStartDate` if single date option is set as default.
    /// <br/>format - date
    /// </summary>
    [JsonPropertyName("end")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset End { get; set; }
}

/// <summary>
/// A lightweight array of keyword types for custom queries.
/// </summary>
public partial class CustomQueryKeywordTypeCollectionModel : OnBaseItemTypeCollection<KeywordTypeModel>
{

} 

