using Refit;

namespace HyRest.CaseManagement;

public partial interface IOnBaseWorkViewAPI : IHylandRestAPI
{
    /// <summary>Gets the configuration information for the specified Data Set</summary>
    /// <param name="dataSetId">Id of a Data Set.</param>
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
    [Get("/onbase/workview/datasets/{dataSetId}")]
    Task<ApiResponse<DataSetModel>> DatasetsGet(string dataSetId);

    /// <summary>Gets the values for the specified Data Set with the optional parent value specified.</summary>
    /// <param name="dataSetId">Id of a Data Set.</param>
    /// <param name="parentValue">Parent value for the Data Set.</param>
    /// <param name="accept_Language">
    /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
    /// header field can be used by user agents to
    /// indicate the set of natural languages that are preferred in the
    /// response.  Language tags are defined in RFC 5646. If none of the
    /// languages given are supported, a default language will be returned.
    /// </param>
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
    [Get("/onbase/workview/datasets/{dataSetId}/values")]
    Task<ApiResponse<DataSetValueCollectionModel>> Values(string dataSetId, [Query] string parentValue, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Creates the query for the given Data Set model and returns the location of the query results.</summary>
    /// <param name="dataSetId">Id of a Data Set.</param>
    /// <param name="accept_Language">
    /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
    /// header field can be used by user agents to
    /// indicate the set of natural languages that are preferred in the
    /// response.  Language tags are defined in RFC 5646. If none of the
    /// languages given are supported, a default language will be returned.
    /// </param>
    /// <param name="hyland_Include_Item_Count">Used to denote that the client is requesting item count.</param>
    /// <param name="body">body parameter</param>
    /// <returns>Query Created</returns>
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
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Post("/onbase/workview/datasets/{dataSetId}/filter-queries")]
    Task<ApiResponse<PostQueryResponseModel>> FilterQueriesPost(string dataSetId, [Body] FilterDataSetModel body, [Header("Accept-Language")] string accept_Language, [Header("Hyland-Include-Item-Count")] bool? hyland_Include_Item_Count);

    /// <summary>Gets the Data Set values from the specified Data Set query.</summary>
    /// <param name="dataSetId">Id of a Data Set.</param>
    /// <param name="queryId">Identifier for a query.</param>
    /// <param name="accept_Language">
    /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
    /// header field can be used by user agents to
    /// indicate the set of natural languages that are preferred in the
    /// response.  Language tags are defined in RFC 5646. If none of the
    /// languages given are supported, a default language will be returned.
    /// </param>
    /// <param name="hyland_Include_Item_Count">Used to denote that the client is requesting item count.</param>
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
    [Get("/onbase/workview/datasets/{dataSetId}/filter-queries/{queryId}")]
    Task<ApiResponse<DataSetValueCollectionModel>> FilterQueriesGet(string dataSetId, string queryId, [Header("Accept-Language")] string accept_Language, [Header("Hyland-Include-Item-Count")] bool? hyland_Include_Item_Count);

}