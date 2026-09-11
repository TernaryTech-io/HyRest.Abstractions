using HyRest.Cache;
using System.Collections;

namespace HyRest;

/// <summary>
/// Base Rest Service abstract for Item Type Collections, like DocumentTypes, Keyword Types, etc
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemService"></typeparam>
public abstract class OnBaseItemCollectionService<TModule, TItem> : OnBaseCollectionService<TModule, TItem>, IOnBaseItemCollectionService
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItemService
{
    protected OnBaseItemCollectionService(TModule module) : base(module)
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
    /// Search the collection for the item. 
    /// </summary>
    /// <param name="Identifier">Can be Id, Name or System Name</param>
    /// <returns></returns>
    public TItem? Find(string identifier)
        => FirstOrDefault(i => i.Id.ToString() == identifier || i.Name == identifier || i.SystemName == identifier);
    protected void AddOrUpdate(TItem item)
    {
        if (Any(i => i.Id == item.Id))
        {
            _items.RemoveAll(i => i.Id == item.Id);
        }
        Add(item);
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
