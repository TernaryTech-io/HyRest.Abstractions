using System.Text.Json.Serialization;

namespace HyRest.Identity;

public interface IAuthenticationToken
{
    string AccessToken { get; set; }
    int ExpiresIn { get; set; }
    string TokenType { get; set; }
    string Scope { get; set; }
    DateTime Expiration { get; }
    string AuthHeader { get; }
    bool IsExpired();
}