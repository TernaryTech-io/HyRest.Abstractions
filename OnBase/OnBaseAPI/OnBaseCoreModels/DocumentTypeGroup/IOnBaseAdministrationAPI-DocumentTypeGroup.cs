using Refit;

namespace HyRest.API.Administration;
public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Gets a specific document type group.</summary>
    /// <remarks>Gets the document type group information for a specific document type group.</remarks>
    /// <param name="documentTypeGroupId">The unique identifier of a document type group.</param>
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
    [Get("onbase/administration/api/document-type-groups/{documentTypeGroupId}")]
    Task<ApiResponse<DocumentTypeGroupModel>> DocumentTypeGroupsGet2(string documentTypeGroupId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Updates a specific document type group.</summary>
    /// <remarks>Updates the document type group information for a specific document type group.</remarks>
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
    [Patch("/onbase/administration/api/document-type-groups/{documentTypeGroupId}")]
    Task<ApiResponse<DocumentTypeGroupModel>> DocumentTypeGroupsPatch(string documentTypeGroupId, [Body] IEnumerable<PatchCommand> body);

    /// <summary>Replace an existing document type group.</summary>
    /// <remarks>Replace the document type group with the provided document type group.</remarks>
    /// <param name="documentTypeGroupId">The unique identifier of a document type group.</param>
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
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/JSON")]
    [Put("onbase/administration/api/document-type-groups/{documentTypeGroupId}")]
    Task<ApiResponse<DocumentTypeGroupModel>> DocumentTypeGroupsPut(string documentTypeGroupId, [Body] DocumentTypeGroupModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);


    /// <summary>Gets a list of document type groups.</summary>
    /// <remarks>Gets the identifier information for all document type groups.</remarks>
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
    [Get("/onbase/administration/api/document-type-groups")]
    Task<ApiResponse<DocumentTypeGroupCollectionModel>> DocumentTypeGroupsGet([Query(CollectionFormat.Multi)] IEnumerable<string> ids, [Query] int? limit, [Query] string lastValue, [Query] bool? descendingOrder);

    /// <summary>Creates a new document type group.</summary>
    /// <remarks>Creates a new document type group based on the model that is sent in the request.</remarks>
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
    [Post("/onbase/administration/api/document-type-groups")]
    Task<ApiResponse<DocumentTypeGroupModel>> DocumentTypeGroupsPost([Body] DocumentTypeGroupPOST body);
}
