using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyRest.Hyland.IdentityAdministration;

public abstract class HylandIdentityBase : HylandAppBase, IHylandApp
{
    protected HylandIdentityBase(ILogger<IHylandApp> logger, IHylandClientFactory clientFactory) : base(logger, clientFactory)
    {

    }
}


public abstract class IdentityAdminBase<TService> : HylandModule<TService>
    where TService : class, IHylandService
{
    protected IdentityAdminBase(IHylandApp app, TService service) : base(app, service)
    {
    }
}