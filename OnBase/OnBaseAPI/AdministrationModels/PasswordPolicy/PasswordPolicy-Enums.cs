using System.Text.Json.Serialization;

namespace HyRest;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PasswordPolicyPolicyType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Standard")]
    Standard = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Legacy")]
    Legacy = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"PIN")]
    PIN = 2,

}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PasswordPolicyRuleRuleType
{

    [System.Runtime.Serialization.EnumMember(Value = @"NumberofUppercase")]
    NumberofUppercase = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"NumberOfLowercase")]
    NumberOfLowercase = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"NumberOfDigits")]
    NumberOfDigits = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"NumberOfSpecialCharacters")]
    NumberOfSpecialCharacters = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"CanNotContainUserName")]
    CanNotContainUserName = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"RotationAfterUse")]
    RotationAfterUse = 5,

    [System.Runtime.Serialization.EnumMember(Value = @"ReusePassword")]
    ReusePassword = 6,

    [System.Runtime.Serialization.EnumMember(Value = @"HoursBeforeReset")]
    HoursBeforeReset = 7,

    [System.Runtime.Serialization.EnumMember(Value = @"MaxRepeatingCharacters")]
    MaxRepeatingCharacters = 8,

    [System.Runtime.Serialization.EnumMember(Value = @"MaxLength")]
    MaxLength = 9,

    [System.Runtime.Serialization.EnumMember(Value = @"MinLength")]
    MinLength = 10,

    [System.Runtime.Serialization.EnumMember(Value = @"ExpiredAfterDays")]
    ExpiredAfterDays = 11,

    [System.Runtime.Serialization.EnumMember(Value = @"AlphanumericOnly")]
    AlphanumericOnly = 12,

    [System.Runtime.Serialization.EnumMember(Value = @"NoRotation")]
    NoRotation = 13,

    [System.Runtime.Serialization.EnumMember(Value = @"ExpiredAfterFirstUse")]
    ExpiredAfterFirstUse = 14,

    [System.Runtime.Serialization.EnumMember(Value = @"MinimumQuotaRules")]
    MinimumQuotaRules = 15,

    [System.Runtime.Serialization.EnumMember(Value = @"FailLoginLockout")]
    FailLoginLockout = 16,

    [System.Runtime.Serialization.EnumMember(Value = @"AutoReleaseFailedLockout")]
    AutoReleaseFailedLockout = 17,

    [System.Runtime.Serialization.EnumMember(Value = @"ManualReleaseFailedLockout")]
    ManualReleaseFailedLockout = 18,

    [System.Runtime.Serialization.EnumMember(Value = @"NumberOfAlphabetic")]
    NumberOfAlphabetic = 19,

    [System.Runtime.Serialization.EnumMember(Value = @"LockoutIdle")]
    LockoutIdle = 20,

    [System.Runtime.Serialization.EnumMember(Value = @"MaxRepeatingSubstring")]
    MaxRepeatingSubstring = 21,

}