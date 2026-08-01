using System.Text.Json.Serialization;

namespace HyRest;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Context
{

    [System.Runtime.Serialization.EnumMember(Value = @"View")]
    View = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Download")]
    Download = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"EmailAttachment")]
    EmailAttachment = 2,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Fit
{

    [System.Runtime.Serialization.EnumMember(Value = @"Both")]
    Both = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Height")]
    Height = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Stretch")]
    Stretch = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"Width")]
    Width = 3,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum QueryType
{

    [System.Runtime.Serialization.EnumMember(Value = @"CustomQuery")]
    CustomQuery = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentType")]
    DocumentType = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentTypeGroup")]
    DocumentTypeGroup = 2,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum QueryKeywordOperator
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

    [System.Runtime.Serialization.EnumMember(Value = @"Literal")]
    Literal = 6,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum QueryKeywordRelation
{

    [System.Runtime.Serialization.EnumMember(Value = @"And")]
    And = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Or")]
    Or = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"To")]
    To = 2,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserDefinedDisplayColumnType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Keyword")]
    Keyword = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentId")]
    DocumentId = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentName")]
    DocumentName = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentDate")]
    DocumentDate = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"ArchivalDate")]
    ArchivalDate = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"AuthorId")]
    AuthorId = 5,

    [System.Runtime.Serialization.EnumMember(Value = @"Batch")]
    Batch = 6,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentTypeGroup")]
    DocumentTypeGroup = 7,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentTypeName")]
    DocumentTypeName = 8,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CustomQueryQueryType
{

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentType")]
    DocumentType = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"DocumentTypeGroup")]
    DocumentTypeGroup = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Keyword")]
    Keyword = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"SQL")]
    SQL = 3,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CustomQueryDateSearchOptions
{

    [System.Runtime.Serialization.EnumMember(Value = @"NoDate")]
    NoDate = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"SingleDate")]
    SingleDate = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"DateRange")]
    DateRange = 2,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DisplayColumnConfigurationType
{

    [System.Runtime.Serialization.EnumMember(Value = @"Keyword")]
    Keyword = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Attribute")]
    Attribute = 1,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DisplayColumnConfigurationDataType
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
public enum DocumentStatus
{

    [System.Runtime.Serialization.EnumMember(Value = @"Active")]
    Active = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Deleted")]
    Deleted = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Inactive")]
    Inactive = 2,

}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CapturePropertiesReviewStatus
{

    [System.Runtime.Serialization.EnumMember(Value = @"NeedsAttention")]
    NeedsAttention = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"NeedsRescan")]
    NeedsRescan = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"NeedsManagerAttention")]
    NeedsManagerAttention = 2,

}



[JsonConverter(typeof(JsonStringEnumConverter))]
public enum KeywordTypeGroupStorageType
{

    [System.Runtime.Serialization.EnumMember(Value = @"SingleInstance")]
    SingleInstance = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"MultiInstance")]
    MultiInstance = 1
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NoteTypeModelFlavor
{

    [System.Runtime.Serialization.EnumMember(Value = @"Note")]
    Note = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Highlight")]
    Highlight = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Arrow")]
    Arrow = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"Ellipse")]
    Ellipse = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"OverlappedText")]
    OverlappedText = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"IconStamp")]
    IconStamp = 5,

    [System.Runtime.Serialization.EnumMember(Value = @"Staple")]
    Staple = 6,
    [System.Runtime.Serialization.EnumMember(Value = @"BackStaple")]
    BackStaple = 7,

}