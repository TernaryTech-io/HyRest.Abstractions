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
    private IOnBaseAppCache<TItem?> _cache;
    protected OnBaseItemCollectionService(TModule module, IOnBaseAppCache<TItem> cache) : base(module)
    {
        _cache = cache;
        GetCollection();
    }
    internal protected new TModule Module => (TModule)base.Module;
    internal protected List<TItem> _items { get; set; } = new List<TItem>();
    internal protected IOnBaseAppCache<TItem?> Cache => _cache;
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
    /// Search the collection for the item type. 
    /// </summary>
    /// <param name="Identifier">Can be Id, Name or System Name</param>
    /// <returns></returns>
    public TItem? Find(string identifier)
    {
        if (_items.Count == 0)
            GetCollection().Wait();
        TItem? result = _items.FirstOrDefault(i => i.Id.ToString() == identifier || i.Name == identifier || i.SystemName == identifier);
        if(result == null)
        {
            var findOneTask = FindOne(identifier);
            findOneTask.Wait();
            if (findOneTask.IsCompletedSuccessfully)
                result = findOneTask.Result;
        }              
        if (result != null)
        {
            var getOneTask = GetOne(result.Id.ToString());
            getOneTask.Wait();
            if (getOneTask.IsCompletedSuccessfully)
                result = getOneTask.Result;
        }
        
        return result;
    }
    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
    {
        if (_items.Count == 0)
            GetCollection().Wait();
        return _items.GetEnumerator();
    }
    public IEnumerator GetEnumerator()
    {
        if (_items.Count == 0)
            GetCollection().Wait();
        return _items.GetEnumerator();
    }
    protected abstract Task GetCollection(CancellationToken token = default);
    protected abstract Task<TItem?> GetOne(string identifier, CancellationToken token = default);
    protected abstract Task<TItem?> FindOne(string identifier, CancellationToken token = default);
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
