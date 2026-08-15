using Microsoft.Extensions.Logging;

namespace HyRest.OnBase.Administration;

public interface IOnBaseAdministration : IOnBaseModule
{
    new ILogger<IOnBaseAdministration> Logger { get; }
    ILogger<IOnBaseModule> IOnBaseModule.Logger => Logger;
}
