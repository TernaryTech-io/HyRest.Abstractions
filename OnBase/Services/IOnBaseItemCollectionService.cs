using HyRest.Cache;
using System.Collections;

namespace HyRest;

/// <summary>
/// Base Rest Service abstract for Item Type Collections, like DocumentTypes, Keyword Types, etc
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemService"></typeparam>
public abstract class OnBaseItemCollectionService<TModule, TItem> : OnBaseRestService, IOnBaseItemCollectionService, IReadOnlyCollection<TItem>
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItemService
{
    protected OnBaseItemCollectionService(TModule module) : base(module)
    {        
        //GetCollection();
    }
    internal protected new TModule Module => (TModule)base.Module;
    internal protected List<TItem> _items { get; set; } = new List<TItem>();
    public int Count => _items.Count;
    internal protected void Add(TItem item) => _items.Add(item);
    public bool HasItem(long id) => _items.Any(i => i.Id == id);
    public TItem? this[long id] => Find(id);
    public TItem? this[string identifier] => Find(identifier);
    /// <summary>
    /// Search the collection for the item type.
    /// </summary>
    /// <param name="id">Id of the them item type.</param>
    /// <returns></returns>
    public TItem? Find(long id) => Find(id.ToString());
    /// <summary>
    /// Search the collection for the item. 
    /// </summary>
    /// <param name="Identifier">Can be Id, Name or System Name</param>
    /// <returns></returns>
    public TItem? Find(string identifier)
     => _items.FirstOrDefault(i => i.Id.ToString() == identifier || i.Name == identifier || i.SystemName == identifier);
    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
        => _items.GetEnumerator();
    public IEnumerator GetEnumerator()
        => _items.GetEnumerator();
    protected void AddOrUpdate(TItem item)
    {
        if (_items.Any(i => i.Id == item.Id))
            _items.RemoveAll(i => i.Id == item.Id);
        _items.Add(item);
    }
    IOnBaseItemService? IOnBaseItemCollectionService.Find(string identifier)
     => Find(identifier);
}

/// <summary>
/// Represents the base interface for retrieving collections of items.
/// </summary>
public interface IOnBaseItemCollectionService : IOnBaseRestService
{
    IOnBaseItemService? Find(string identifier);
}
