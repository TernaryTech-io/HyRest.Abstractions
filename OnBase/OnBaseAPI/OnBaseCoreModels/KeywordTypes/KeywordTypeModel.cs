using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An array of keyword types.
/// </summary>    
public partial class KeywordTypeCollectionModel : OnBaseItemTypeCollection<KeywordTypeModel>
{

}

/// <summary>
/// Keyword type metadata.
/// </summary>    
public partial class KeywordTypeModel : OnBaseItemType
{       
    /// <summary>
    /// Describes the type of data represented by the keyword type.
    /// <br/>
    /// <br/>`Numeric9` represents a number up to 9 digits in length.
    /// <br/>
    /// <br/>`Numeric20` represents a number up to 20 digits in length.
    /// <br/>
    /// <br/>`Alphanumeric` represents any value with letters and/or numbers.
    /// <br/>
    /// <br/>`Currency` represents a monetary value. The currency format used is
    /// <br/>'built-in' to the keyword type.
    /// <br/>
    /// <br/>`SpecificCurrency` represents a monetary value and allows multiple
    /// <br/> currency formats to be used with the same keyword type.
    /// <br/>
    /// <br/>`Date` represents a date.
    /// <br/>
    /// <br/>`DateTime` represents both a date and a time.
    /// <br/>
    /// <br/>`FloatingPoint` represents numeric values that have variable decimal
    /// <br/> point locations.
    /// </summary>
    [JsonPropertyName("dataType")]
    public KeywordTypeDataType DataType { get; set; }

    /// <summary>
    /// Classification to determine if the keyword type is used for document retrieval.
    /// </summary>
    [JsonPropertyName("usedForRetrieval")]
    public bool UsedForRetrieval { get; set; }

    /// <summary>
    /// Indicates if the keyword type should be made invisible in UI contexts.
    /// </summary>
    [JsonPropertyName("invisible")]
    public bool Invisible { get; set; }

    [JsonPropertyName("alphanumericSettings")]
    public AlphanumericSettings? AlphanumericSettings { get; set; }

    /// <summary>
    /// The Currency Format Id if the Keyword Type's data type is Currency.  If Specific Currency, this
    /// <br/>will be the default currency format id set on the Specific Currency Keyword Type. When Regional Workstation
    /// <br/>Settings is used an id of 'default' is used.
    /// </summary>
    [JsonPropertyName("currencyFormatId")]
    public string? CurrencyFormatId { get; set; }

    /// <summary>
    /// A value indicating whether the keyword type is configured for security masking.
    /// <br/>When the value is true and the keyword values have not been unmasked,
    /// <br/>the corresponding keyword value should be treated as readonly.
    /// </summary>
    [JsonPropertyName("isSecurityMasked")]
    public bool IsSecurityMasked { get; set; }

    [JsonPropertyName("maskSettings")]
    public KeywordTypeMaskSettings? MaskSettings { get; set; }
    
}
/// <summary>
/// Masking settings for a particular keyword type.
/// </summary>
public partial class KeywordTypeMaskSettings : HylandBase
{
    /// <summary>
    /// A value indicating whether the keyword type required the entire field filled out.
    /// </summary>
    [JsonPropertyName("fullFieldRequired")]
    public bool FullFieldRequired { get; set; }

    /// <summary>
    /// A value that specifies the mask string for a masked keyword type.
    /// </summary>
    [JsonPropertyName("maskString")]
    public string MaskString { get; set; }

    /// <summary>
    /// The configured static characters for the keyword mask.
    /// </summary>
    [JsonPropertyName("staticCharacters")]
    public string StaticCharacters { get; set; }

    /// <summary>
    /// A value indicating whether the mask should be stored to the database or stripped.
    /// </summary>
    [JsonPropertyName("storeMask")]
    public bool StoreMask { get; set; }
}
/// <summary>
/// Configuration settings for alphanumeric keyword types.
/// </summary>
public partial class AlphanumericSettings : HylandBase
{
    /// <summary>
    /// The character case option for keyword values of this keyword type.
    /// <br/>
    /// <br/>`Uppercase` keyword values are stored using only uppercase characters.
    /// <br/>
    /// <br/>`MixedCase` keyword values are stored using upper and lower case characters.
    /// </summary>
    [JsonPropertyName("caseOptions")]
    public AlphanumericCaseOptions CaseOptions { get; set; }

    /// <summary>
    /// The maximum number of characters allowed by the keyword type.
    /// </summary>
    [JsonPropertyName("maximumLength")]
    public long MaximumLength { get; set; }

    /// <summary>
    /// The database storage method used for keyword values of this keyword type.
    /// <br/>
    /// <br/>`SingleTable` indicates keyword values are stored in a single database table.
    /// <br/>
    /// <br/>`DualTable` indicates keyword values are stored in two database tables.
    /// </summary>
    [JsonPropertyName("storageOptions")]
    public KeywordTypeStorage StorageOptions { get; set; } 
}