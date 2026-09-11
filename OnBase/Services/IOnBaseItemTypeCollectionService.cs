
using System.Collections;
using System.Collections.Concurrent;
using System.Security.AccessControl;
using static System.Net.Mime.MediaTypeNames;

namespace HyRest;

/// <summary>
/// Represents the base abstract class for retrieving collections of items.
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemTypeService"></typeparam>
public abstract class OnBaseItemTypeCollectionService<TModule, TItem> : OnBaseCollectionService<TModule,TItem>, IOnBaseItemTypeCollectionService
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItemTypeService
{
    private bool _retrieved { get; set; }
    private object _lock = new object();
    public OnBaseItemTypeCollectionService(TModule module) : base(module)
    {
        //GetCollection();
    }
    internal protected new TModule Module => (TModule)base.Module;
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
        }
        item = FirstOrDefault(i => i.Id.ToString() == identifier || i.Name == identifier || i.SystemName == identifier);
        if (item != null)
            GetDetailedObject(item).Wait(Module.App.RequestTimeOut);
        return item;
    }
    protected void AddOrUpdate(TItem item)
    {
        if (Any(i => i.Id == item.Id))
        {
            lock (_lock)
            {
                _items.RemoveAll(i => i.Id == item.Id);
            }
        }
               
        Add(item);
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
