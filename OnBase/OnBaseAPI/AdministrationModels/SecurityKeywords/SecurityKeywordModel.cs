using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HyRest.API.Models;

/// <summary>
/// Security Keyword data
/// </summary>    
public partial class SecurityKeywordBaseModel : HylandBase
{

    /// <summary>
    /// Specifies if the SecurityKeyword is Static or Username
    /// </summary>
    [JsonPropertyName("isUserName")]
    public bool IsUserName { get; set; }

    /// <summary>
    /// The keyword of this security keyword
    /// </summary>
    [JsonPropertyName("keyword")]
    public KeywordModel Keyword { get; set; }

    /// <summary>
    /// The Security Keyword Operator, defined as either Equal or NotEqual
    /// </summary>
    [JsonPropertyName("securityKeywordOperator")]
    public SecurityKeywordBaseModelSecurityKeywordOperator SecurityKeywordOperator { get; set; }

    /// <summary>
    /// The Security Keyword Type, defined as either Retrieval or Indexing
    /// </summary>
    [JsonPropertyName("securityKeywordType")]
    public SecurityKeywordBaseModelSecurityKeywordType SecurityKeywordType { get; set; }
}


public partial class UserSecurityKeywordModel : SecurityKeywordBaseModel
{
    /// <summary>
    /// The unique identifier for the user.
    /// </summary>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }
}


public partial class UserGroupSecurityKeywordModel : SecurityKeywordBaseModel
{
    /// <summary>
    /// The unique identifier for the user group.
    /// </summary>
    [JsonPropertyName("userGroupId")]
    public string UserGroupId { get; set; }
}

/// <summary>
/// List of Security Keywords for the user
/// </summary>

public partial class UserSecurityKeywordCollection : HylandBase
{
    /// <summary>
    /// An array of security keywords
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<UserSecurityKeywordModel> Items { get; set; }
}

/// <summary>
/// List of Security Keywords for the user group
/// </summary>

public partial class UserGroupSecurityKeywordCollection : HylandBase
{

    /// <summary>
    /// An array of security keywords
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<UserGroupSecurityKeywordModel> Items { get; set; }
}