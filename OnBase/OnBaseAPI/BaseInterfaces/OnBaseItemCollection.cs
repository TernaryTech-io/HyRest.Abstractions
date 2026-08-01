using System.Text.Json.Serialization;

namespace HyRest;

/// <summary>
/// Base abstract class for all model colletions, for Documents, Keywords, etc.
/// </summary>
/// <typeparam name="IHylandItem"></typeparam>
public abstract class OnBaseItemCollection<T> : HylandItemCollection
    where T : class, IOnBaseItem
{
    /// <summary>
    /// An array of T items.
    /// </summary>
    [JsonPropertyName("items")]
    public new ICollection<T> Items
    {
        get => base.Items.Select(i => (T)i).ToList();
        set => base.Items = value.Select(i => (IOnBaseItem)i).ToList();
    }
}

/// <summary>
/// Base abstract class for all model colletions, for Documents, Keywords, etc.
/// </summary>
public abstract class HylandItemCollection : HylandBase, IHylandItemCollection<IOnBaseItem>
{
    public virtual ICollection<IOnBaseItem> Items { get; set; } = [];
}

/// <summary>
/// Base interface for all model colletions, for Documents, Keywords, etc.
/// </summary>
/// <typeparam name="IHylandItem"></typeparam>
public interface IHylandItemCollection<IHylandItem> : IHylandItemCollection
{

}
/// <summary>
/// Base interface for all model colletions, for Documents, Keywords, etc.
/// </summary>
public interface IHylandItemCollection
{
    ICollection<IOnBaseItem> Items { get; set; }
}