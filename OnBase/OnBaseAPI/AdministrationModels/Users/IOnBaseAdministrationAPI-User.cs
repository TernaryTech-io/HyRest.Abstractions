using Refit;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Gets a list of users.</summary>
    /// <remarks>Gets the identifier information for all users available to the user.</remarks>
    /// <param name="ids">The unique identifier of one or more items.</param>
    /// <param name="serviceAccount">Indicate service account filtering.</param>
    /// <param name="limit">The maximum amount of items per page. 0 indicates no limit.</param>
    /// <param name="lastValue">name of the last value shown on previous page. Null indicates to start from first value.</param>
    /// <param name="descendingOrder">boolean to retrive the values in descending order.</param>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/administration/api/users")]
    Task<ApiResponse<UserCollectionModel>> UsersGet([Query(CollectionFormat.Multi)] IEnumerable<string>? ids = null, [Query] bool? serviceAccount = null, [Query] int? limit = null, [Query] string? lastValue = null, [Query] bool? descendingOrder = true);

    /// <summary>Creates a new user.</summary>
    /// <remarks>Creates a new user based on the model that is sent in the request.</remarks>
    /// <param name="body">body parameter</param>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>Response for when a bad request is provided.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// <item>
    /// <term>422</term>
    /// <description>Response when the model sent is properly formed, but the data it contains is invalid.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Post("/onbase/administration/api/users")]
    Task<ApiResponse<UserModel>> UsersPost([Body] UserPOSTModel body);

    /// <summary>Gets a specific user.</summary>
    /// <remarks>Gets the user information for a specific user.</remarks>
    /// <param name="userId">The unique identifier of a user.</param>
    /// <param name="x_Custom_Content_Hash">The hash value of associated primary config object</param>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/administration/api/users/{userId}")]
    Task<ApiResponse<UserModel>> UsersGet2(string userId, [Header("X-Custom-Content-Hash")] string? x_Custom_Content_Hash = null);

    /// <summary>Replace an existing user.</summary>
    /// <remarks>Replace the user with the provided user.</remarks>
    /// <param name="userId">The unique identifier of a user.</param>
    /// <param name="x_Custom_Content_Hash">The hash value of associated primary config object</param>
    /// <param name="body">body parameter</param>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>Response for when a bad request is provided.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Put("/onbase/administration/api/users/{userId}")]
    Task<ApiResponse<UserModel>> UsersPut(string userId, [Body] UserModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Replace an existing users password.</summary>
    /// <remarks>Replace the users password with the provided password.</remarks>
    /// <param name="userId">The unique identifier of a user.</param>
    /// <param name="body">body parameter</param>
    /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>Response for when a bad request is provided.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Content-Type: application/json")]
    [Put("/onbase/administration/api/users/{userId}/change-password")]
    Task<IApiResponse> ChangePassword(string userId, [Body] UserPasswordModel body);

    /// <summary>Returns the rights and privileges for the current user.</summary>
    /// <remarks>Returns the rights and privileges for the current user.</remarks>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>Response for when a bad request is provided.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/administration/api/users/me/permissions")]
    Task<ApiResponse<UserPermissions>> Permissions();

    /// <summary>Gets security keywords for a user</summary>
    /// <remarks>Gets the security keywords for a specific user</remarks>
    /// <param name="userId">The unique identifier of a user.</param>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/administration/api/users/{userId}/security-keywords")]
    Task<ApiResponse<UserSecurityKeywordCollection>> SecurityKeywords(string userId);
}