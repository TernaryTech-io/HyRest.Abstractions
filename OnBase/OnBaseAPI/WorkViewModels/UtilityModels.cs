using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Json of any form or can also be a generic string.
/// </summary>    
public partial class SettingModel
{

    [JsonPropertyName("setting")]
    public string Setting { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}


/// <summary>
/// Details regarding a failure when setting a specific Attribute value to an invalid or unsupported source value.
/// </summary>

public partial class ValidationItemDetailModel
{

    /// <summary>
    /// Data address of the attibute being set.
    /// </summary>
    [JsonPropertyName("dataAddress")]
    public string DataAddress { get; set; }

    /// <summary>
    /// System name of the attibute being set.
    /// </summary>
    [JsonPropertyName("attributeName")]
    public string AttributeName { get; set; }

    /// <summary>
    /// The bad value requested to be set for the Attribute.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }

    /// <summary>
    /// Text describing the detail of the error
    /// </summary>
    [JsonPropertyName("problemDescription")]
    public string ProblemDescription { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}

/// <summary>
/// Details of a refused or failed Object Maintenance Interaction.
/// </summary>

public partial class ValidationProblemModel : ProblemModel
{

    /// <summary>
    /// A return code describing the source or reason for the validation problem.
    /// </summary>
    [JsonPropertyName("returnCode")]
    public ObjectMaintenanceReturnCode ReturnCode { get; set; }

    /// <summary>
    /// An array of any dataType validation failures.
    /// </summary>
    [JsonPropertyName("validationDetail")]
    public ICollection<ValidationItemDetailModel> ValidationDetail { get; set; }

}