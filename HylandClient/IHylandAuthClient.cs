namespace HyRest
{
    public interface IHylandAuthClient
    {
        IAuthenticationToken? AuthToken { get; }
        bool IsAuthenticated { get; }
        bool IsExpired { get; }
        UserInfo? UserInfo { get; }
        Task<string> GetAccessTokenAsync();
        string GetAccessToken();
        Task<IAuthenticationToken> AuthenticateAsync();
    }
}


