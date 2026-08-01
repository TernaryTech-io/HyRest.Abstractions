using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HyRest.API.Models;

/// <summary>
/// A collection of Filter Result.
/// </summary>
public partial class FilterResultCollectionModel : HylandBase
{

    [JsonPropertyName("results")]
    public ICollection<ObjectResultModel> Results { get; set; }

    /// <summary>
    /// This is to be used by the ribbon to toggle the 'Create' button on and off
    /// </summary>
    [JsonPropertyName("allowDirectCreate")]
    public bool AllowDirectCreate { get; set; }
}

/// <summary>
/// Used to execute a query without requiring a filterId.
/// </summary>    
public partial class DynamicFilterModel : HylandBase
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
    public ICollection<ConstraintModel> Constraints { get; set; }

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
    public AbbreviatedObjectModel BaseObject { get; set; }

    /// <summary>
    /// Id of the source Attribute to use for Related Object lookups. The query will use the default if this value is blank or 0.
    /// </summary>
    [JsonPropertyName("sourceAttribute")]
    public string SourceAttribute { get; set; }

    /// <summary>
    /// The maximum results to be returned by this query.
    /// </summary>
    [JsonPropertyName("maxResults")]
    public string MaxResults { get; set; }
}



public partial class ExecuteFilterSettingsModel : HylandBase
{

    /// <summary>
    /// ID for the Filter that is to be executed.
    /// </summary>
    [JsonPropertyName("filterId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string FilterId { get; set; }

    [JsonPropertyName("baseObject")]
    public AbbreviatedObjectModel BaseObject { get; set; }

    /// <summary>
    /// The collection of Constraints that will be used by the query to constrain object results. If using a macro, The baseObject will be used to resolve it if necessary.
    /// </summary>
    [JsonPropertyName("constraints")]
    public ICollection<ConstraintModel> Constraints { get; set; }

    /// <summary>
    /// Attribute to use for noting which class to displaying this object as when opening a result from this Filter.
    /// </summary>
    [JsonPropertyName("displayAs")]
    public string DisplayAs { get; set; }

    /// <summary>
    /// The maximum results to be returned by this query.
    /// </summary>
    [JsonPropertyName("maxResults")]
    public string MaxResults { get; set; }
}


/// <summary>
/// A collection of Fixed Constraints.
/// </summary>    
public partial class ConstraintCollectionModel : Collection<ConstraintModel>
{

}



