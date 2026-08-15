using Refit;
using System.Text.Json.Serialization;

namespace HyRest;

/// <summary>
/// Base abstract class for Item Type Models in the Rest API
/// </summary>
public abstract class OnBaseItemType : HylandBase, IOnBaseItemType
{
    /// <summary>
    /// The unique identifier of the object.
    /// </summary>
    [JsonPropertyName("id")]
    public virtual string Id { get; set; }
    /// <summary>
    /// The localized name of the object
    /// </summary>
    [JsonPropertyName("name")]
    public virtual string? Name { get; set; }
    /// <summary>
    /// The untranslated system name of the custom query.
    /// <br/>Localization is controlled by the Accept-Language header and
    /// <br/>the language of the response is represented by the Content-Language
    /// <br/>header.
    /// </summary>
    [JsonPropertyName("systemName")]
    public virtual string? SystemName { get; set; }
}

/// <summary>
/// Base interface for all model Item Types, like Document Types, Keyword Types, etc.
/// </summary>
public interface IOnBaseItemType : IOnBaseCacheable
{

}
