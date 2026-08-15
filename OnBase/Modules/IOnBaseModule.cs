using HyRest.OnBase.ApiServices;
using Microsoft.Extensions.Logging;

namespace HyRest;

public abstract class OnBaseModule<TService> : IOnBaseModule
    where TService : class, IOnBaseService
{
    protected OnBaseModule(IOnBaseApp app, TService service, ILogger<IOnBaseModule> logger)
    {
        _app = app;
        _service = service;
        _logger = logger;
    }
    private readonly TService _service;
    private readonly IOnBaseApp _app;
    private readonly ILogger<IOnBaseModule> _logger;
    public TService Service => _service;
    IOnBaseService IOnBaseModule.Service => Service;
    public IOnBaseApp App => _app;
    public ILogger<IOnBaseModule> Logger { get; }
}

/// <summary>
/// Represents the base OnBase module, for Document Management, WorkView, etc
/// </summary>
public interface IOnBaseModule
{
    IOnBaseApp App { get; }
    IOnBaseService Service { get; }
    ILogger<IOnBaseModule> Logger { get; }
}