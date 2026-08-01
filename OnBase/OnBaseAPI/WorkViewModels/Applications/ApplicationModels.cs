using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Information about Applications.
/// </summary>
public partial class ApplicationCollectionModel : OnBaseItemTypeCollection<ApplicationModel>
{

}

/// <summary>
/// Information about an Application.
/// </summary>
public partial class ApplicationModel : OnBaseItemType
{    

    /// <summary>
    /// Description of this Application.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Identifier of the catalog to use for Full Text searching for this Application.
    /// </summary>
    [JsonPropertyName("fullTextCatalogId")]
    public string? FullTextCatalogId { get; set; }

    /// <summary>
    /// Identifier of the default Filter for this Application.
    /// </summary>
    [JsonPropertyName("defaultFilterId")]
    public string? DefaultFilterId { get; set; }

}
