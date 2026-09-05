using HyRest.Hyland;
using HyRest.Utilities;
using System.Collections;

namespace HyRest;

public abstract class HylandItemCollectionService<TModule, TItem> : HylandRestService, IHylandItemCollectionService, IReadOnlyCollection<TItem>
    where TModule : class, IHylandModule
    where TItem : class, IHylandItemService
{
    protected HylandItemCollectionService(TModule module) : base(module)
    {
        //GetCollection();
    }
    internal protected new TModule Module => (TModule)base.Module;
    internal protected List<TItem> _items { get; set; } = new List<TItem>();
    public int Count => _items.Count;
    internal protected void Add(TItem item) => _items.Add(item);
    public TItem? this[string identifier] => Find(identifier);
    /// <summary>
    /// Search the collection for the item. 
    /// </summary>
    /// <param name="Identifier">Can be Id, Name or System Name</param>
    /// <returns></returns>
    public abstract TItem? Find(string identifier);
    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
        => _items.GetEnumerator();
    public IEnumerator GetEnumerator()
        => _items.GetEnumerator();
    IHylandItemService? IHylandItemCollectionService.Find(string identifier)
     => Find(identifier);
    protected abstract Task GetCollection(CancellationToken token = default);
    protected abstract Task<TItem?> GetOne(string id, CancellationToken token = default);
}

public abstract class HylandItemService<TModule, TItem> : HylandRestService, IHylandItemService
    where TModule : class, IHylandModule
    where TItem : class, IHylandItem
{
    private TItem _item;
    protected HylandItemService(TModule module, TItem item) : base(module)
    {
        _item = item;
    }
    internal new protected TModule Module => (TModule)base.Module;
    internal protected TItem Item => _item;
    protected void ReplaceModel(TItem? model)
    {
        if (model != null)
            _item = model;
    }
}

public abstract class HylandRestService : IHylandRestService
{
    protected HylandRestService(IHylandModule module)
    {
        _module = module;
    }
    private readonly IHylandModule _module;
    internal protected IHylandClientOptions Options => _module.App.ClientOptions;
    internal protected virtual IHylandModule Module => _module;
    public virtual string? ToJson()
        => JsonUtility.Serialize(this);
}

/// <summary>
/// Represents the base interface for retrieving collections of items.
/// </summary>
public interface IHylandItemCollectionService : IHylandRestService
{
    IHylandItemService? Find(string identifier);
}

/// <summary>
/// Base Rest Service interface for Items and Collections
/// </summary>
public interface IHylandRestService
{
    string? ToJson();
}

/// <summary>
/// Base Rest Service interface for Item like Documents, Keywords, Notes.
/// </summary>
public interface IHylandItemService : IHylandRestService
{

}

/// <summary>
/// Base Rest Service interface for Item like Documents, Keywords, Notes.
/// </summary>
public interface IHylandItem
{

}