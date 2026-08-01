
using System.Collections;

namespace HyRest;

/// <summary>
/// Represents the base abstract class for retrieving collections of items.
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemTypeService"></typeparam>
public abstract class OnBaseItemTypeCollectionService<TApi, TModule, TItem> : OnBaseItemTypeCollectionService, IReadOnlyCollection<TItem>
    where TApi : IHylandRestAPI
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItemTypeService
{
    private TApi _api { get => (TApi)base.Api; set => base.SetApi(value); }
    public OnBaseItemTypeCollectionService(IOnBaseModule module) : base(module)
    {
        _api = module.Api<TApi>();
    }
    internal protected new TModule Module => (TModule)base.Module;
    internal protected List<TItem> _items { get; set;  } = new List<TItem>();
    internal new protected TApi Api => _api;
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
    public new TItem? Find(string Identifier) => (TItem?)base.Find(Identifier);
    
    public IReadOnlyCollection<TItem> GetAll()
    {
        GetCollection().Wait();
        return _items.ToList();
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
    protected override async Task<IOnBaseItemTypeService?> GetOne(string identifier)
    {
        await GetCollection();
        return _items.FirstOrDefault(i => i.Id.ToString() == identifier || i.SystemName == identifier || i.Name == identifier);
    }
}

/// <summary>
/// Represents the base abstract class for retrieving collections of items.
/// </summary>
public abstract class OnBaseItemTypeCollectionService : OnBaseRestService, IOnBaseItemTypeCollectionService
{
    public OnBaseItemTypeCollectionService(IOnBaseModule module) : base(module) { }
    
    protected abstract Task GetCollection();
    protected abstract Task<IOnBaseItemTypeService?> GetOne(string identifier);
    public virtual IOnBaseItemTypeService? Find(string identifier) 
    {
        if (identifier.StartsWith('-'))
            return null;
        var task = GetOne(identifier);
        task.Wait();
        if (task.IsCompletedSuccessfully && task.Result != null)
            return task.Result;
        return null;
    }
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