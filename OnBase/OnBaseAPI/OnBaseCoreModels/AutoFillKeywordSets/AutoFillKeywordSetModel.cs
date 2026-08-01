using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An array of autofill keyword sets.
/// </summary>    
public partial class AutoFillKeywordSetCollectionModel : OnBaseItemTypeCollection<AutoFillKeywordSetModel>
{

}

/// <summary>
/// Autofill keyword set metadata.
/// </summary>    
public partial class AutoFillKeywordSetModel : OnBaseItemType
{        

    /// <summary>
    /// The keyword type id of the autofill keyword set's primary key.
    /// </summary>
    [JsonPropertyName("primaryKeywordTypeId")]
    public string? PrimaryKeywordTypeId { get; set; }

    /// <summary>
    /// Indicates that the autofill keyword set is external.
    /// </summary>
    [JsonPropertyName("external")]
    public bool External { get; set; }
}

/// <summary>
/// A representation of keyword type information for a autofill type.
/// </summary>
public partial class AutoFillKeywordSetKeywordTypeCollectionModel : OnBaseItemTypeCollection<KeywordTypeModel>
{
        
}


/// <summary>
/// An array of autofill keyword set data.
/// </summary>
public partial class KeywordSetDataCollectionModel : OnBaseItemCollection<KeywordSetDataModel>
{

}

/// <summary>
/// A collection of autofill keyword set keyword data.
/// </summary>
public partial class KeywordSetDataModel : OnBaseItem
{
    /// <summary>
    /// An array of keyword values associated with an auto fill keyword set data object.
    /// </summary>
    [JsonPropertyName("keywords")]
    public ICollection<AutoFillKeywordSetKeywordModel> Keywords { get; set; } = [];
}

/// <summary>
/// Autofill keyword set keyword data.
/// </summary>
public partial class AutoFillKeywordSetKeywordModel : OnBaseItem
{
    /// <summary>
    /// The keyword type id.
    /// </summary>
    [JsonPropertyName("typeId")]
    public new string? Id { get; set; }
    /// <summary>
    /// The keyword value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A collection of AutoFill Keyword Set Data Set items that match a Primary
/// <br/>Keyword value.
/// </summary>
public partial class AutoFillMultipleMatchesResponse : OnBaseItem
{
    [JsonIgnore]
    private new string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    /// <summary>
    /// An array of autofill keyword set data.
    /// </summary>
    [JsonPropertyName("autoFillKeywordSetData")]
    public ICollection<KeywordSetDataModel> AutoFillKeywordSetData { get; set; } = [];

}

/// <summary>
/// Result Keyword Collection.
/// </summary>
public partial class IndexingModifiersPostResponse : HylandBase
{

    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; } = new();
}

/// <summary>
/// The  properties required to perform AutoFill Keyword Set expansion.
/// </summary>
public partial class ReindexAutoFillExpansionModifierProperties : DiscriminatorObject
{
    /// <summary>
    /// The ID of the Document containing the keywords.
    /// </summary>
    [JsonPropertyName("documentId")]
    public string? DocumentId { get; set; }

    /// <summary>
    /// The ID of the target Document Type containing the keywords being modified. This is the
    /// <br/>target Document Type during the Reindex process.
    /// </summary>
    [JsonPropertyName("targetDocumentTypeId")]
    public string? TargetDocumentTypeId { get; set; }

    /// <summary>
    /// If selection is required for expansion to occur, the list of AutoFill Keyword
    /// <br/>Set Data Set Ids that the server will expand.
    /// </summary>
    [JsonPropertyName("autoFillKeywordSetDataIds")]
    public ICollection<string> AutoFillKeywordSetDataIds { get; set; } = [];

    /// <summary>
    /// The Primary Keyword value of the AutoFill Keyword Set.
    /// </summary>
    [JsonPropertyName("autoFillKeywordSetPrimaryKeyword")]
    public AutoFillKeywordSetKeywordModel AutoFillKeywordSetPrimaryKeyword { get; set; } = new();

    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; } = new();

    /// <summary>
    /// If any Keyword Types configured for an AutoFill Keyword Set are part of
    /// <br/>a MultiInstance Keyword Group, a index that relates to the order of
    /// <br/>MultiInstance Keyword Group passed in is required.  Example. If expanding
    /// <br/>into a MultiInstance Group that has 3 instances, and the second one is the desired
    /// <br/>group to be updated, 2 should be passed in.
    /// </summary>
    [JsonPropertyName("keywordGroupIndex")]
    public int KeywordGroupIndex { get; set; }
}

/// <summary>
/// The properties required to perform AutoFill Keyword Set expansion.
/// </summary>

public partial class ArchivalAutoFillExpansionModifierProperties : DiscriminatorObject
{
    /// <summary>
    /// The ID of the Document Type containing the keywords being modified. This is the document
    /// <br/>type that the document is going to be archived into.
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    public string? DocumentTypeId { get; set; }

    /// <summary>
    /// If selection is required for expansion to occur, the list of AutoFill Keyword
    /// <br/>Set Data Set Ids that the server will expand.
    /// </summary>
    [JsonPropertyName("autoFillKeywordSetDataIds")]
    public ICollection<string> AutoFillKeywordSetDataIds { get; set; } = [];

    /// <summary>
    /// The Primary Keyword value of the AutoFill Keyword Set.
    /// </summary>
    [JsonPropertyName("autoFillKeywordSetPrimaryKeyword")]
    public AutoFillKeywordSetKeywordModel AutoFillKeywordSetPrimaryKeyword { get; set; } = new();

    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; } = new();

    /// <summary>
    /// If any Keyword Types configured for an AutoFill Keyword Set are part of
    /// <br/>a MultiInstance Keyword Group, a index that relates to the order of
    /// <br/>MultiInstance Keyword Group passed in is required.  Example. If expanding
    /// <br/>into a MultiInstance Group that has 3 instances, and the second one is the desired
    /// <br/>group to be updated, 2 should be passed in.
    /// </summary>
    [JsonPropertyName("keywordGroupIndex")]
    public int KeywordGroupIndex { get; set; }
}

/// <summary>
/// Properties that are required during AutoFill expansion regardless of method of expansion.
/// </summary>

public partial class AutoFillExpansionProperties : HylandBase
{
    /// <summary>
    /// If selection is required for expansion to occur, the list of AutoFill Keyword
    /// <br/>Set Data Set Ids that the server will expand.
    /// </summary>
    [JsonPropertyName("autoFillKeywordSetDataIds")]
    public ICollection<string> AutoFillKeywordSetDataIds { get; set; } = [];

    /// <summary>
    /// The Primary Keyword value of the AutoFill Keyword Set.
    /// </summary>
    [JsonPropertyName("autoFillKeywordSetPrimaryKeyword")]
    public AutoFillKeywordSetKeywordModel AutoFillKeywordSetPrimaryKeyword { get; set; } = new();

    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; } = new();

    /// <summary>
    /// If any Keyword Types configured for an AutoFill Keyword Set are part of
    /// <br/>a MultiInstance Keyword Group, a index that relates to the order of
    /// <br/>MultiInstance Keyword Group passed in is required.  Example. If expanding
    /// <br/>into a MultiInstance Group that has 3 instances, and the second one is the desired
    /// <br/>group to be updated, 2 should be passed in.
    /// </summary>
    [JsonPropertyName("keywordGroupIndex")]
    public int KeywordGroupIndex { get; set; }   
}
