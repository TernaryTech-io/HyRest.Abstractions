using HyRest.Utilities;

namespace HyRest;

public class OnBaseRestService<TApi> : OnBaseRestService
    where TApi : IHylandRestAPI
{
    private TApi _api { get => (TApi)base.Api; set => base.SetApi(value); }
    protected OnBaseRestService(IOnBaseModule module) : base(module)
    {
        _api = Module.Api<TApi>();
    }
    internal protected new TApi Api => _api;
}
public abstract class OnBaseRestService : IOnBaseRestService
{
    private IHylandRestAPI _api { get; set; }
    protected OnBaseRestService(IOnBaseModule module)
    {
        _module = module;
    }
    private readonly IOnBaseModule _module;
    internal protected virtual IHylandRestAPI Api => _api;
    internal protected IHylandClientOptions Options => _module.App.ClientOptions;
    internal protected virtual IOnBaseModule Module => _module;
    internal protected void SetApi(IHylandRestAPI api)
        => _api = api;
    public virtual string? ToJson()
        => JsonUtility.Serialize(this);
}

/// <summary>
/// Base Rest Service interface for Items and Collections
/// </summary>
public interface IOnBaseRestService
{
    string? ToJson();
}