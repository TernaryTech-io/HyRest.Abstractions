using System.Text.Json.Serialization;

namespace HyRest;


/// <summary>
/// Base abstract class for all Items including Model's
/// </summary>
public abstract class HylandBase : IHylandBase
{
    private IDictionary<string, object> _additionalProperties { get; set; } = new Dictionary<string, object>();

    [JsonIgnore]
    [JsonExtensionData]    
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }
}

/// <summary>
/// Base interface for all Items including Model's
/// </summary>
public interface IHylandBase
{
    IDictionary<string, object> AdditionalProperties { get; set; }
}