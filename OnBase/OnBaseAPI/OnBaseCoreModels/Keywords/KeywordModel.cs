
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

public class KeywordModel : OnBaseItem
{
    /// <summary>
    /// The unique identifier of the keyword type for this keyword value.
    /// </summary>
    [JsonPropertyName("typeId")]
    public override string Id { get => base.Id; set => base.Id = value; }
    /// <summary>
    /// A List of keyword values that contain various formats of the keyword
    /// <br/>value.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<KeywordValueModel> Values { get; set; } = [];
}
public partial class KeywordValueModel : OnBaseItem
{
    [JsonIgnore]
    private new string Id { get; set; } = string.Empty;
    /// <summary>
    /// Depending on the underlying keyword type datatype, the specific
    /// <br/>format of the underlying string adheres to the following formatting
    /// <br/>rules.
    /// <br/>
    /// <br/>Values are normalized and locale specific formatting is not applied.
    /// <br/>Formatting to a specific currency is not applied. Consumers can
    /// <br/>apply this formatting through libraries and client locale
    /// <br/>preferences. Determining data type or currency format
    /// <br/>is retrieved from other metadata resources.  
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// A Keyword Value that has been formatted using locale specific formatting
    /// <br/>and Keyword Masking settings.
    /// </summary>
    [JsonPropertyName("formattedValue")]
    public string? FormattedValue { get; set; }

    /// <summary>
    /// The Currency Format Id if the Keyword Type's data type is Specific Currency.
    /// </summary>
    [JsonPropertyName("currencyFormatId")]
    public string? CurrencyFormatId { get; set; }
}
