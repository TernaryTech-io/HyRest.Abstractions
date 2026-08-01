using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HyRest.API.Models;

/// <summary>
/// Value Set Data
/// </summary>    
public partial class ValueSetModel : OnBaseItem
{
    /// <summary>
    /// The name of the value set.
    /// </summary>
    [JsonPropertyName("name")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? Name { get; set; }

    /// <summary>
    /// The value of the system setting.
    /// </summary>
    [JsonPropertyName("copySource")]
    public string? CopySource { get; set; }
}

/// <summary>
/// An array of value sets.
/// </summary>
public partial class ValueSetCollectionModel : OnBaseItemCollection<ValueSetModel>
{
        
}

/// <summary>
/// Destination value data
/// </summary>
public partial class DestinationValueModel : HylandBase
{

    /// <summary>
    /// The Id of the destination value.
    /// </summary>
    [JsonPropertyName("ValueId")]
    public bool ValueId { get; set; }

    /// <summary>
    /// Id corresponding to the referenced item.
    /// </summary>
    [JsonPropertyName("ConfigurationItemId")]
    public int ConfigurationItemId { get; set; }

    /// <summary>
    /// The defined environment value.
    /// </summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

    /// <summary>
    /// Id corresponding to the type of the evm value.
    /// </summary>
    [JsonPropertyName("EvDefinitionId")]
    public int EvDefinitionId { get; set; }

    /// <summary>
    /// The environment value set the destination value is in.
    /// </summary>
    [JsonPropertyName("EvSetId")]
    public int EvSetId { get; set; }

    /// <summary>
    /// Used to determine if the values are encrypted.
    /// </summary>
    [JsonPropertyName("UseProduction")]
    public bool UseProduction { get; set; }

    /// <summary>
    /// Used to hide sensitive values.
    /// </summary>
    [JsonPropertyName("IsBlankValue")]
    public bool IsBlankValue { get; set; }

    /// <summary>
    /// Id corresponding to the referenced type.
    /// </summary>
    [JsonPropertyName("ConfigurationTypeId")]
    public int ConfigurationTypeId { get; set; }
}

/// <summary>
/// An array of destination values.
/// </summary>
public partial class DestinationValueCollectionModel : HylandBase
{

    /// <summary>
    /// An array of destination values.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<DestinationValueModel> Items { get; set; } = [];
}

/// <summary>
/// A configuration type which has environment values associated with it
/// </summary>    
public partial class EvConfigType : HylandBase
{

    /// <summary>
    /// The name of the configuration type
    /// </summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>
    /// The type ID of the configuration type
    /// </summary>
    [JsonPropertyName("Id")]
    public string? Id { get; set; }
}


public partial class SourceValue : HylandBase
{

    /// <summary>
    /// The description of the configuration item to be updated
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the associated configuration item
    /// </summary>
    [JsonPropertyName("configurationItemName")]
    public string? ConfigurationItemName { get; set; }

    /// <summary>
    /// The name of the associated configuration item
    /// </summary>
    [JsonPropertyName("configurationItemId")]
    public string? ConfigurationItemId { get; set; }

    /// <summary>
    /// The configuration type ID of the source value
    /// </summary>
    [JsonPropertyName("configurationTypeId")]
    public string? ConfigurationTypeId { get; set; }

    /// <summary>
    /// The value of the configuration item to be updated
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// The ID of the evdefinition that is the type of this destination value
    /// </summary>
    [JsonPropertyName("evDefinitionId")]
    public string? EvDefinitionId { get; set; }

    /// <summary>
    /// If true, value will not be displayed for security purposes
    /// </summary>
    [JsonPropertyName("isSensitiveValue")]
    public bool IsSensitiveValue { get; set; }

    /// <summary>
    /// Destination value input restrictions
    /// </summary>
    [JsonPropertyName("valueRestrictions")]
    public ValueRestrictions? ValueRestrictions { get; set; }
}

public partial class ValueRestrictions : HylandBase
{
    /// <summary>
    /// Indicates input restrictions None = 0, Alphanumeric = 1, Numeric = 2, FilePaths = 3
    /// </summary>
    [JsonPropertyName("preset")]
    public double Preset { get; set; }

    /// <summary>
    /// The maximum allowed length
    /// </summary>
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }
}