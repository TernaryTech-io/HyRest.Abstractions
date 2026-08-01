using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An array of currency formats.
/// </summary>
public partial class CurrencyFormatCollectionModel : OnBaseItemTypeCollection<CurrencyFormatModel>
{

}
/// <summary>
/// Currency format metadata
/// </summary>
public partial class CurrencyFormatModel : OnBaseItemType
{
    /// <summary>
    /// The symbol to represent the currency. For instance, the '$' in $1,000.00.
    /// </summary>
    [JsonPropertyName("currencySymbol")]
    public string? CurrencySymbol { get; set; }

    /// <summary>
    /// The number of decimal places represented after the decimal point.
    /// </summary>
    [JsonPropertyName("decimalPlaces")]
    public long DecimalPlaces { get; set; }

    /// <summary>
    /// The symbol to represent the decimal place. For instance, the '.' in 100.00.
    /// </summary>
    [JsonPropertyName("decimalSymbol")]
    public string? DecimalSymbol { get; set; }

    /// <summary>
    /// The number of digits by which to group. Also the number of digits between grouping symbols. For instance, in
    /// <br/>$1,000,000.00 the number of grouping digits is 3.
    /// </summary>
    [JsonPropertyName("groupingDigits")]
    public long GroupingDigits { get; set; }

    /// <summary>
    /// The symbol to represent the grouping of digits. For instance, the ',' in 1,000,000.00.
    /// </summary>
    [JsonPropertyName("groupingSymbol")]
    public string? GroupingSymbol { get; set; }

    /// <summary>
    /// The ISO name for the currency format if one exists.
    /// </summary>
    [JsonPropertyName("isoCurrencyName")]
    public string? IsoCurrencyName { get; set; }

    /// <summary>
    /// A value indicating whether the format allows for a currency symbols.
    /// </summary>
    [JsonPropertyName("hasCurrencySymbol")]
    public bool HasCurrencySymbol { get; set; }

    /// <summary>
    /// A value indicating whether a grouping symbol is specified. Ex. $9,999.00.
    /// </summary>
    [JsonPropertyName("hasGroupSeparator")]
    public bool HasGroupSeparator { get; set; }

    /// <summary>
    /// A value indicating whether there is a leading zero.
    /// </summary>
    [JsonPropertyName("hasLeadingZero")]
    public bool HasLeadingZero { get; set; }

    /// <summary>
    /// A value indicating whether there is a a minus sign. If true, negativity is indicated with a minus sign "-". If
    /// <br/>false, negativity is indicated with parentheses around the value.
    /// </summary>
    [JsonPropertyName("hasMinusSign")]
    public bool HasMinusSign { get; set; }

    /// <summary>
    /// A value indicating whether there is a space between the currency symbol and positive values
    /// <br/>Ex. $ 9.99
    /// <br/>Ex. 9.99 $
    /// </summary>
    [JsonPropertyName("hasWhitespace")]
    public bool HasWhitespace { get; set; }

    /// <summary>
    /// A value indicating whether there is a space between the currency symbol and negative values. Ex. $ -9.99 Ex. -9.99 $.
    /// </summary>
    [JsonPropertyName("hasWhitespaceOnNegative")]
    public bool HasWhitespaceOnNegative { get; set; }

    /// <summary>
    /// A value indicating whether the minus is after the number. Only respected if hasMinusSign is also true.
    /// </summary>
    [JsonPropertyName("isMinusSignAfter")]
    public bool IsMinusSignAfter { get; set; }

    /// <summary>
    /// A value indicating whether the currency symbol goes after positive values
    /// <br/>Ex. 9.99$.
    /// </summary>
    [JsonPropertyName("isSymbolAfter")]
    public bool IsSymbolAfter { get; set; }

    /// <summary>
    /// A value indicating whether the currency symbol comes after the decimal value. Ex. 9.99$-.
    /// </summary>
    [JsonPropertyName("isSymbolAfterOnNegative")]
    public bool IsSymbolAfterOnNegative { get; set; }

    /// <summary>
    /// A value indicating whether the Symbol goes inside the negative If MinusSign is false, SymbolInsideNegative is
    /// <br/>automatically on. Ex. ($9.99), not $(9.99) If true, the currency symbol will come before the minus sign. Ex.
    /// <br/>9.99$- If false, the currency symbol will go after the minus sign. Ex. 9.99-$
    /// </summary>
    [JsonPropertyName("isSymbolInsideNegative")]
    public bool IsSymbolInsideNegative { get; set; }
}