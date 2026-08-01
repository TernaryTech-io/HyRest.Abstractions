using System.Text.Json.Serialization;

namespace HyRest;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentTypeAutoDisplayKeywordLocation
{

    [System.Runtime.Serialization.EnumMember(Value = @"UpperRight")]
    UpperRight = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"UpperLeft")]
    UpperLeft = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"BottomRight")]
    BottomRight = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"BottomLeft")]
    BottomLeft = 3,

}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentTypeRetrievalListSortOrder
{

    [System.Runtime.Serialization.EnumMember(Value = @"None")]
    None = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"DateDescending")]
    DateDescending = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"DateAscending")]
    DateAscending = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"HandleDescending")]
    HandleDescending = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"HandleAscending")]
    HandleAscending = 4,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum QueryRestrictionsWarningType
{

    [System.Runtime.Serialization.EnumMember(Value = @"NoWarning")]
    NoWarning = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"WarnAndRun")]
    WarnAndRun = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"WarnAndCancel")]
    WarnAndCancel = 2,

}