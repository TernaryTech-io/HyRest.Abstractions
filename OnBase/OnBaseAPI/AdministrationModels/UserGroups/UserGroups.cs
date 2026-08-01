using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An array of user group identifiers.
/// </summary>
public partial class UserGroupCollectionModel : OnBaseItemTypeCollection<UserGroupModel>
{

}

/// <summary>
/// User Group data.
/// </summary>
public partial class UserGroupModel : OnBaseItemType
{
    /// <summary>
    /// Password policy number to override default value
    /// </summary>
    [JsonPropertyName("passwordPolicyNumberOverride")]
    public string PasswordPolicyNumberOverride { get; set; }
}


public partial class UserGroupPOST : UserGroupModel
{

    /// <summary>
    /// Indicates initial users for this User Group to have added to it
    /// </summary>
    [JsonPropertyName("userIds")]
    public ICollection<int> UserIds { get; set; }

}

/// <summary>
/// User Group privileges data.
/// </summary>    
public partial class UserGroupPrivilegesModel : HylandBase
{
    /// <summary>
    /// Documents related privileges.
    /// </summary>
    [JsonPropertyName("documents")]
    public DocumentSettings Documents { get; set; }

    /// <summary>
    /// Folders related privileges.
    /// </summary>
    [JsonPropertyName("folders")]
    public FolderSettings Folders { get; set; }

    /// <summary>
    /// Scan/Index batches related privileges.
    /// </summary>
    [JsonPropertyName("scanIndexBatches")]
    public ScanIndexBatchSettings ScanIndexBatches { get; set; }

    /// <summary>
    /// Client features related privileges.
    /// </summary>
    [JsonPropertyName("clientFeatures")]
    public ClientFeaturesModel ClientFeatures { get; set; }

    /// <summary>
    /// Client based product related privileges.
    /// </summary>
    [JsonPropertyName("clientBasedProducts")]
    public ClientBasedProducts ClientBasedProducts { get; set; }
}

/// <summary>
/// User Group configuration rights data.
/// </summary>
public partial class UserGroupConfigurationRightsModel : HylandBase
{

    /// <summary>
    /// General settings related rights.
    /// </summary>
    [JsonPropertyName("generalSettings")]
    public GeneralSettingsModel GeneralSettings { get; set; }

    /// <summary>
    /// Users/User Groups related rights.
    /// </summary>
    [JsonPropertyName("usersUserGroups")]
    public UsersUserGroupsModel UsersUserGroups { get; set; }

    /// <summary>
    /// Products related rights.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductsModel Products { get; set; }

}

/// <summary>
/// User Group product rights data.
/// </summary>
public partial class UserGroupProductRightsModel : HylandBase
{

    /// <summary>
    /// General configuration related rights.
    /// </summary>
    [JsonPropertyName("generalConfiguration")]
    public GeneralConfigurationModel GeneralConfiguration { get; set; } 

}
