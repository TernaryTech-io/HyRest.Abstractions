
using System.Text.Json.Serialization;
using Ternary.DataConversions.Extensions;

namespace HyRest;

/// <summary>
/// Represents the base abstract class for retrieving collections of items.
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseModule"></typeparam>
/// <typeparam name="IOnBaseItemService"></typeparam>
public abstract class OnBaseItemService<TApi,TModule,TItem> : OnBaseRestService<TApi>, IOnBaseItemService
    where TApi : IHylandRestAPI
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItem
{
    private TItem _item;
    protected OnBaseItemService(TModule module, TItem item) : base(module)
    {
        _item = item;
    }
    internal new protected TModule Module => (TModule)base.Module;
    internal protected TItem Item => _item;
    [JsonPropertyOrder(-3)]
    public virtual long Id => _item.Id.ConvertTo<long>();
    [JsonPropertyName("name")]
    public virtual string? Name { get; }
    [JsonPropertyName("systemName")]
    public virtual string? SystemName { get; }
    [JsonIgnore]
    public virtual IDictionary<string, object> AdditionalProperties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    protected void ReplaceModel(TItem model)
    {
        _item = model;
    }
}

/// <summary>
/// Base Rest Service interface for Item like Documents, Keywords, Notes.
/// </summary>
public interface IOnBaseItemService : IOnBaseRestService
{
    long Id { get; }
    string? Name { get; }
    string? SystemName { get; }
}