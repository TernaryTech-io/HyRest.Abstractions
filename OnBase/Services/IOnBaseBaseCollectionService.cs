using HyRest.Cache;
using System.Collections;

namespace HyRest;

/// <summary>
/// Base Rest Service abstract for Collections, like DocumentTypes, Keyword Types, etc
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemService"></typeparam>
public abstract class OnBaseBaseCollectionService<TModule, TItem> : OnBaseRestService, IOnBaseBaseCollectionService, IReadOnlyCollection<TItem>
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseBaseService
{
    protected OnBaseBaseCollectionService(TModule module) : base(module)
    {
    }
    internal protected new TModule Module => (TModule)base.Module;
    internal protected List<TItem> _items { get; set; } = new List<TItem>();
    public int Count => _items.Count;
    internal protected void Add(TItem item) => _items.Add(item);
    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
        => _items.GetEnumerator();
    public IEnumerator GetEnumerator()
        => _items.GetEnumerator();
}

/// <summary>
/// Represents the base interface for retrieving collections of items.
/// </summary>
public interface IOnBaseBaseCollectionService : IOnBaseRestService
{
    
}
