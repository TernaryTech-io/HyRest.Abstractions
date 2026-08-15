using System.Text.Json.Serialization;

namespace HyRest.API.Models;
/// <summary>
/// An array of keyword type groups.
/// </summary>
public partial class KeywordTypeGroupCollectionModel : OnBaseItemTypeCollection<KeywordTypeGroupModel>
{
    [JsonPropertyName("keywordOptions")]
    public KeywordOptionsModel KeywordOptions { get; set; } = new();
}

/// <summary>
/// Keyword type group metadata.
/// </summary>
public partial class KeywordTypeGroupModel : OnBaseItemType
{
    [JsonPropertyName("storageType")]
    public KeywordTypeGroupStorageType StorageType { get; set; }
    /// <summary>
    /// An array of keyword types.
    /// </summary>
    [JsonPropertyName("keywordTypes")]
    public ICollection<KeywordTypeModel> KeywordTypes { get; set; } = [];
}

/// <summary>
/// A group containing keyword type options in relation to the document type
/// <br/>they belong to.
/// </summary>    
public partial class KeywordOptionsModel : HylandBase
{
    /// <summary>
    /// An array of required keyword type ids for a document to be stored.
    /// </summary>
    [JsonPropertyName("requiredForArchivalKeywordTypeIds")]
    public ICollection<string> RequiredForArchivalKeywordTypeIds { get; set; } = [];

    /// <summary>
    /// An array of required keyword type ids for a document to be retrieved.
    /// </summary>
    [JsonPropertyName("requiredForRetrievalKeywordTypeIds")]
    public ICollection<string> RequiredForRetrievalKeywordTypeIds { get; set; } = [];

    /// <summary>
    /// An array of read only keyword type ids for a document type.
    /// </summary>
    [JsonPropertyName("readOnlyKeywordTypeIds")]
    public ICollection<string> ReadOnlyKeywordTypeIds { get; set; } = [];
}

/// <summary>
/// An array of keyword type group, document type assignments.
/// </summary>
public partial class DocumentTypeKeywordTypeGroupAssignmentCollection : OnBaseBaseCollection<KeywordTypeGroupDocumentTypeAssignment>
{

}

/// <summary>
/// An assignment of a document type to a keyword type group.
/// </summary>    
public partial class KeywordTypeGroupDocumentTypeAssignment : OnBaseBase
{

    /// <summary>
    /// Id of the keyword type group.
    /// </summary>
    [JsonPropertyName("keywordTypeGroupId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string KeywordTypeGroupId { get; set; }

    /// <summary>
    /// Id of the document type.
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DocumentTypeId { get; set; }
}

/// <summary>
/// An array of keyword types on a keyword type groups.
/// </summary>    
public partial class KeywordTypeKeywordTypeGroupsCollectionRetrieval : OnBaseBaseCollection<KeywordTypeKeywordTypeGroupRetrieval>
{
        
}

/// <summary>
/// An array of keyword types on a keyword type groups.
/// </summary>    
public partial class KeywordTypeKeywordTypeGroupCollectionAssignment : OnBaseBaseCollection<KeywordTypeKeywordTypeGroupAssignment>
{

}

/// <summary>
/// Keyword Type metadata.
/// </summary>

public partial class KeywordTypeKeywordTypeGroupRetrieval : OnBaseBase
{
    /// <summary>
    /// The unique identifier for the keyword type.
    /// </summary>
    [JsonPropertyName("keywordTypeId")]
    public string KeywordTypeId { get; set; }

    /// <summary>
    /// The unique identifier for the keyword type group.
    /// </summary>
    [JsonPropertyName("keywordTypeGroupId")]
    public string KeywordTypeGroupId { get; set; }

    /// <summary>
    /// The sequence number of this keyword type on a keyword type group
    /// </summary>
    [JsonPropertyName("sequenceNum")]
    public string SequenceNum { get; set; }
}

/// <summary>
/// Keyword Type metadata.
/// </summary>

public partial class KeywordTypeKeywordTypeGroupAssignment : OnBaseBase
{
    /// <summary>
    /// The unique identifier for keyword type group.
    /// </summary>
    [JsonPropertyName("keywordTypeGroupId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string KeywordTypeGroupId { get; set; }

    /// <summary>
    /// The unique identifier for the keyword type.
    /// </summary>
    [JsonPropertyName("keywordTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string KeywordTypeId { get; set; }

    /// <summary>
    /// The sequence number of this keyword type on a keyword type group
    /// </summary>
    [JsonPropertyName("sequenceNum")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string SequenceNum { get; set; }
}