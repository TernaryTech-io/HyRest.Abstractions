using System.Text.Json.Serialization;
using Ternary.DataConversions.Extensions;

namespace HyRest;

/// <summary>
/// Base Rest Service abstract class for Item Types, like DocumentTypes, Keyword Types, etc
/// </summary>
/// <typeparam name="IHylandRestAPI"></typeparam>
/// <typeparam name="IOnBaseItemType"></typeparam>
public abstract class OnBaseItemTypeService<TApi,TModule,TItem> : OnBaseRestService<TApi>, IOnBaseItemTypeService
    where TApi : IHylandRestAPI
    where TModule : class, IOnBaseModule
    where TItem : class, IOnBaseItemType
{
    private readonly TItem _item;
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
}


/// <summary>
/// Base Rest Service interface for Item Types, like DocumentTypes, Keyword Types, etc
/// </summary>
public interface IOnBaseItemTypeService : IOnBaseRestService
{
    long Id { get; }
    string Name { get; }
    string SystemName { get; }
}
