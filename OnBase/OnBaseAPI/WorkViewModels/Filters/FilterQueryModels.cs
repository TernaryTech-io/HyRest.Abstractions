using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Id of the newly created query results
/// </summary>    
public partial class PostQueryResponseModel : HylandBase
{

    /// <summary>
    /// Id of the query.
    /// </summary>
    [JsonPropertyName("queryId")]
    public string QueryId { get; set; }
}