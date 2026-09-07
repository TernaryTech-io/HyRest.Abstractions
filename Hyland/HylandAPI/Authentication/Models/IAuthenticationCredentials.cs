using HyRest.Hyland.IdentityAdministration;

namespace HyRest;

/// <summary>
/// Base interface for all Identity Service Authentication 
/// </summary>
public interface IAuthenticationCredentials
{
    GrantType GrantType { get; set; }
    List<Scope> Scopes { get; set; }
    string? ClientId { get; set; }
    string? ClientSecret { get; set; }
    string? Username { get; set; }
    string? Password { get; set; }
    string? Tenant { get; set; }
    /// <summary>
    /// Creates form URL-encoded content from non-empty authentication credential properties.
    /// </summary>
    /// <returns>A FormUrlEncodedContent instance containing the encoded form data.</returns>
    FormUrlEncodedContent ToBody();        
}