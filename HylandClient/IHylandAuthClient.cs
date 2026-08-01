using System;
using System.Collections.Generic;
using System.Text;

namespace HyRest
{
    public interface IHylandAuthClient
    {
        IAuthenticationToken? AuthToken { get; }
        bool IsAuthenticated { get; }
        bool IsExpired { get; }
        Task<string> GetAccessTokenAsync();
        string GetAccessToken();
    }
}


