namespace HyRest.Hyland;


public abstract class HylandModule<TService> : IHylandModule
    where TService : class, IHylandService
{
    protected HylandModule(IHylandApp app, TService service)
    {
        _app = app;
        _service = service;
    }
    private readonly TService _service;
    private readonly IHylandApp _app;
    public TService Service => _service;
    IHylandService IHylandModule.Service => Service;
    public virtual IHylandApp App => _app;
}

/// <summary>
/// Represents the base OnBase module, for Document Management, WorkView, etc
/// </summary>
public interface IHylandModule
{
    IHylandApp App { get; }
    IHylandService Service { get; }
}
