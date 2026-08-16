using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Describes data to be used in retrieving a set of data for a specified Object.
/// </summary>    
public partial class ObjectQueryModel : HylandBase
{

    /// <summary>
    /// The result columns that will be returned from query execution.
    /// </summary>
    [JsonPropertyName("columns")]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<ColumnModel> Columns { get; set; } = new System.Collections.ObjectModel.Collection<ColumnModel>();

}