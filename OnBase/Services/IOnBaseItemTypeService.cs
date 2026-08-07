using System.Text.Json.Serialization;
using Ternary.DataConversions.Extensions;

namespace HyRest;

/// <summary>
/// Base Rest Service abstract class for Item Types, like DocumentTypes, Keyword Types, etc
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemType"></typeparam>
public abstract class OnBaseItemTypeService<TModule,TItem> : OnBaseRestService, IOnBaseItemTypeService
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItemType
{
    private TItem _item;
    protected OnBaseItemTypeService(TModule module, TItem item) : base(module) 
    {
        _item = item;
    }
    internal protected new TModule Module => (TModule)base.Module;
    internal protected TItem Item => _item;
    [JsonPropertyOrder(-3)]
    public long Id => _item.Id.ConvertTo<long>();
    [JsonPropertyOrder(-2)]
    public string Name => _item.Name ?? string.Empty;
    [JsonPropertyOrder(-1)]
    public string SystemName => _item.SystemName ?? string.Empty;
    [JsonIgnore]
    public virtual IDictionary<string, object> AdditionalProperties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    protected void ReplaceModel(TItem model)
    {
        _item = model;
    }
}


/// <summary>
/// Base Rest Service interface for Item Types, like DocumentTypes, Keyword Types, etc
/// </summary>
public interface IOnBaseItemTypeService : IOnBaseIdentifiable
{
    string Name { get; }
    string SystemName { get; }
}
