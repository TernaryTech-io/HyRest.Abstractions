using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// A list of documents.
/// </summary>    
public partial class DocumentCollectionModel : OnBaseItemCollection<DocumentModel>
{

}

/// <summary>
/// Document metadata.
/// </summary>    
public partial class DocumentModel : OnBaseItem
{
    /// <summary>
    /// The document name calculated by the Autoname string.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// The id of the Document Type for this document.
    /// </summary>
    [JsonPropertyName("typeId")]
    public string? TypeId { get; set; }
    /// <summary>
    /// The unique identifier of the user that created this document.
    /// </summary>
    [JsonPropertyName("createdByUserId")]
    public string? CreatedByUserId { get; set; }

    /// <summary>
    /// The date/time this document was stored.
    /// <br/> ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 Date and
    /// <br/>    time without time zone.
    /// </summary>
    [JsonPropertyName("storedDate")]
    public string? StoredDate { get; set; }

    /// <summary>
    /// The document date.
    /// </summary>
    [JsonPropertyName("documentDate")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset DocumentDate { get; set; }

    /// <summary>
    /// The document status of Active, Deleted or Inactive.
    /// </summary>
    [JsonPropertyName("status")]
    public DocumentStatus Status { get; set; }

    /// <summary>
    /// Meta-data information about the document that was brought in via scanning.
    /// </summary>
    [JsonPropertyName("captureProperties")]
    public CaptureProperties? CaptureProperties { get; set; }
}

/// <summary>
/// Metadata that can be modified on a document.
/// </summary>
public partial class DocumentPatchRequestModel : HylandBase
{
    /// <summary>
    /// The document date.
    /// </summary>
    [JsonPropertyName("documentDate")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset DocumentDate { get; set; }
}

/// <summary>
/// Meta-data information about the document that was brought in via scanning.
/// </summary>
public partial class CaptureProperties : HylandBase
{
    /// <summary>
    /// Indicates if the document is unidentified.
    /// </summary>
    [JsonPropertyName("unidentified")]
    public bool Unidentified { get; set; }

    /// <summary>
    /// The review status of NeedsAttention, NeedsRescan or NeedsManagerAttention. This should be used in conjunction with the `unidentified` property.
    /// </summary>
    [JsonPropertyName("reviewStatus")]
    public CapturePropertiesReviewStatus ReviewStatus { get; set; }
}

/// <summary>
/// Document handle information corresponding to a document.
/// </summary>
public partial class DocumentsPostResponse : OnBaseItem
{

}

/// <summary>
/// List of matching documents along with the options available for each when archiving into a Revisable/Renditionable document type.
/// </summary>
public partial class MatchedDocumentCollectionResponseModel : OnBaseItemCollection<MatchedDocumentModel>
{
    /// <summary>
    /// Boolean to indicate if the document can be stored as a new document.
    /// <br/>To continue adding the document as a new document, a POST request to '/documents' end-point must be made with 'storeAsNew' property set to 'true' in 'DocumentArchiveProperties'.
    /// </summary>
    [JsonPropertyName("canAddAsNew")]
    public bool CanAddAsNew { get; set; }
}

/// <summary>
/// A Revisable/Renditionable document that matched along with the options available to archive.
/// </summary>
public partial class MatchedDocumentModel : OnBaseItem
{
    /// <summary>
    /// Boolean indicating if the document can be added as a revision.
    /// <br/>To add the document as a new revision, a POST request to '/documents/{id}/revisions' must me made.
    /// </summary>
    [JsonPropertyName("canAddAsRevision")]
    public bool CanAddAsRevision { get; set; }

    /// <summary>
    /// Boolean indicating if the document can be added as a rendition.
    /// <br/>To add the document as a rendition, a POST request to '/documents/{id}/revisions/latest' must be made.
    /// </summary>
    [JsonPropertyName("canAddAsRendition")]
    public bool CanAddAsRendition { get; set; }
}

