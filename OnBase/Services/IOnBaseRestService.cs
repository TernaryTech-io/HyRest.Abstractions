using HyRest.Utilities;

namespace HyRest;

public abstract class OnBaseRestService : IOnBaseRestService
{    
    protected OnBaseRestService(IOnBaseModule module)
    {
        _module = module;
    }
    private readonly IOnBaseModule _module;
    internal protected IHylandClientOptions Options => _module.App.ClientOptions;
    internal protected virtual IOnBaseModule Module => _module;
    public virtual string? ToJson()
        => JsonUtility.Serialize(this);
}

/// <summary>
/// Unifies IOnBaseItemService & IOnBaseItemType Service for Cache implementation
/// </summary>
public interface IOnBaseIdentifiable : IOnBaseRestService
{
    long Id { get; }
}
/// <summary>
/// Base Rest Service interface for Items and Collections
/// </summary>
public interface IOnBaseRestService
{    
    string? ToJson();
}