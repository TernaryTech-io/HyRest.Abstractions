using Refit;

namespace HyRest.API.Administration;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Gets a list of keyword type group.</summary>
    /// <remarks>Gets a list of keyword type group.</remarks>
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
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/administration/api/keyword-type-groups")]
    Task<ApiResponse<KeywordTypeGroupCollectionModel>> KeywordTypeGroupsGet([Query(CollectionFormat.Multi)] IEnumerable<string> ids, [Query] int? limit, [Query] string lastValue, [Query] bool? descendingOrder);

    /// <summary>Creates a new keyword type group.</summary>
    /// <remarks>Creates a new keyword type group based on the model that is sent in the request.</remarks>
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
    [Post("/onbase/administration/api/keyword-type-groups")]
    Task<ApiResponse<KeywordTypeGroupModel>> KeywordTypeGroupsPost([Body] KeywordTypeGroupPOST body);

    /// <summary>Gets a specific keyword type group.</summary>
    /// <remarks>Gets the keyword type group information for a specific keyword type group.</remarks>
    /// <param name="keywordTypeGroupId">The unique identifier of a keyword type group.</param>
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
    [Get("/onbase/administration/api/keyword-type-groups/{keywordTypeGroupId}")]
    Task<ApiResponse<KeywordTypeGroupModel>> KeywordTypeGroupsGet2(string keywordTypeGroupId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Replace keyword type group values for an existing keyword type group.</summary>
    /// <remarks>Replace keyword type group values for an existing keyword type group.</remarks>
    /// <param name="keywordTypeGroupId">The unique identifier of a keyword type group.</param>
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
    [Put("/onbase/administration/api/keyword-type-groups/{keywordTypeGroupId}")]
    Task<ApiResponse<KeywordTypeGroupModel>> KeywordTypeGroupsPut(string keywordTypeGroupId, [Body] KeywordTypeGroupModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Gets the list of keyword types on a specific keyword type group.</summary>
    /// <remarks>Gets the keyword type assignment information for a specific keyword type group.</remarks>
    /// <param name="keywordTypeGroupId">The unique identifier of a keyword type group.</param>
    /// <param name="keywordTypeId">The unique identifier of a keyword type.</param>
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
    [Get("/onbase/administration/api/keyword-types/keyword-type-groups")]
    Task<ApiResponse<KeywordTypeKeywordTypeGroupsCollectionRetrieval>> KeywordTypeGroupsGet3([Query] string keywordTypeGroupId, [Query] string keywordTypeId);

    /// <summary>Gets the list of document types, keyword type groups assignment information from provided parameter.</summary>
    /// <remarks>Gets the list of document types, keyword type groups assignment information from provided parameter.</remarks>
    /// <param name="keywordTypeGroupId">The unique identifier of a keyword type group.</param>
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
    [Get("/onbase/administration/api/document-types/keyword-type-groups")]
    Task<ApiResponse<DocumentTypeKeywordTypeGroupAssignmentCollection>> KeywordTypeGroupsGet4([Query] string keywordTypeGroupId, [Query] string documentTypeId);
}
