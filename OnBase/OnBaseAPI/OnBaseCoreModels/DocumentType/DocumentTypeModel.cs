
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An array of document types.
/// </summary>    
public partial class DocumentTypeCollectionModel : OnBaseItemTypeCollection<DocumentTypeModel>
{

}

/// <summary>
/// Document Type metadata.
/// </summary>    
public partial class DocumentTypeModel : OnBaseItemType
{
    /// <summary>
    /// The unique identifier of the default file format for the document type
    /// </summary>
    [JsonPropertyName("defaultFileTypeId")]
    public string? DefaultFileTypeId { get; set; }

    /// <summary>
    /// The document date display name setting for the document type
    /// </summary>
    [JsonPropertyName("documentDateDisplayName")]
    public string? DocumentDateDisplayName { get; set; }

    /// <summary>
    /// The Id of the autofill keyset associated with this document type, if any.
    /// </summary>
    [JsonPropertyName("autofillKeywordSetId")]
    public string? AutofillKeywordSetId { get; set; }

    /// <summary>
    /// The id of the document type group the document type is assigned to.
    /// </summary>
    [JsonPropertyName("documentTypeGroupId")]
    public string? DocumentTypeGroupId { get; set; }

    /// <summary>
    /// Revision/Rendition properties of the document type.
    /// </summary>
    [JsonPropertyName("RevisionRenditionProperties")]
    public RevisionRenditionProperties RevisionRenditionProperties { get; set; } = new();
}

/// <summary>
/// Revision/Rendition settings of the document type.
/// </summary>    
public partial class RevisionRenditionProperties : HylandBase
{
    /// <summary>
    /// Indicates if the document type is revisable
    /// </summary>
    [JsonPropertyName("revisable")]
    public bool Revisable { get; set; }

    /// <summary>
    /// Indicates if the document is renditionable
    /// </summary>
    [JsonPropertyName("renditionable")]
    public bool Renditionable { get; set; }

    /// <summary>
    /// Comment settings on the document type
    /// </summary>
    [JsonPropertyName("commentSettings")]
    public DocumentTypeCommentSettings CommentSettings { get; set; }
}

/// <summary>
/// Settings for comments on the document type.
/// </summary>
public partial class DocumentTypeCommentSettings : HylandBase
{
    /// <summary>
    /// True if the document type is set to "Allow Comments", false otherwise.
    /// </summary>
    [JsonPropertyName("allowComments")]
    public bool AllowComments { get; set; }

    /// <summary>
    /// True if the document type is set to "Force Comment".
    /// </summary>
    [JsonPropertyName("forceComment")]
    public bool ForceComment { get; set; }

    /// <summary>
    /// True if document type is set to "Save first revision with no comment"
    /// </summary>
    [JsonPropertyName("firstRevisionNoComment")]
    public bool FirstRevisionNoComment { get; set; }
}
