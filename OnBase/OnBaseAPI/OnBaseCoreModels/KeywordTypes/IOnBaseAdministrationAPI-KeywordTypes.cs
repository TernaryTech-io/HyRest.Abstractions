using Refit;

namespace HyRest.API.Administration;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Gets a list of keyword types.</summary>
    /// <remarks>Gets the identifier information for all keyword types.</remarks>
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
    [Get("/onbase/administration/api/keyword-types")]
    Task<ApiResponse<KeywordTypeCollectionModel>> KeywordTypesGet([Query(CollectionFormat.Multi)] IEnumerable<string> ids, [Query] int? limit, [Query] string lastValue, [Query] bool? descendingOrder);

    /// <summary>Creates a new keyword type.</summary>
    /// <remarks>Creates a new keyword type based on the model that is sent in the request.</remarks>
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
    [Post("/onbase/administration/api/keyword-types")]
    Task<ApiResponse<KeywordTypeModel>> KeywordTypesPost([Body] KeywordTypeModel body);

    /// <summary>Gets a specific keyword type.</summary>
    /// <remarks>Gets the keyword type information for a specific keyword type.</remarks>
    /// <param name="keywordTypeId">The unique identifier of a keyword type.</param>
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
    [Get("/onbase/administration/api/keyword-types/{keywordTypeId}")]
    Task<ApiResponse<KeywordTypeModel>> KeywordTypesGet2(string keywordTypeId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Replace an existing keyword type.</summary>
    /// <remarks>Replace the keyword type with the provided keyword type.</remarks>
    /// <param name="keywordTypeId">The unique identifier of a keyword type.</param>
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
    [Put("/onbase/administration/api/keyword-types/{keywordTypeId}")]
    Task<ApiResponse<KeywordTypeModel>> KeywordTypesPut(string keywordTypeId, [Body] KeywordTypeModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Updates an existing keyword type.</summary>
    /// <remarks>Updates the keyword type information for a specific keyword type.</remarks>
    /// <param name="keywordTypeId">The unique identifier of a keyword type.</param>
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
    [Headers("Accept: application/json", "Content-Type: application/json-patch+json")]
    [Patch("/onbase/administration/api/keyword-types/{keywordTypeId}")]
    Task<ApiResponse<KeywordTypeModel>> KeywordTypesPatch(string keywordTypeId, [Body] IEnumerable<PatchCommand> body);

    /// <summary>Replace the keyword types and keyword type groups on an existing document type.</summary>
    /// <remarks>Replace the keyword types on the document type with the provided keyword types.</remarks>
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
    [Put("/api/document-types/{documentTypeId}/keyword-types")]
    Task<DocumentTypeKeywordTypeAssignmentCollection> KeywordTypesPut2(string documentTypeId, [Body] IEnumerable<DocumentTypeKeywordTypeAssignment> body);

    /// <summary>Gets the list of keyword type document type assignments.</summary>
    /// <remarks>Gets the keyword type assignment information for the given document type or keyword type.</remarks>
    /// <param name="keywordTypeId">The unique identifier of a keyword type.</param>
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
    [Get("/api/document-types/keyword-types")]
    Task<DocumentTypeKeywordTypeAssignmentCollection> KeywordTypesGet4([Query] string keywordTypeId, [Query] string documentTypeId);

    /// <summary>Add or resequence keyword types on an existing keyword type group.</summary>
    /// <remarks>Add or resequence keyword types on an existing keyword type group.</remarks>
    /// <param name="keywordTypeGroupId">The unique identifier of a keyword type group.</param>
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
    [Headers("Accept: application:/json", "Content-Type: application/JSON")]
    [Put("/api/keyword-type-groups/{keywordTypeGroupId}/keyword-types")]
    Task<KeywordTypeKeywordTypeGroupCollectionAssignment> KeywordTypes(string keywordTypeGroupId, [Body] IEnumerable<KeywordTypeKeywordTypeGroupAssignment> body);
}
