using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An array of user identifiers.
/// </summary>
public partial class UserCollectionModel : OnBaseItemCollection<UserModel>
{

}

/// <summary>
/// User data.
/// </summary>
public partial class UserModel : OnBaseItem
{
    /// <summary>
    /// The real name of the user.
    /// </summary>
    [JsonPropertyName("name")]
    [System.ComponentModel.DataAnnotations.StringLength(75)]
    public string Name { get; set; } = "";

    /// <summary>
    /// The real name of the user.
    /// </summary>
    [JsonPropertyName("realName")]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string RealName { get; set; } = "";

    /// <summary>
    /// The email address of the user.
    /// </summary>
    [JsonPropertyName("emailAddress")]
    [System.ComponentModel.DataAnnotations.StringLength(255)]
    public string EmailAddress { get; set; } = "";

    /// <summary>
    /// User password. The password must meet the requirements of the current password policy.
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// Force the user to update their password the next time they login.
    /// </summary>
    [JsonPropertyName("forcePasswordChangeOnNextLogin")]
    public bool ForcePasswordChangeOnNextLogin { get; set; } = false;

    /// <summary>
    /// Lock this user, disabling their ability to log in.
    /// </summary>
    [JsonPropertyName("locked")]
    public bool Locked { get; set; } = false;

    /// <summary>
    /// Disable the changing of this users password.
    /// </summary>
    [JsonPropertyName("disableChangePassword")]
    public bool DisableChangePassword { get; set; } = false;

    /// <summary>
    /// Grants this user the ability to see most user groups, regardless of membership.
    /// </summary>
    [JsonPropertyName("userGroupAdministrator")]
    public bool UserGroupAdministrator { get; set; } = false;

    /// <summary>
    /// When enabled, the user account will expire on the date set in accountExpirationDate.
    /// </summary>
    [JsonPropertyName("accountExpires")]
    public bool AccountExpires { get; set; } = false;

    /// <summary>
    /// When accountExpires is true, the account will expire on the date set here.
    /// </summary>
    [JsonPropertyName("accountExpirationDate")]
    public string AccountExpirationDate { get; set; } = "1964-01-01";

    /// <summary>
    /// Indicates user has been deactivated and can no longer be used.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public bool Deactivated { get; set; } = false;

    /// <summary>
    /// Indicates this user is used for running services and applications.
    /// </summary>
    [JsonPropertyName("isServiceAccount")]
    public bool IsServiceAccount { get; set; } = false;

    /// <summary>
    /// Indicates the user is authenticated via an external service.
    /// </summary>
    [JsonPropertyName("externallyAuthenticated")]
    public bool ExternallyAuthenticated { get; set; } = false;

    /// <summary>
    /// Sets the QA trust level for this user. Used in Workflow
    /// </summary>
    [JsonPropertyName("qaTrustLevel")]
    public string QaTrustLevel { get; set; } = "-1";
}

/// <summary>
/// User data.
/// </summary>
public partial class UserPOSTModel : UserModel
{
    /// <summary>
    /// Indicates initial user groups for this user to be added to
    /// </summary>
    [JsonPropertyName("userGroupIds")]
    public ICollection<int> UserGroupIds { get; set; }
}

/// <summary>
/// An array of user group user assignments.
/// </summary>
public partial class UserGroupUserAssignmentCollectionModel : HylandBase
{
    /// <summary>
    /// An array of user group user assignments.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<UserGroupUserAssignmentModel> Items { get; set; }
}

/// <summary>
/// An assignment of a user to a user group.
/// </summary>    
public partial class UserGroupUserAssignmentModel : HylandBase
{
    /// <summary>
    /// Id of the user group. Must match the Id in the route.
    /// </summary>
    [JsonPropertyName("userGroupId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string UserGroupId { get; set; }

    /// <summary>
    /// Id of the user.
    /// </summary>
    [JsonPropertyName("userId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string UserId { get; set; }
}

public partial class UsersUserGroupsModel : HylandBase
{
    [JsonPropertyName("userGroupSecurity")]
    public bool UserGroupSecurity { get; set; } = false;

    [JsonPropertyName("configRightSecurity")]
    public bool ConfigRightSecurity { get; set; } = false;
    /// <summary>
    /// User Configuration Admin.
    /// </summary>
    [JsonPropertyName("userConfiguration")]
    public UsersUserGroupsUserConfiguration UserConfiguration { get; set; }

    [JsonPropertyName("limitAdminAccess")]
    public bool LimitAdminAccess { get; set; } = false;
}

/// <summary>
/// User password.
/// </summary>    
public partial class UserPasswordModel : HylandBase
{

    /// <summary>
    /// The password for the user.
    /// </summary>
    [JsonPropertyName("password")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Password { get; set; }

    /// <summary>
    /// Force the user to update their password the next time they login.
    /// </summary>
    [JsonPropertyName("forcePasswordChangeOnNextLogin")]
    public bool ForcePasswordChangeOnNextLogin { get; set; } = false;
}