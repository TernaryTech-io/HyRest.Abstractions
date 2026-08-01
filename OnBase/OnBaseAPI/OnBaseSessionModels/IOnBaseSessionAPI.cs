using Refit;

namespace HyRest.API;

/// <summary>
/// Refit interface for the OnBase API Server session lifecycle endpoints.
/// These are distinct from the Identity Provider — they manage the OnBase license
/// session that is created on first document API request.
/// </summary>
public partial interface IOnBaseSessionAPI : IHylandRestAPI
{
    /// <summary>
    /// Initiates an OnBase session and retrieves the session cookie by making a
    /// lightweight request to a known endpoint. Call this immediately after creating
    /// the client so the session is established and the cookie is captured before
    /// any real API calls are made.
    /// </summary>
    [Headers("Authorization")]
    [Get("/onbase/core/file-types/2")]
    Task<ApiResponse<FileTypeModel>> InitiateSessionAsync();

    /// <summary>
    /// Refreshes the session and extends the session cookie lifetime by 5 minutes.
    /// Call every 4–5 minutes during idle periods to prevent session expiry.
    /// </summary>
    [Post("/onbase/core/session/heartbeat")]
    Task<IApiResponse> HeartbeatAsync();

    /// <summary>
    /// Terminates the OnBase session and releases the consumed license.
    /// Always call this when finished to avoid license leaks.
    /// </summary>
    [Post("/onbase/core/session/disconnect")]
    Task <IApiResponse> DisconnectAsync();
}
