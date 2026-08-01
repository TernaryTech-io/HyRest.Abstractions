using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An Array of renditions.
/// </summary>    
public partial class RenditionCollectionModel : OnBaseItemCollection<RenditionModel>
{

}

/// <summary>
/// Rendition metadata
/// </summary>  
public partial class RenditionModel : OnBaseItem
{
    [JsonIgnore]
    private new string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// The unique identifier of the rendition.
    /// </summary>
    [JsonPropertyName("fileTypeId")]
    public string? FileTypeId { get; set; }

    /// <summary>
    /// The date the rendition was stored.
    /// </summary>
    [JsonPropertyName("created")]
    public string? Created { get; set; }

    /// <summary>
    /// The number of pages in the rendition.
    /// </summary>
    [JsonPropertyName("pageCount")]
    public int PageCount { get; set; }

    /// <summary>
    /// The user ID of the revision creator.
    /// </summary>
    [JsonPropertyName("createdByUserId")]
    public string? CreatedByUserId { get; set; }

    /// <summary>
    /// A comment for the revision.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}

