using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Document Type data.
/// </summary>

public partial class DocumentTypeModel : OnBaseItemType
{
    /// <summary>
    /// Determines where autodisplay keywords are shown on the document.
    /// </summary>
    [JsonPropertyName("autoDisplayKeywordLocation")]
    public DocumentTypeAutoDisplayKeywordLocation AutoDisplayKeywordLocation { get; set; } = DocumentTypeAutoDisplayKeywordLocation.UpperRight;

    /// <summary>
    /// The autoname string for this document type.
    /// </summary>
    [JsonPropertyName("autoNameString")]
    public string AutoNameString { get; set; } = "%N - %D2";

    /// <summary>
    /// Allow markups.  Only usable for image documents.
    /// </summary>
    [JsonPropertyName("allowMarkUp")]
    public bool AllowMarkUp { get; set; } = false;

    /// <summary>
    /// Allow caching for this document type.
    /// </summary>
    [JsonPropertyName("cachingAllowed")]
    public bool CachingAllowed { get; set; } = false;

    /// <summary>
    /// Use column index for this document type.
    /// </summary>
    [JsonPropertyName("columnIndexEnabled")]
    public bool ColumnIndexEnabled { get; set; } = false;

    /// <summary>
    /// Respect custom file types for this document type.
    /// </summary>
    [JsonPropertyName("customFileTypeAllowed")]
    public bool CustomFileTypeAllowed { get; set; } = false;

    /// <summary>
    /// Migrate this document type while when is indexed.
    /// </summary>
    [JsonPropertyName("diskGroupMigrationEnabled")]
    public bool DiskGroupMigrationEnabled { get; set; } = false;


    /// <summary>
    /// Use form feed to determine page breaks for this document type.
    /// </summary>
    [JsonPropertyName("formFeedsUsedForPageBreaks")]
    public bool FormFeedsUsedForPageBreaks { get; set; } = false;

    /// <summary>
    /// Show text with greenBar when displaying this file type.
    /// </summary>
    [JsonPropertyName("greenBarEnabled")]
    public bool GreenBarEnabled { get; set; } = true;

    /// <summary>
    /// Use keyword-based XML for this document type.
    /// </summary>
    [JsonPropertyName("keywordBasedXMLEnabled")]
    public bool KeywordBasedXMLEnabled { get; set; } = false;

    /// <summary>
    /// Auto-expand MIKG for this document type.
    /// </summary>
    [JsonPropertyName("mikgAutoExpandEnabled")]
    public bool MikgAutoExpandEnabled { get; set; } = false;

    /// <summary>
    /// Check all required keywords in MIKG for this document type.
    /// </summary>
    [JsonPropertyName("mikgKeywordsRequired")]
    public bool MikgKeywordsRequired { get; set; } = true;

    /// <summary>
    /// Overlay this document type.
    /// </summary>
    [JsonPropertyName("overlay")]
    public bool Overlay { get; set; } = false;

    /// <summary>
    /// Overlay only the first page of this document type.
    /// </summary>
    [JsonPropertyName("overlayFirstPageOnly")]
    public bool OverlayFirstPageOnly { get; set; } = false;

    /// <summary>
    /// Use property-based indexing for this document type.
    /// </summary>
    [JsonPropertyName("propertyBasedIndexing")]
    public bool PropertyBasedIndexing { get; set; } = false;

    /// <summary>
    /// Allow redact bitmaps for this document type.
    /// </summary>
    [JsonPropertyName("redactBitmapsAllowed")]
    public bool RedactBitmapsAllowed { get; set; } = false;

    /// <summary>
    /// Determines what order documents are listed in when retrieved.
    /// </summary>
    [JsonPropertyName("retrievalListSortOrder")]
    public DocumentTypeRetrievalListSortOrder RetrievalListSortOrder { get; set; } = DocumentTypeRetrievalListSortOrder.DateDescending;

    /// <summary>
    /// Enable scripts on this document type.
    /// </summary>
    [JsonPropertyName("scriptsAllowed")]
    public bool ScriptsAllowed { get; set; } = false;

    /// <summary>
    /// Store page references for this document type.
    /// </summary>
    [JsonPropertyName("storePageReferences")]
    public bool StorePageReferences { get; set; } = false;

    /// <summary>
    /// Force thumbnail caching for this document type.
    /// </summary>
    [JsonPropertyName("thumbnailCaching")]
    public bool ThumbnailCaching { get; set; } = false;

    /// <summary>
    /// Show thumbnails for this document type.
    /// </summary>
    [JsonPropertyName("thumbnailsEnabled")]
    public bool ThumbnailsEnabled { get; set; } = true;

    /// <summary>
    /// The default Disk Group utilized by this Document Type.
    /// </summary>
    [JsonPropertyName("defaultDiskGroupId")]
    public double DefaultDiskGroupId { get; set; }

    /// <summary>
    /// Determines if an unrestricted query warning is shown, and if so, if it cancels the query.
    /// </summary>
    [JsonPropertyName("defaultFileFormatId")]
    public double DefaultFileFormatId { get; set; }

    /// <summary>
    /// Query Restriction Options.
    /// </summary>
    [JsonPropertyName("queryRestrictions")]
    public QueryRestrictions QueryRestrictions { get; set; }

}


public partial class DocumentTypePOST : DocumentTypeModel
{

    /// <summary>
    /// Indicates initial user groups for this Document Type to be added to
    /// </summary>
    [JsonPropertyName("userGroupIds")]
    public ICollection<int> UserGroupIds { get; set; }

}

public partial class QueryRestrictions : HylandBase
{

    /// <summary>
    /// Show the query warning if no date is selected.
    /// </summary>
    [JsonPropertyName("requireDate")]
    public bool RequireDate { get; set; } = false;

    /// <summary>
    /// Show the query warning if no keyword is selected.
    /// </summary>
    [JsonPropertyName("requireKeyword")]
    public bool RequireKeyword { get; set; } = false;

    /// <summary>
    /// Determines if an unrestricted query warning is shown, and if so, if it cancels the query.
    /// </summary>
    [JsonPropertyName("warningType")]
    public QueryRestrictionsWarningType WarningType { get; set; } = QueryRestrictionsWarningType.NoWarning;
}

public partial class DocumentTypeKeywordTypeAssignmentCollection : HylandBase
{

    /// <summary>
    /// An array of document type keyword type assignments.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<DocumentTypeKeywordTypeAssignment> Items { get; set; }
}

/// <summary>
/// An assignment of a keyword type to a document type.
/// </summary>
public partial class DocumentTypeKeywordTypeAssignment : HylandBase
{
    /// <summary>
    /// Id of the keyword type.
    /// </summary>
    [JsonPropertyName("keywordTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string KeywordTypeId { get; set; }

    /// <summary>
    /// Id of the document type.  Must match the Id in the route.
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DocumentTypeId { get; set; }

    /// <summary>
    /// Id of the keyword type group this keyword is in.
    /// <br/>0 if not in a group.
    /// </summary>
    [JsonPropertyName("keywordTypeGroupId")]
    public string KeywordTypeGroupId { get; set; }

    /// <summary>
    /// Indicates a value is required for indexing new documents.
    /// </summary>
    [JsonPropertyName("required")]
    public bool Required { get; set; }

    /// <summary>
    /// Id of the assigned keyset.
    /// </summary>
    [JsonPropertyName("keywordSetNum")]
    public int KeywordSetNum { get; set; }

    /// <summary>
    /// The order in which the keyword type appears in dialog boxes.  If the keyword type is in a group, the sequence num should be the same
    /// <br/>for all the keyword types in that group (keyword group order is determined by the keyword group itself).
    /// </summary>
    [JsonPropertyName("sequenceNum")]
    public int SequenceNum { get; set; }

    /// <summary>
    /// Default value for the keyword.
    /// </summary>
    [JsonPropertyName("defaultKeywordValue")]
    public string DefaultKeywordValue { get; set; }

    /// <summary>
    /// Indicates the keyword is used to determine the uniqueness of new documents.
    /// </summary>
    [JsonPropertyName("makesDocUnique")]
    public bool MakesDocUnique { get; set; }

    /// <summary>
    /// External keyword type number.
    /// </summary>
    [JsonPropertyName("externalKeywordTypeNum")]
    public int ExternalKeywordTypeNum { get; set; }

    /// <summary>
    /// Indicates if the keyword type should be hidden (unless the user has the access restricted keywords privilege.)
    /// </summary>
    [JsonPropertyName("hidden")]
    public bool Hidden { get; set; }

    /// <summary>
    /// Indicated the keyword should be read-only (unless the user has the access restricted keywords privilege.)
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }

    /// <summary>
    /// Indicates if the keyword should be excluded from double blind indexing.
    /// </summary>
    [JsonPropertyName("excludeFromDoubleBlind")]
    public bool ExcludeFromDoubleBlind { get; set; }

    /// <summary>
    /// Indicates if the keyword is required for document retrieval queries.
    /// </summary>
    [JsonPropertyName("requiredForRetrieval")]
    public bool RequiredForRetrieval { get; set; }

    /// <summary>
    /// Indicates if the keyword ignores intelligent auto index.
    /// </summary>
    [JsonPropertyName("ignoreAutoIndex")]
    public bool IgnoreAutoIndex { get; set; }
}

/// <summary>
/// An array of user group, document type assignments.
/// </summary>    
public partial class UserGroupDocumentTypeAssignmentCollection : HylandBase
{
    /// <summary>
    /// An array of user group, document type assignments.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<UserGroupDocumentTypeAssignment> Items { get; set; }
}

/// <summary>
/// An assignment of a document type to a user group.
/// </summary>

public partial class UserGroupDocumentTypeAssignment : HylandBase
{
    /// <summary>
    /// Id of the user group.
    /// </summary>
    [JsonPropertyName("userGroupId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string UserGroupId { get; set; }

    /// <summary>
    /// Id of the document type.
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DocumentTypeId { get; set; }
}