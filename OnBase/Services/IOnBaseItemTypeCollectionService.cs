
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace HyRest;

/// <summary>
/// Represents the base abstract class for retrieving collections of items.
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemTypeService"></typeparam>
public abstract class OnBaseItemTypeCollectionService<TModule, TItem> : OnBaseRestService, IOnBaseItemTypeCollectionService, IReadOnlyCollection<TItem>
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItemTypeService
{
    private bool _retrieved { get; set; }
    public OnBaseItemTypeCollectionService(IOnBaseModule module) : base(module)
    {
        //GetCollection();
    }
    internal protected new TModule Module => (TModule)base.Module;
    internal protected List<TItem> _items { get; set; } = [];
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
        TItem? item = null;
        if (!_retrieved)
        {
            GetCollection().Wait(Module.App.RequestTimeOut);
            _retrieved = true;
            item = _items.FirstOrDefault(i => i.Id.ToString() == identifier || i.Name == identifier || i.SystemName == identifier);
            if(item != null)
                GetDetailedObject(item);
        }     
        return item;
    }
    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
    {
        if (!_retrieved)
        {
            GetCollection().Wait(Module.App.RequestTimeOut);
            _retrieved = true;
        }
        return _items.GetEnumerator();
    }
    public IEnumerator GetEnumerator()
    {
        if (_items.Count == 0)
        {
            GetCollection().Wait(Module.App.RequestTimeOut);
            _retrieved = true;
        }
        return _items.GetEnumerator();
    }
    protected void AddOrUpdate(TItem item)
    {
        if(_items.Any(i => i.Id == item.Id))
            _items.RemoveAll(i => i.Id == item.Id);
        _items.Add(item);
    }
    private async Task GetDetailedObject(TItem item)
    {
        var detailed = await GetOne(item.Id.ToString());
        if(detailed != null)
            AddOrUpdate(detailed);
    }
    protected abstract Task GetCollection(CancellationToken token = default);
    protected abstract Task<TItem?> GetOne(string id, CancellationToken token = default);
    IOnBaseItemTypeService? IOnBaseItemTypeCollectionService.Find(string identifier)
     => Find(identifier);
}

/// <summary>
/// Base Rest Service interface for Item Type Collections, like DocumentTypes, Keyword Types, etc
/// </summary>
public interface IOnBaseItemTypeCollectionService : IOnBaseRestService
{
    IOnBaseItemTypeService? Find(string identifier);
}