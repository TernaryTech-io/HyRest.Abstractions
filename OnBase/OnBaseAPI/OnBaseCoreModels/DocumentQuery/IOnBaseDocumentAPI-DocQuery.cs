using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Submits a document query, with the provided search constraints.</summary>
    /// <remarks>
    /// Submits a document query, with the provided search constraints.
    /// 
    /// If `Hyland-Include-Item-Count` header is set to true, the estimated number
    /// of documents that will be returned by the query will be included on the
    /// response in the `Hyland-Item-Count` header.
    /// Estimated because the number may vary in accuracy based on how the
    /// query is formed, any filtering that takes places after the query is run, and
    /// if there are any external constraints.
    /// </remarks>
    /// <param name="hyland_Include_Item_Count">
    /// The Hyland-Include-Item-Count custom header field can be used by user agents
    /// to indicate that the item count should be included in the response.
    /// </param>
    /// <param name="body">body parameter</param>
    /// <returns>
    /// Query created. The location of the results of the query results
    /// is given in the Location header.
    /// </returns>
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
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Post("/onbase/core/documents/queries")]
    Task<ApiResponse<QueriesPostResponseModel>> PostDocumentQuery([Body] QueryInformationModel body, [Header("Hyland-Include-Item-Count")] bool? hyland_Include_Item_Count);

    /// <summary>Returns the documents results of a query.</summary>
    /// <remarks>Returns the documents results of a query.</remarks>
    /// <param name="queryId">The unique identifier of a query.</param>
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
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/core/documents/queries/{queryId}/results")]
    Task<ApiResponse<QueryResultsModel>> GetResultCollectionForDocumentQuery(string queryId);

    /// <summary>Returns the display column configuration of a query.</summary>
    /// <remarks>Returns the display column configuration of a query.</remarks>
    /// <param name="queryId">The unique identifier of a query.</param>
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
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/core/documents/queries/{queryId}/columns")]
    Task<ApiResponse<DisplayColumnConfigurationCollectionModel>> GetColumnCollectionForDocumentQuery(string queryId);
}
