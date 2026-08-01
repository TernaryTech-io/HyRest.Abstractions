using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Result with dotted addresses.
/// </summary>
public partial class ObjectResultModel : ObjectModel
{

    [JsonPropertyName("attributeValues")]
    public override AttributeValuesModel Values { get; set; } = new AttributeValuesModel();
}


/// <summary>
/// Shortened representation of an Object.
/// </summary>    
public partial class AbbreviatedObjectModel : ObjectModel
{  

    [JsonPropertyName("modifiedValues")]
    public override AttributeValuesModel Values { get; set; } 
}

/// <summary>
/// Values to set on the created Object.
/// </summary>    
public partial class ObjectCreateModel : ObjectBaseModel
{

    [JsonPropertyName("attributeValues")]
    public override AttributeValuesModel Values { get; set; } = new AttributeValuesModel();

    /// <summary>
    /// Sets the Object activation state once created (defaults to false).
    /// </summary>
    [JsonPropertyName("activateObject")]
    public bool ActivateObject { get; set; }
}

/// <summary>
/// Values to set on the created Object.
/// </summary>
public partial class ObjectUpdateModel : ObjectBaseModel
{

    [JsonPropertyName("attributeValues")]
    public override AttributeValuesModel Values { get; set; } = new AttributeValuesModel();
}

/// <summary>
/// An action's resulting Object Key.
/// </summary>
public partial class ObjectModel : ObjectBaseModel
{

    /// <summary>
    /// Identifier for an Object.
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("values")]
    public override  AttributeValuesModel Values { get; set; }
}

/// <summary>
/// Result with dotted addresses.
/// </summary>    
public abstract class ObjectBaseModel : HylandBase, IObjectBaseModel
{

    [JsonPropertyName("values")]
    public abstract AttributeValuesModel Values { get; set; }
}

public interface IObjectBaseModel
{
    AttributeValuesModel Values { get; set; }
}
