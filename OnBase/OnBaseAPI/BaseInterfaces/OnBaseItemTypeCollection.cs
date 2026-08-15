using System.Text.Json.Serialization;

namespace HyRest;

/// <summary>
/// Base abstract class for all model type colletions, for Document Types, Keyword Types, etc.
/// </summary>
/// <typeparam name="IOnBaseItemType"></typeparam>
public abstract class OnBaseItemTypeCollection<T> : OnBaseItemTypeCollection
    where T : IOnBaseItemType
{
    /// <summary>
    /// An array of T items.
    /// </summary>
    [JsonPropertyName("items")]
    public new ICollection<T> Items
    {
        get => base.Items.Select(i => (T)i).ToList();
        set => base.Items = value.Select(i => (IOnBaseItemType)i).ToList();
    }
}
/// <summary>
/// Base abstract class for all model type colletions, for Document Types, Keyword Types, etc.
/// </summary>
public abstract class OnBaseItemTypeCollection : HylandBase, IOnBaseItemTypeCollection
{
    public virtual ICollection<IOnBaseItemType> Items { get; set; } = [];
}

/// <summary>
/// Base interface for all model type colletions, for Document Types, Keyword Types, etc.
/// </summary>
/// <typeparam name="IHylandItemType"></typeparam>
public interface IOnBaseItemTypeCollection
{
    ICollection<IOnBaseItemType> Items { get; set; }
}