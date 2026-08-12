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
        GetCollection();
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
    /// Search the collection for the item type. 
    /// </summary>
    /// <param name="Identifier">Can be Id, Name or System Name</param>
    /// <returns></returns>
    public TItem? Find(string identifier)
    {
        TItem? result = null;
        //Check Cache Service

        if (_items.Count > 0)
        {
            result = _items.FirstOrDefault(i => i.Id.ToString() == identifier || i.Name == identifier || i.SystemName == identifier);
        }         
        if(result == null)
        {
            var findOneTask = FindOne(identifier);
            
            if (findOneTask.Wait(Module.App.ClientOptions.RequestTimeOut) && findOneTask.IsCompletedSuccessfully)
                result = findOneTask.Result;
        }                      
        return result;
    }
    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
    {
        if (_items.Count == 0)
            GetCollection().Wait(Module.App.ClientOptions.RequestTimeOut);
        return _items.GetEnumerator();
    }
    public IEnumerator GetEnumerator()
    {
        if (_items.Count == 0)
            GetCollection().Wait(Module.App.ClientOptions.RequestTimeOut);
        return _items.GetEnumerator();
    }
    protected virtual async Task GetCollection(CancellationToken token = default)
    {
        _items.ForEach(async i =>
        {
            Module.App.Cache.SetAsync(i, token);
        });
    }
    protected virtual async Task<TItem?> GetOne(long id, CancellationToken token = default)
    {
        var item = await Module.App.Cache.GetOrCreateAsync<TItem>(id, null, token);
        if (item != null)
            return item;
        if (_items.Count == 0)
            await GetCollection();
        item = _items.FirstOrDefault(i => i.Id == id);
        if (item != null)
            Module.App.Cache.SetAsync(item, token);
        return item;
    }
    protected virtual async Task<TItem?> FindOne(string identifier, CancellationToken token = default)
    {
        if(long.TryParse(identifier, out long id))
        {
            return await GetOne(id, token);
        }
        if (_items.Count == 0)
            await GetCollection();
        return _items.FirstOrDefault(i => i.Name == identifier || i.SystemName == identifier);
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
