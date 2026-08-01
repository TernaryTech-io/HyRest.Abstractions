using System.Text.Json.Serialization;

namespace HyRest.API.Models;


/// <summary>
/// Contains information about the system
/// </summary>    
public partial class SystemInformationModel : HylandBase
{
    /// <summary>
    /// The customer/install ID
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }
}

/// <summary>
/// System Setting data.
/// </summary>    
public partial class SystemSettingModel : HylandBase
{
    /// <summary>
    /// The name of the system setting. Only the following names can currently be added if they do not exist: AppServerPath, AppServerDataSource, ChangeControl_EvmUrl, OnBaseConfiguration_ConfigUrl
    /// </summary>
    [JsonPropertyName("name")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? Name { get; set; }

    /// <summary>
    /// The value of the system setting.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// An array of system settings information.
/// </summary>
public partial class SystemSettingCollectionModel : HylandBase
{
    /// <summary>
    /// An array of system setting information.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<SystemSettingModel> Items { get; set; } = [];
}

public partial class DocumentSettings : HylandBase
{

    [JsonPropertyName("retrieve")]
    public bool Retrieve { get; set; } = false;

    [JsonPropertyName("create")]
    public bool Create { get; set; } = false;

    [JsonPropertyName("modify")]
    public bool Modify { get; set; } = false;

    [JsonPropertyName("saveRotation")]
    public bool SaveRotation { get; set; } = false;

    [JsonPropertyName("delete")]
    public bool Delete { get; set; } = false;

    [JsonPropertyName("deleteUncommittedOnly")]
    public bool DeleteUncommittedOnly { get; set; } = false;

    [JsonPropertyName("print")]
    public bool Print { get; set; } = false;

    [JsonPropertyName("externalMail")]
    public bool ExternalMail { get; set; } = false;

    [JsonPropertyName("internalMail")]
    public bool InternalMail { get; set; } = false;

    [JsonPropertyName("reIndex")]
    public bool ReIndex { get; set; } = false;

    [JsonPropertyName("viewRevisions")]
    public bool ViewRevisions { get; set; } = false;

    [JsonPropertyName("createRevisions")]
    public bool CreateRevisions { get; set; } = false;

    [JsonPropertyName("viewVersions")]
    public bool ViewVersions { get; set; } = false;

    [JsonPropertyName("createVersions")]
    public bool CreateVersions { get; set; } = false;

    [JsonPropertyName("viewKeywords")]
    public bool ViewKeywords { get; set; } = false;

    [JsonPropertyName("modifyKeywords")]
    public bool ModifyKeywords { get; set; } = false;

    [JsonPropertyName("accessRestrictedKeywords")]
    public bool AccessRestrictedKeywords { get; set; } = false;

    [JsonPropertyName("viewHistory")]
    public bool ViewHistory { get; set; } = false;

    [JsonPropertyName("copyToClipboard")]
    public bool CopyToClipboard { get; set; } = false;

    [JsonPropertyName("separate")]
    public bool Separate { get; set; } = false;

    [JsonPropertyName("createIntegrationHyperlink")]
    public bool CreateIntegrationHyperlink { get; set; } = false;
}


public partial class FolderSettings : HylandBase
{

    [JsonPropertyName("retrieve")]
    public bool Retrieve { get; set; } = false;

    [JsonPropertyName("create")]
    public bool Create { get; set; } = false;

    [JsonPropertyName("modifyKeywords")]
    public bool ModifyKeywords { get; set; } = false;

    [JsonPropertyName("viewKeywords")]
    public bool ViewKeywords { get; set; } = false;

    [JsonPropertyName("modifyFolderContentsKeywords")]
    public bool ModifyFolderContentsKeywords { get; set; } = false;

    [JsonPropertyName("copy")]
    public bool Copy { get; set; } = false;

    [JsonPropertyName("move")]
    public bool Move { get; set; } = false;

    [JsonPropertyName("delete")]
    public bool Delete { get; set; } = false;

    [JsonPropertyName("addDocuments")]
    public bool AddDocuments { get; set; } = false;

    [JsonPropertyName("removeDocuments")]
    public bool RemoveDocuments { get; set; } = false;

    [JsonPropertyName("viewHistory")]
    public bool ViewHistory { get; set; } = false;
}

public partial class ScanIndexBatchSettings : HylandBase
{

    [JsonPropertyName("indexScannedDocuments")]
    public bool IndexScannedDocuments { get; set; } = false;

    [JsonPropertyName("restricted")]
    public bool Restricted { get; set; } = false;

    [JsonPropertyName("splitBatches")]
    public bool SplitBatches { get; set; } = false;

    [JsonPropertyName("commitScannedBatches")]
    public bool CommitScannedBatches { get; set; } = false;

    [JsonPropertyName("purgeScannedBatches")]
    public bool PurgeScannedBatches { get; set; } = false;

    [JsonPropertyName("purgeCommittedScannedBatches")]
    public bool PurgeCommittedScannedBatches { get; set; } = false;

    [JsonPropertyName("changeBatchScannedQueue")]
    public bool ChangeBatchScannedQueue { get; set; } = false;

    [JsonPropertyName("renameScanBatches")]
    public bool RenameScanBatches { get; set; } = false;  
}
public partial class ConnectionInfoSettings : HylandBase
{
    /// <summary>
    /// External source name.
    /// </summary>
    [JsonPropertyName("dataSourceName")]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? DataSourceName { get; set; }

    /// <summary>
    /// External system name.
    /// </summary>
    [JsonPropertyName("systemName")]
    [System.ComponentModel.DataAnnotations.StringLength(128)]
    public string? SystemName { get; set; }

    /// <summary>
    /// The disk group to use as a cache for items retrieved.
    /// </summary>
    [JsonPropertyName("diskGroupId")]
    public string? DiskGroupId { get; set; }

    /// <summary>
    /// Determines if the user credentials are used instead of the credentials in this document type group.
    /// </summary>
    [JsonPropertyName("useUserCredentials")]
    public bool UseUserCredentials { get; set; }

    /// <summary>
    /// Username to use for this document type group.
    /// </summary>
    [JsonPropertyName("userName")]
    [System.ComponentModel.DataAnnotations.StringLength(30)]
    public string? UserName { get; set; }
}

/// <summary>
/// User permission data.
/// </summary>

public partial class UserPermissions : HylandBase
{

    /// <summary>
    /// User product rights.
    /// </summary>
    [JsonPropertyName("productRights")]
    public ProductRightsModel ProductRights { get; set; } = new();

    /// <summary>
    /// User configuration rights.
    /// </summary>
    [JsonPropertyName("configurationRights")]
    public ConfigurationRightsModel ConfigurationRights { get; set; } = new();

    /// <summary>
    /// User and usergroup rights.
    /// </summary>
    [JsonPropertyName("userUserGroupsConfigRights")]
    public UserUserGroupsConfigRightsModel UserUserGroupsConfigRights { get; set; } = new();

    /// <summary>
    /// User product rights.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductsModel Products { get; set; } = new();
}

/// <summary>
/// A list of JSONPatch commands to execute.
/// </summary>    
public partial class PatchDocument : System.Collections.ObjectModel.Collection<PatchCommand>
{

}

/// <summary>
/// A JSONPatch command.
/// </summary>    
public partial class PatchCommand : HylandBase
{

    /// <summary>
    /// The operation to be performed.
    /// </summary>
    [JsonPropertyName("op")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public PatchCommandOp Op { get; set; }

    /// <summary>
    /// A JSON-Pointer to a property.
    /// </summary>
    [JsonPropertyName("path")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? Path { get; set; }

    /// <summary>
    /// The value to be used within the operation.
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    /// <summary>
    /// A JSON-Pointer to a property.
    /// </summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }    

}

