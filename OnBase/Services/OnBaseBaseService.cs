
using System.Text.Json.Serialization;

namespace HyRest;

/// <summary>
/// Represents the base abstract class for retrieving collections of items.
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseModule"></typeparam>
/// <typeparam name="IOnBaseGenericService"></typeparam>
public abstract class OnBaseBaseService<TModule, TGeneric> : OnBaseRestService, IOnBaseBaseService
    where TModule : class, IOnBaseModule
    where TGeneric : class, IOnBaseBase
{
    private TGeneric _item;
    protected OnBaseBaseService(TModule module, TGeneric item) : base(module)
    {
        _item = item;
    }
    internal new protected TModule Module => (TModule)base.Module;
    internal protected TGeneric Item => _item;
    [JsonIgnore]
    public virtual IDictionary<string, object> AdditionalProperties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    protected void ReplaceModel(TGeneric? model)
    {
        if (model != null)
            _item = model;
    }
}

/// <summary>
/// Base Rest Service interface for Generic like Documents, Keywords, Notes.
/// </summary>
public interface IOnBaseBaseService : IOnBaseRestService
{
    
}