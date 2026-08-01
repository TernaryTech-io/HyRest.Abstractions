using System.Collections;

namespace HyRest;

/// <summary>
/// Base Rest Service abstract for Item Type Collections, like DocumentTypes, Keyword Types, etc
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemService"></typeparam>
public abstract class OnBaseItemCollectionService<TApi, TModule, TItem> : OnBaseRestService<TApi>, IReadOnlyCollection<TItem>, IOnBaseItemCollectionService
    where TApi : IHylandRestAPI
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItemService
{
    private ICollection<TItem> _items = new List<TItem>();
    protected OnBaseItemCollectionService(TModule module) : base(module)
    {

    }
    protected void Add(TItem item) => _items.Add(item);
    protected new TModule Module => (TModule)base.Module;
    public int Count => _items.Count;
    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator() => _items.GetEnumerator();    
    public IEnumerator GetEnumerator() => _items.GetEnumerator();
    protected abstract Task GetCollection();
}

/// <summary>
/// Represents the base interface for retrieving collections of items.
/// </summary>
public interface IOnBaseItemCollectionService : IOnBaseRestService
{
    int Count { get; }
    IEnumerator GetEnumerator();
}
