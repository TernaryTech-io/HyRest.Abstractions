using Microsoft.Extensions.Logging;

namespace HyRest.OnBase.Core;

/// <summary>
/// The Document Management API
/// </summary>
public interface IOnBaseCore : IOnBaseModule
{
    new ILogger<IOnBaseCore> Logger { get; }
    ILogger<IOnBaseModule> IOnBaseModule.Logger => Logger;
}