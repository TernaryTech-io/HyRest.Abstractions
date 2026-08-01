using System.Text.Json.Serialization;


namespace HyRest.API.Models;

/// <summary>
/// An array of password policy identifiers.
/// </summary>    
public partial class PasswordPolicyCollectionModel : OnBaseItemTypeCollection<PasswordPolicyModel>
{

}

/// <summary>
/// Password policy data.
/// </summary>

public partial class PasswordPolicyModel : OnBaseItemType
{
    /// <summary>
    /// The description of the password policy.
    /// </summary>
    [JsonPropertyName("description")]
    [System.ComponentModel.DataAnnotations.StringLength(200)]
    public string Description { get; set; }

    /// <summary>
    /// The type of the password policy.
    /// </summary>
    [JsonPropertyName("policyType")]
    public PasswordPolicyPolicyType PolicyType { get; set; } = PasswordPolicyPolicyType.Standard;

    /// <summary>
    /// The sequence number of the password policy.
    /// </summary>
    [JsonPropertyName("sequenceNumber")]
    public double SequenceNumber { get; set; }

    /// <summary>
    /// Indicates the password policy is locked.
    /// </summary>
    [JsonPropertyName("isLocked")]
    public bool IsLocked { get; set; } = false;

    /// <summary>
    /// An array of password policy rules.
    /// </summary>
    [JsonPropertyName("policyRules")]
    public ICollection<PasswordPolicyRule> PolicyRules { get; set; }

    /// <summary>
    /// The indicator if the password policy is system default.
    /// </summary>
    [JsonPropertyName("defaultPasswordPolicy")]
    public bool DefaultPasswordPolicy { get; set; }
}

/// <summary>
/// Password policy rule.
/// </summary>
public partial class PasswordPolicyRule : HylandBase
{
    /// <summary>
    /// The name of the password policy.
    /// </summary>
    [JsonPropertyName("ruleType")]
    public PasswordPolicyRuleRuleType RuleType { get; set; }

    /// <summary>
    /// The value pairs with the password policy rule.
    /// </summary>
    [JsonPropertyName("ruleValue")]
    public string RuleValue { get; set; }
}
