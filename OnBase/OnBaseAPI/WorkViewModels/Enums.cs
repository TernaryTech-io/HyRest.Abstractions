using System.Text.Json.Serialization;

namespace HyRest;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HorizontalAlignment
{

    [System.Runtime.Serialization.EnumMember(Value = @"Left")]
    Left = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Right")]
    Right = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Center")]
    Center = 2,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DataSetOptions
{

    [System.Runtime.Serialization.EnumMember(Value = @"None")]
    None = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"DataSet")]
    DataSet = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"SearchAllClassResults")]
    SearchAllClassResults = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"SearchFilterResultsOnly")]
    SearchFilterResultsOnly = 3,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DataSetType
{

    [System.Runtime.Serialization.EnumMember(Value = @"DataSet")]
    DataSet = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"FilterBacked")]
    FilterBacked = 1,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Connector
{

    [System.Runtime.Serialization.EnumMember(Value = @"And")]
    And = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Or")]
    Or = 1,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ObjectMaintenanceReturnCode
{

    [System.Runtime.Serialization.EnumMember(Value = @"Success")]
    Success = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"SuccessButDeleteDependentFailed")]
    SuccessButDeleteDependentFailed = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"InsufficientRights")]
    InsufficientRights = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"StoreAttributeError")]
    StoreAttributeError = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"DuplicateUniqueAttribute")]
    DuplicateUniqueAttribute = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"ScriptCancelled")]
    ScriptCancelled = 5,

    [System.Runtime.Serialization.EnumMember(Value = @"EventCancelled")]
    EventCancelled = 6,

    [System.Runtime.Serialization.EnumMember(Value = @"InvalidType")]
    InvalidType = 7,

    [System.Runtime.Serialization.EnumMember(Value = @"MismatchedInstitution")]
    MismatchedInstitution = 8,

    [System.Runtime.Serialization.EnumMember(Value = @"AggregateError")]
    AggregateError = 9,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ObjectType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Application")]
    Application = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Filter")]
    Filter = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"FilterBar")]
    FilterBar = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"FilterBarItem")]
    FilterBarItem = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"UserUISettings")]
    UserUISettings = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"SystemProperties")]
    SystemProperties = 5,

}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Operator
{

    [System.Runtime.Serialization.EnumMember(Value = @"Equal")]
    Equal = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"LessThan")]
    LessThan = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"GreaterThan")]
    GreaterThan = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"LessThanEqual")]
    LessThanEqual = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"GreaterThanEqual")]
    GreaterThanEqual = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"NotEqual")]
    NotEqual = 5,

    [System.Runtime.Serialization.EnumMember(Value = @"Like")]
    Like = 6,

    [System.Runtime.Serialization.EnumMember(Value = @"NotLike")]
    NotLike = 7,

    [System.Runtime.Serialization.EnumMember(Value = @"Null")]
    Null = 8,

    [System.Runtime.Serialization.EnumMember(Value = @"NotNull")]
    NotNull = 9,

    [System.Runtime.Serialization.EnumMember(Value = @"In")]
    In = 10,

    [System.Runtime.Serialization.EnumMember(Value = @"NotIn")]
    NotIn = 11,
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SortOrder
{

    [System.Runtime.Serialization.EnumMember(Value = @"ASC")]
    ASC = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"DESC")]
    DESC = 1,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ConstraintModelLeftParenthesisCount
{

    [System.Runtime.Serialization.EnumMember(Value = @"0")]
    _0 = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"1")]
    _1 = 1,

}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ConstraintModelRightParenthesisCount
{

    [System.Runtime.Serialization.EnumMember(Value = @"0")]
    _0 = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"1")]
    _1 = 1,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FilterUserOverrideModelHorizontalAlignment
{

    [System.Runtime.Serialization.EnumMember(Value = @"left")]
    Left = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"right")]
    Right = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"center")]
    Center = 2,

}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FilterUserOverrideModelSortDirection
{

    [System.Runtime.Serialization.EnumMember(Value = @"ascending")]
    Ascending = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"descending")]
    Descending = 1,

}