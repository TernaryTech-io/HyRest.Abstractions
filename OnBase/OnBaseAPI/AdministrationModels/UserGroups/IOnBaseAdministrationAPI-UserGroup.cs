using Refit;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Assign or update a list of user groups on specified document type group.</summary>
    /// <remarks>Assign or update a list of user groups on specified document type group.</remarks>
    /// <param name="documentTypeGroupId">The unique identifier of a document type group.</param>
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
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Put("/onbase/administration/api/document-type-groups/{documentTypeGroupId}/user-groups")]
    Task<ApiResponse<UserGroupDocumentTypeGroupAssignmentCollection>> UserGroups(string documentTypeGroupId, [Body] UserGroupDocumentTypeGroupAssignmentCollection body);

    /// <summary>Gets the list of document type groups, user groups assignment information from provided parameter.</summary>
    /// <remarks>Gets the list of document type groups, user groups assignment information from provided parameter.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
    /// <param name="documentTypeGroupId">The unique identifier of a document type group.</param>
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
    [Get("/onbase/administration/api/document-type-groups/user-groups")]
    Task<ApiResponse<UserGroupDocumentTypeGroupAssignmentCollection>> UserGroupsGet([Query] string userGroupId, [Query] string documentTypeGroupId);

    /// <summary>Gets a list of user groups.</summary>
    /// <remarks>Gets the identifier information for all user groups available to the user.</remarks>
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
    [Get("/onbase/administration/api/user-groups")]
    Task<ApiResponse<UserGroupCollectionModel>> UserGroupsGet2([Query(CollectionFormat.Multi)] IEnumerable<string> ids, [Query] int? limit, [Query] string lastValue, [Query] bool? descendingOrder);

    /// <summary>Creates a new user group.</summary>
    /// <remarks>Creates a new user group based on the model that is sent in the request.</remarks>
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
    [Post("/onbase/administration/api/user-groups")]
    Task<ApiResponse<UserGroupModel>> UserGroupsPost([Body] UserGroupPOST body);

    /// <summary>Replace the users, user groups assignments on specified object.</summary>
    /// <remarks>Replace the users, user groups assignments on specified object.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
    /// <param name="userId">The unique identifier of a user.</param>
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
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// <item>
    /// <term>422</term>
    /// <description>Response when the model sent is properly formed, but the data it contains is invalid.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/JSON")]
    [Put("/onbase/administration/api/users/user-groups")]
    Task<ApiResponse<UserGroupUserAssignmentCollectionModel>> UserGroupsPut2([Query] string userGroupId, [Query] string userId, [Body] IEnumerable<UserGroupUserAssignmentModel> body);

    /// <summary>Replace the document types, user groups assignments on specified object.</summary>
    /// <remarks>Replace the document types, user groups assignments on specified object.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
    /// <param name="documentTypeId">The unique identifier of a document type.</param>
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
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// <item>
    /// <term>422</term>
    /// <description>Response when the model sent is properly formed, but the data it contains is invalid.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/JSON")]
    [Put("/onbase/administration/api/document-types/user-groups")]
    Task<ApiResponse<UserGroupDocumentTypeAssignmentCollection>> UserGroupsPut3([Query] string userGroupId, [Query] string documentTypeId, [Body] IEnumerable<UserGroupDocumentTypeAssignment> body);


    /// <summary>Gets the list of users, user groups assignment information from provided parameter.</summary>
    /// <remarks>Gets the list of users, user groups assignment information from provided parameter.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Get("/onbase/administration/api/users/user-groups")]
    Task<ApiResponse<UserGroupUserAssignmentCollectionModel>> UserGroupsGet4([Query] string userGroupId, [Query] string userId);

    /// <summary>Gets the list of document types, user groups assignment information from provided parameter.</summary>
    /// <remarks>Gets the list of document types, user groups assignment information from provided parameter.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
    /// <param name="documentTypeId">The unique identifier of a document type.</param>
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
    [Get("/onbase/administration/api/document-types/user-groups")]
    Task<ApiResponse<UserGroupDocumentTypeAssignmentCollection>> UserGroupsGet5([Query] string userGroupId, [Query] string documentTypeId);

    /// <summary>Gets a specific user group.</summary>
    /// <remarks>Gets the user group information for a specific user group.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Get("/onbase/administration/api/user-groups/{userGroupId}")]
    Task<ApiResponse<UserGroupModel>> UserGroupsGet3(string userGroupId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Replace an existing user group.</summary>
    /// <remarks>Replace the user group with the provided user group.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Put("/onbase/administration/api/user-groups/{userGroupId}")]
    Task<ApiResponse<UserGroupModel>> UserGroupsPut(string userGroupId, [Body] UserGroupModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Gets general privileges for a user group.</summary>
    /// <remarks>Gets general privileges for a user group.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Get("/onbase/administration/api/user-groups/{userGroupId}/permissions/privileges")]
    Task<ApiResponse<UserGroupPrivilegesModel>> PrivilegesGet(string userGroupId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Update privileges for a user group</summary>
    /// <remarks>Update privileges for a user group</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Put("/onbase/administration/api/user-groups/{userGroupId}/permissions/privileges")]
    Task<ApiResponse<UserGroupPrivilegesModel>> PrivilegesPut(string userGroupId, [Body] UserGroupPrivilegesModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Gets configuration rights for a user group.</summary>
    /// <remarks>Gets configuration rights for a user group.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Get("/onbase/administration/api/user-groups/{userGroupId}/permissions/configuration-rights")]
    Task<ApiResponse<UserGroupConfigurationRightsModel>> ConfigurationRightsGet(string userGroupId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Update configuration rights for a user group</summary>
    /// <remarks>Update configuration rights for a user group</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Put("/onbase/administration/api/user-groups/{userGroupId}/permissions/configuration-rights")]
    Task<ApiResponse<UserGroupConfigurationRightsModel>> ConfigurationRightsPut(string userGroupId, [Body] UserGroupConfigurationRightsModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Gets product rights for a user group.</summary>
    /// <remarks>Gets product rights for a user group.</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Get("/onbase/administration/api/user-groups/{userGroupId}/permissions/product-rights")]
    Task<ApiResponse<UserGroupProductRightsModel>> ProductRightsGet(string userGroupId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Update product rights for a user group</summary>
    /// <remarks>Update product rights for a user group</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Put("/onbase/administration/api/user-groups/{userGroupId}/permissions/product-rights")]
    Task<ApiResponse<UserGroupProductRightsModel>> ProductRightsPut(string userGroupId, [Body] UserGroupProductRightsModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Gets security keywords for a user group</summary>
    /// <remarks>Gets the security keywords for specific user group</remarks>
    /// <param name="userGroupId">The unique identifier of a user group.</param>
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
    [Get("/onbase/administration/api/user-groups/{userGroupId}/security-keywords")]
    Task<ApiResponse<UserGroupSecurityKeywordCollection>> SecurityKeywords2(string userGroupId);
}