using System.Text.Json.Serialization;

namespace HyRest;

/// <summary>
/// Base abstract class for all model colletions, for Documents, Keywords, etc.
/// </summary>
public abstract class OnBaseBaseCollection<T> : OnBaseBaseCollection
    where T : class, IOnBaseBase
{
    /// <summary>
    /// An array of T items.
    /// </summary>
    [JsonPropertyName("items")]
    public new ICollection<T> Items
    {
        get => base.Items.Select(i => (T)i).ToList();
        set => base.Items = value.Select(i => (IOnBaseBase)i).ToList();
    }
}

/// <summary>
/// Base abstract class for all model colletions, for Documents, Keywords, etc.
/// </summary>
public abstract class OnBaseBaseCollection : HylandBase, IOnBaseBaseCollection
{
    public virtual ICollection<IOnBaseBase> Items { get; set; } = [];
}

public interface IOnBaseBaseCollection
{
    ICollection<IOnBaseBase> Items { get; set; }
}
