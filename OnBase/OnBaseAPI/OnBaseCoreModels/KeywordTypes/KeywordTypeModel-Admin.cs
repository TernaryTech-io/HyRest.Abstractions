using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Keyword Type data.
/// </summary>
public partial class KeywordTypeModel : OnBaseItemType
{
    /// <summary>
    /// Determines the casing of the keyword.  Options are 'Upper' to indicate uppercase and 'Mixed' to indicate mixed-case
    /// </summary>
    [JsonPropertyName("casing")]
    public KeywordTypeCasing Casing { get; set; } = KeywordTypeCasing.Mixed;

    /// <summary>
    /// For Keyword Types that are Alphanumeric, this value indicates the maximum length of the string data that can be stored. When setting this value, it must be greater than 0. This value must be 0 for non-Alphanumeric data types.
    /// </summary>
    [JsonPropertyName("maxLength")]
    public int MaxLength { get; set; } = 0;

    /// <summary>
    /// Indicates how the keyword is stored. Note - The DualTable option is only valid for alphanumeric keywords.
    /// </summary>
    [JsonPropertyName("storage")]
    public KeywordTypeStorage Storage { get; set; } = KeywordTypeStorage.SingleTable;

    /// <summary>
    /// Dataset enabled for keyword
    /// </summary>
    [JsonPropertyName("datasetEnabled")]
    public bool DatasetEnabled { get; set; } = false;

    /// <summary>
    /// Dropdown list indication for keyword
    /// </summary>
    [JsonPropertyName("datasetDropDownList")]
    public bool DatasetDropDownList { get; set; } = false;

    /// <summary>
    /// Only display distinct value for keyword
    /// </summary>
    [JsonPropertyName("displayDistinctValue")]
    public bool DisplayDistinctValue { get; set; } = false;

    /// <summary>
    /// Restrictions on how the keywords of this type can be set.
    /// </summary>
    [JsonPropertyName("usageRestrictions")]
    public KeywordTypeUsageRestrictions UsageRestrictions { get; set; } = KeywordTypeUsageRestrictions.None;

    /// <summary>
    /// The Autofill Keyword Set associated with this Keyword Type
    /// </summary>
    [JsonPropertyName("autofillKeywordSetId")]
    public string AutofillKeywordSetId { get; set; } = "0";

    /// <summary>
    /// The sorting method for dataset values, if enabled
    /// </summary>
    [JsonPropertyName("datasetSorting")]
    public KeywordTypeDatasetSorting DatasetSorting { get; set; } = KeywordTypeDatasetSorting.Ascending;

    /// <summary>
    /// Advanced Keyword Type Options
    /// </summary>
    [JsonPropertyName("advanced")]
    public Advanced Advanced { get; set; }

    /// <summary>
    /// Keyword Type Classification Options
    /// </summary>
    [JsonPropertyName("classification")]
    public Classification Classification { get; set; }

    /// <summary>
    /// Keyword Type Display Options
    /// </summary>
    [JsonPropertyName("display")]
    public Display Display { get; set; }
}

public partial class Advanced : HylandBase
{

    /// <summary>
    /// Legacy Setting. Indicates if this keyword type is externally validated.
    /// </summary>
    [JsonPropertyName("externalValidation")]
    public bool ExternalValidation { get; set; } = false;
}


public partial class Classification : HylandBase
{
    /// <summary>
    /// Legacy setting. Indicates if this keyword type is an autofill keyword for an autofill keyword set.
    /// </summary>
    [JsonPropertyName("autoFillKeyword")]
    public bool AutoFillKeyword { get; set; } = false;

    /// <summary>
    /// Indicates if this keyword type is informative only (no index).
    /// </summary>
    [JsonPropertyName("informationOnly")]
    public bool InformationOnly { get; set; } = false;

    /// <summary>
    /// Indicates if this keyword type is not for retrieval.
    /// </summary>
    [JsonPropertyName("notForRetrieval")]
    public bool NotForRetrieval { get; set; } = false;

    /// <summary>
    /// Indicates if this keyword type processes the document's file name when imported.
    /// </summary>
    [JsonPropertyName("processingFileNameKeyword")]
    public bool ProcessingFileNameKeyword { get; set; } = false;
}


public partial class Display : HylandBase
{

    /// <summary>
    /// Indicates if this keyword type automatically displays.
    /// </summary>
    [JsonPropertyName("autoDisplay")]
    public bool AutoDisplay { get; set; } = false;

    /// <summary>
    /// Indicates if this keyword type forces a left-to-right reading order.
    /// </summary>
    [JsonPropertyName("forceLeftToRightReadingOrder")]
    public bool ForceLeftToRightReadingOrder { get; set; } = false;

    /// <summary>
    /// Indicates if this keyword type is invisible.
    /// </summary>
    [JsonPropertyName("invisible")]
    public bool Invisible { get; set; } = false;
}