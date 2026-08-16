using HyRest.OnBase.ApiServices;
using Microsoft.Extensions.Logging;

namespace HyRest;

public abstract class OnBaseModule<TService> : IOnBaseModule
    where TService : class, IOnBaseService
{
    protected OnBaseModule(IOnBaseApp app, TService service)
    {
        _app = app;
        _service = service;
    }
    private readonly TService _service;
    private readonly IOnBaseApp _app;
    public TService Service => _service;
    IOnBaseService IOnBaseModule.Service => Service;
    public IOnBaseApp App => _app;
}

/// <summary>
/// Represents the base OnBase module, for Document Management, WorkView, etc
/// </summary>
public interface IOnBaseModule
{
    IOnBaseApp App { get; }
    IOnBaseService Service { get; }
}