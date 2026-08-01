using Refit;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Gets the system information for insight discovery.</summary>
    /// <remarks>Gets the system information required for communicating with hyland insight discovery.</remarks>
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
    [Get("/api/insight-discovery/system-info")]
    Task<InsightDiscoverySysteminformationModel> SystemInfoGet();

    /// <summary>Creates the system information for insight discovery.</summary>
    /// <remarks>Creates the system information required for communicating with insight discovery.</remarks>
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
    [Post("/api/insight-discovery/system-info")]
    Task<InsightDiscoverySysteminformationModel> SystemInfoPost([Body] InsightDiscoverySysteminformationModel body);

    /// <summary>Replaces current system information for insight discovery.</summary>
    /// <remarks>Replaces current system information required for communicating with insight discovery.</remarks>
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
    [Put("/api/insight-discovery/system-info")]
    Task<InsightDiscoverySysteminformationModel> SystemInfoPut([Body] InsightDiscoverySysteminformationModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Gets specifc Insight Discovery collection to relate to documents types by Insight Connector</summary>
    /// <remarks>Gets the collection of documents types to be processed by insight discovery.</remarks>
    /// <param name="insightCollectionId">The unique identifier of the insight collection to relate to document types</param>
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
    [Get("/api/insight-discovery/collections/{insightCollectionId}")]
    Task<InsightDiscoveryCollection> CollectionsGet(string insightCollectionId);

    /// <summary>Update an specific Insight Discovery Collection.</summary>
    /// <remarks>Update an specific Insight Discovery collection to relate to documents types by Insight Connector</remarks>
    /// <param name="insightCollectionId">The unique identifier of the insight collection to relate to document types</param>
    /// <param name="x_Custom_Content_Hash">The hash value of associated primary config object</param>
    /// <param name="body">The updated hyland insight discovery collection</param>
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
    [Put("/api/insight-discovery/collections/{insightCollectionId}")]
    Task<InsightDiscoveryCollection> CollectionsPut(string insightCollectionId, [Body] InsightDiscoveryCollection body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Gets a list of insight discovery collections to relate to documents types by Insight Connector</summary>
    /// <remarks>Gets a list of collections of documents types to be processed by insight discovery.</remarks>
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
    [Get("/api/insight-discovery/collections")]
    Task<InsightDiscoveryCollectionCollection> CollectionsGet2();

    /// <summary>Creates an Insight Discovery Collection.</summary>
    /// <remarks>Creates an Insight Discovery Collection.</remarks>
    /// <param name="body">The updated insight discovery collection</param>
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
    [Post("/api/insight-discovery/collections")]
    Task<InsightDiscoveryCollection> CollectionsPost([Body] InsightDiscoveryCollection body);

    /// <summary>Gets the list of document types, insight collection assignments with document information from provided parameter.</summary>
    /// <remarks>Gets the list of document types, insight collection assignments with document information from provided parameter.</remarks>
    /// <param name="insightCollectionId">The unique identifier of the insight collection to relate to document types</param>
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
    [Get("/api/insight-discovery/collections/document-types")]
    Task<InsightCollectionDocumentTypeAssignmentCollection> DocumentTypesGet3([Query] string insightCollectionId, [Query] string documentTypeId);

    /// <summary>Replaces the document types, insight collection assignments on specified object.</summary>
    /// <remarks>Replaces the document types, insight collection assignments on specified object.</remarks>
    /// <param name="insightCollectionId">The unique identifier of the insight collection to relate to document types</param>
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
    [Headers("Accept: application/json", "Content-Type: application/JSON")]
    [Put("/api/insight-discovery/collections/document-types")]
    Task<InsightCollectionDocumentTypeAssignmentCollection> DocumentTypesPut2([Query] string insightCollectionId, [Query] string documentTypeId, [Body] IEnumerable<InsightCollectionDocumentTypeAssignment> body);

    /// <summary>Gets the list of keyword types, insight collection assignments information from provided parameter.</summary>
    /// <remarks>Gets the list of keyword types, insight collection assignments information from provided parameter.</remarks>
    /// <param name="insightCollectionId">The unique identifier of the insight collection to relate to document types</param>
    /// <param name="documentTypeId">The unique identifier of a document type.</param>
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
    [Get("/api/insight-discovery/collections/keyword-types")]
    Task<InsightCollectionKeywordTypeAssignmentCollection> KeywordTypesGet5([Query] string insightCollectionId, [Query] string documentTypeId, [Query] string keywordTypeId);

    /// <summary>Replaces the keyword types, insight collection assignments on specified object.</summary>
    /// <remarks>Replaces the keyword types, insight collection assignments on specified object.</remarks>
    /// <param name="insightCollectionId">The unique identifier of the insight collection to relate to document types</param>
    /// <param name="documentTypeId">The unique identifier of a document type.</param>
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
    [Headers("Accept: application/json", "Content-Type: application/JSON")]
    [Put("/api/insight-discovery/collections/keyword-types")]
    Task<InsightCollectionKeywordTypeAssignmentCollection> KeywordTypesPut3([Query] string insightCollectionId, [Query] string documentTypeId, [Query] string keywordTypeId, [Body] IEnumerable<InsightCollectionKeywordTypeAssignment> body);

    /// <summary>Gets the list of file types, insight collection assignments information from provided parameter.</summary>
    /// <remarks>Gets the list of file types, insight collection assignments information from provided parameter.</remarks>
    /// <param name="insightCollectionId">The unique identifier of the insight collection to relate to document types</param>
    /// <param name="documentTypeId">The unique identifier of a document type.</param>
    /// <param name="fileTypeId">The unique identifier of the file type.</param>
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
    [Get("/api/insight-discovery/collections/file-types")]
    Task<InsightCollectionFileTypesAssignmentCollection> FileTypesGet3([Query] string insightCollectionId, [Query] string documentTypeId, [Query] string fileTypeId);

    /// <summary>Replaces the file types, insight collection assignments on specified object.</summary>
    /// <remarks>Replaces the file types, insight collection assignments on specified object.</remarks>
    /// <param name="insightCollectionId">The unique identifier of the insight collection to relate to document types</param>
    /// <param name="documentTypeId">The unique identifier of a document type.</param>
    /// <param name="fileTypeId">The unique identifier of the file type.</param>
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
    [Headers("Accept: application/json", "Content-Type: application/JSON")]
    [Put("/api/insight-discovery/collections/file-types")]
    Task<InsightCollectionFileTypesAssignmentCollection> FileTypesPut2([Query] string insightCollectionId, [Query] string documentTypeId, [Query] string fileTypeId, [Body] IEnumerable<InsightCollectionFileTypesAssignment> body);


}