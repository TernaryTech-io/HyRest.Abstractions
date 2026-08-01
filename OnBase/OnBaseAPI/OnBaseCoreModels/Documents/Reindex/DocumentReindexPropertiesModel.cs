
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Metadata that can be modified on a document.
/// </summary>    
public partial class DocumentReindexPropertiesModel : HylandBase
{
    /// <summary>
    /// The document type id to be reindexed into.
    /// </summary>
    [JsonPropertyName("targetDocumentTypeId")]
    public string? TargetDocumentTypeId { get; set; }

    /// <summary>
    /// The file type id to be reindexed into. This is only necessary if attempting to change the
    /// <br/>file type ID of the default rendition of the latest revision.
    /// </summary>
    [JsonPropertyName("targetFileTypeId")]
    public string? TargetFileTypeId { get; set; }

    /// <summary>
    /// Boolean indicating if the document should be reindexed as specified.
    /// <br/>This should be used in conjunction with a Revisable/Renditionable document type to
    /// <br/>indicate that the document should be reindexed as specified regardless of the document type
    /// <br/>settings for revisions and renditions.
    /// <br/>This would be considered false by default and if it's a Revisable/Renditionable document type,
    /// <br/>existing documents are checked to find matching documents for which this new document can be
    /// <br/>added as a Revision/Rendition.
    /// </summary>
    [JsonPropertyName("storeAsNew")]
    public bool StoreAsNew { get; set; }

    /// <summary>
    /// The revision comment that will be saved during reindex if the document is
    /// <br/>revisiable.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// The document date.
    /// </summary>
    [JsonPropertyName("documentDate")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset DocumentDate { get; set; }

    /// <summary>
    /// An array of keywords grouped by the keyword group they belong to.
    /// </summary>
    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; } 
}

/// <summary>
/// Meta-data information required to reindex as revision
/// </summary>
public partial class RevisionReindexProperties : DiscriminatorObject
{
    /// <summary>
    /// The revision comment that will be saved during reindex if the document
    /// <br/>is revisiable.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// The document id of the document that is being reindexed as a new revision.
    /// </summary>
    [JsonPropertyName("sourceDocumentId")]
    public string? SourceDocumentId { get; set; }

    /// <summary>
    /// A value indicating whether to append the source document at the end of the target document.
    /// <br/>Only the image file type supports this option.
    /// </summary>
    [JsonPropertyName("appendNewRevision")]
    public bool AppendNewRevision { get; set; }

    /// <summary>
    /// An array of keywords grouped by the keyword group they belong to.
    /// </summary>
    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; } = new();
}

/// <summary>
/// Meta-data information required to reindex as rendition
/// </summary>

public partial class RenditionReindexProperties : DiscriminatorObject
{
    /// <summary>
    /// The rendition comment that will be saved during reindex if the document
    /// <br/>is revisiable.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// The file type id that the document will be reindexed to. If the file type does not need to be changed,
    /// <br/>then this property does not need to be passed in.
    /// </summary>
    [JsonPropertyName("targetFileTypeId")]
    public string? TargetFileTypeId { get; set; }

    /// <summary>
    /// The document id of the document that is being reindexed as a new rendition.
    /// </summary>
    [JsonPropertyName("sourceDocumentId")]
    public string? SourceDocumentId { get; set; }

    /// <summary>
    /// A value indicating whether to append the source document at the end of the target document.
    /// <br/>Only the image file type supports this option.
    /// </summary>
    [JsonPropertyName("appendPages")]
    public bool AppendPages { get; set; }

    /// <summary>
    /// An array of keywords grouped by the keyword group they belong to.
    /// </summary>
    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; } = new();

}
