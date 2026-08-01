using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Document Type Group data.
/// </summary>
public partial class DocumentTypeGroupModel : OnBaseItemType
{    
    /// <summary>
    /// Determines retrieval behavior for this document type group.
    /// </summary>
    [JsonPropertyName("documentSource")]
    public DocumentTypeGroupDocumentSource DocumentSource { get; set; } = DocumentTypeGroupDocumentSource.Normal;

    /// <summary>
    /// Indicates that the document type group is used in Medical Records Management.
    /// </summary>
    [JsonPropertyName("usedInMedicalRecords")]
    public bool UsedInMedicalRecords { get; set; }

    /// <summary>
    /// Used for connecting to an external source.
    /// </summary>
    [JsonPropertyName("connectionInfo")]
    public ConnectionInfoSettings ConnectionInfo { get; set; }
}


public partial class DocumentTypeGroupPOST : DocumentTypeGroupModel
{

    /// <summary>
    /// Indicates initial user groups for this Document Type Group to be added to
    /// </summary>
    [JsonPropertyName("userGroupIds")]
    public ICollection<int> UserGroupIds { get; set; }
}

/// <summary>
/// An array of user group, document type group assignments.
/// </summary>    
public partial class UserGroupDocumentTypeGroupAssignmentCollection : HylandBase
{
    /// <summary>
    /// An array of user group, document type group assignments.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<UserGroupDocumentTypeGroupAssignment> Items { get; set; }

}

/// <summary>
/// An assignment of a document type group to a user group.
/// </summary>

public partial class UserGroupDocumentTypeGroupAssignment : HylandBase
{
    /// <summary>
    /// Id of the user group.
    /// </summary>
    [JsonPropertyName("userGroupId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string UserGroupId { get; set; }

    /// <summary>
    /// Id of the document type group.
    /// </summary>
    [JsonPropertyName("documentTypeGroupId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DocumentTypeGroupId { get; set; }
}