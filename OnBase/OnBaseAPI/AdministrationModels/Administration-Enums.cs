using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HyRest;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SecurityKeywordBaseModelSecurityKeywordOperator
{

    [System.Runtime.Serialization.EnumMember(Value = @"Equal")]
    Equal = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"NotEqual")]
    NotEqual = 1,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SecurityKeywordBaseModelSecurityKeywordType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Retrieval")]
    Retrieval = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Indexing")]
    Indexing = 1,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum GeneralSettingsCustomQueryConfiguration
{

    [System.Runtime.Serialization.EnumMember(Value = @"None")]
    None = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"AnyCustomQueryType")]
    AnyCustomQueryType = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"OnlyTypesWithUserGroupSecurity")]
    OnlyTypesWithUserGroupSecurity = 2,

}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UsersUserGroupsUserConfiguration
{

    [System.Runtime.Serialization.EnumMember(Value = @"None")]
    None = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"User Account Admin")]
    User_Account_Admin = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"User Update Admin")]
    User_Update_Admin = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"Password Admin")]
    Password_Admin = 3,

}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ProductsWorkflowConfiguration
{

    [System.Runtime.Serialization.EnumMember(Value = @"None")]
    None = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"All Life Cycles")]
    All_Life_Cycles = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Assigned Life Cycles")]
    Assigned_Life_Cycles = 2,

}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ConfigurationRightsCustomQueryConfiguration
{

    [System.Runtime.Serialization.EnumMember(Value = @"None")]
    None = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"AnyCustomQueryType")]
    AnyCustomQueryType = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"OnlyTypesWithUserGroupSecurity")]
    OnlyTypesWithUserGroupSecurity = 2,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PatchCommandOp
{

    [System.Runtime.Serialization.EnumMember(Value = @"add")]
    Add = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"remove")]
    Remove = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"replace")]
    Replace = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"move")]
    Move = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"copy")]
    Copy = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"test")]
    Test = 5,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChangeType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Create")]
    Create = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Update")]
    Update = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Delete")]
    Delete = 2,

}