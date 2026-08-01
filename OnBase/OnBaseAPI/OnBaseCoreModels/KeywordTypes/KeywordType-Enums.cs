using System.Text.Json.Serialization;

namespace HyRest;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum KeywordTypeDataType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Numeric9")]
    Numeric9 = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Numeric20")]
    Numeric20 = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Alphanumeric")]
    Alphanumeric = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"Currency")]
    Currency = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"SpecificCurrency")]
    SpecificCurrency = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"Date")]
    Date = 5,

    [System.Runtime.Serialization.EnumMember(Value = @"DateTime")]
    DateTime = 6,

    [System.Runtime.Serialization.EnumMember(Value = @"FloatingPoint")]
    FloatingPoint = 7,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum KeywordTypeCasing
{

    [System.Runtime.Serialization.EnumMember(Value = @"Upper")]
    Upper = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Mixed")]
    Mixed = 1,

}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlphanumericCaseOptions
{

    [System.Runtime.Serialization.EnumMember(Value = @"Uppercase")]
    Uppercase = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"MixedCase")]
    MixedCase = 1,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum KeywordTypeStorage
{

    [System.Runtime.Serialization.EnumMember(Value = @"SingleTable")]
    SingleTable = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"DualTable")]
    DualTable = 1,
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum KeywordTypeUsageRestrictions
{

    [System.Runtime.Serialization.EnumMember(Value = @"None")]
    None = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Unique")]
    Unique = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Exist")]
    Exist = 2,
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum KeywordTypeDatasetSorting
{

    [System.Runtime.Serialization.EnumMember(Value = @"Ascending")]
    Ascending = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Descending")]
    Descending = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Custom")]
    Custom = 2,

}