using HyRest.OnBase.Core;
using Microsoft.Extensions.Logging;

namespace HyRest.OnBase.WorkView;

public interface IOnBaseWorkView : IOnBaseModule
{
    new ILogger<IOnBaseWorkView> Logger { get; }
    ILogger<IOnBaseModule> IOnBaseModule.Logger => Logger;
}
