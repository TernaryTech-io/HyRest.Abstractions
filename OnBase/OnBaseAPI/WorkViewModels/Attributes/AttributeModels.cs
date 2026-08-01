using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// A collection of Attributes.
/// </summary>
public partial class AttributeCollectionModel : OnBaseItemTypeCollection<AttributeModel>
{
        
}

/// <summary>
/// Information about an Attribute.
/// </summary>
public partial class AttributeModel : OnBaseItemType
{

    [JsonPropertyName("dataType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public AttributeTypeDataType DataType { get; set; }

    /// <summary>
    /// If this property is included and the value is anything
    /// <br/>other than 0; the Attribute has a Data Set.
    /// </summary>
    [JsonPropertyName("dataSetId")]
    public string? DataSetId { get; set; }

    /// <summary>
    /// The ClassId that this Attribute comes from.
    /// </summary>
    [JsonPropertyName("classId")]
    //[Required(AllowEmptyStrings = true)]
    public string? ClassId { get; set; }

    /// <summary>
    /// This property will only be populated if the datatype is a Relation.
    /// <br/>If this property is included and the value is anything other than 0;
    /// <br/>the value is the classId that this relationship Attribute links to.
    /// </summary>
    [JsonPropertyName("relatedClassId")]
    public string? RelatedClassId { get; set; }

    /// <summary>
    /// Will be true if the Attribute is not through a relationship, on an external class that allows edits, not the target of a Class Trigger, and not a calculated Attribute.
    /// </summary>
    [JsonPropertyName("isMutable")]
    public bool? IsMutable { get; set; }

}

/// <summary>
/// A collection of View Attributes.
/// </summary>

public partial class ViewAttributeCollectionModel : Collection<ViewAttributeModel>
{

}

/// <summary>
/// Information about a View Attribute for a Filter.
/// </summary>

public partial class ViewAttributeModel : HylandBase
{
    /// <summary>
    /// Name used to describe this view Attribute.
    /// </summary>
    [JsonPropertyName("heading")]
    [Required(AllowEmptyStrings = true)]
    public string Heading { get; set; }

    /// <summary>
    /// Path to the Attribute shown in this View Attribute.
    /// </summary>
    [JsonPropertyName("dataAddress")]
    [Required(AllowEmptyStrings = true)]
    public string DataAddress { get; set; }

    [JsonPropertyName("dataType")]
    public AttributeTypeDataType DataType { get; set; }

    /// <summary>
    /// Desired width of this column for grid displays.
    /// </summary>
    [JsonPropertyName("width")]
    public string Width { get; set; }

    [JsonPropertyName("horizontalAlignment")]
    public HorizontalAlignment HorizontalAlignment { get; set; }
}


[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AttributeTypeDataType
{

    [System.Runtime.Serialization.EnumMember(Value = @"LargeInt")]
    LargeInt = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"Currency")]
    Currency = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"Float")]
    Float = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"Date")]
    Date = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"DateTime")]
    DateTime = 4,

    [System.Runtime.Serialization.EnumMember(Value = @"Char")]
    Char = 5,

    [System.Runtime.Serialization.EnumMember(Value = @"Text")]
    Text = 6,

    [System.Runtime.Serialization.EnumMember(Value = @"Relation")]
    Relation = 7,

    [System.Runtime.Serialization.EnumMember(Value = @"Boolean")]
    Boolean = 8,

    [System.Runtime.Serialization.EnumMember(Value = @"Document")]
    Document = 9,

    [System.Runtime.Serialization.EnumMember(Value = @"FormattedText")]
    FormattedText = 10,

    [System.Runtime.Serialization.EnumMember(Value = @"Decimal")]
    Decimal = 11,

    [System.Runtime.Serialization.EnumMember(Value = @"EncryptedAlphanumeric")]
    EncryptedAlphanumeric = 12,

}