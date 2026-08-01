using Refit;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Get all password policies configured in the system.</summary>
    /// <remarks>Get all password policies configured in the system.</remarks>
    /// <param name="ids">The unique identifier of one or more items.</param>
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
    [Get("/onbase/administration/api/password-policies")]
    Task<ApiResponse<PasswordPolicyCollectionModel>> PasswordPoliciesGet([Query(CollectionFormat.Multi)] IEnumerable<string> ids, [Query] int? limit, [Query] string lastValue, [Query] bool? descendingOrder);

    /// <summary>Creates a password policy.</summary>
    /// <remarks>Creates a password policy.</remarks>
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
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Post("/onbase/administration/api/password-policies")]
    Task<ApiResponse<PasswordPolicyModel>> PasswordPoliciesPost([Body] PasswordPolicyModel body);

    /// <summary>Update sequence number and descriptions of a list of password policies.</summary>
    /// <remarks>Update sequence number and descriptions of a list of password policies.</remarks>
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
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Put("/onbase/administration/api/password-policies")]
    Task<ApiResponse<PasswordPolicyCollectionModel>> PasswordPoliciesPut([Body] PasswordPolicyCollectionModel body);

    /// <summary>Gets a specific password policy.</summary>
    /// <remarks>Gets a specific password policy.</remarks>
    /// <param name="passwordPolicyId">The unique identifier of a password policy.</param>
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
    [Get("/onbase/administration/api/password-policies/{passwordPolicyId}")]
    Task<ApiResponse<PasswordPolicyModel>> PasswordPoliciesGet2(string passwordPolicyId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Replace an existing password policy.</summary>
    /// <remarks>Replace an existing password policy.</remarks>
    /// <param name="passwordPolicyId">The unique identifier of a password policy.</param>
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
    [Put("/onbase/administration/api/password-policies/{passwordPolicyId}")]
    Task<ApiResponse<PasswordPolicyModel>> PasswordPoliciesPut2(string passwordPolicyId, [Body] PasswordPolicyModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Update system password policy</summary>
    /// <remarks>Update system password policy</remarks>
    /// <param name="newPolicyNum">The unique identifier of a password policy.</param>
    /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
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
    [Put("/onbase/administration/api/password-policies/default-password-policy")]
    Task<IApiResponse> DefaultPasswordPolicy([Query] int newPolicyNum);
}