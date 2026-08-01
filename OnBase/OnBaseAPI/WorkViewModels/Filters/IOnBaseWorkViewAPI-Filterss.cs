using Refit;

namespace HyRest.CaseManagement;

public partial interface IOnBaseWorkViewAPI : IHylandRestAPI
{
    /// <summary>Gets the configuration information for the specified Filter.</summary>
    /// <param name="filterId">Id of a Filter.</param>
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
    [Get("/onbase/workview/filters/{filterId}")]
    Task<ApiResponse<FilterTypeModel>> FiltersGet2(string filterId, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Creates the query given a Filter or dynamic filtering model and returns the location of the query results.</summary>
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
    [Post("/v2/object-queries")]
    Task<ApiResponse<PostQueryResponseModel>> ObjectQueriesPost2([Body] DynamicFilterModelV2 body, [Header("Accept-Language")] string accept_Language, [Header("Hyland-Include-Item-Count")] bool? hyland_Include_Item_Count);

    /// <summary>Gets the results for the query specified.</summary>
    /// <param name="accept_Language">
    /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
    /// header field can be used by user agents to
    /// indicate the set of natural languages that are preferred in the
    /// response.  Language tags are defined in RFC 5646. If none of the
    /// languages given are supported, a default language will be returned.
    /// </param>
    /// <param name="hyland_Include_Item_Count">Used to denote that the client is requesting item count.</param>
    /// <param name="queryId">Identifier for a query.</param>
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
    [Get("/v2/object-queries/{queryId}")]
    Task<ApiResponse<FilterResultCollectionModel>> ObjectQueriesGet2(string queryId, [Header("Accept-Language")] string accept_Language, [Header("Hyland-Include-Item-Count")] bool? hyland_Include_Item_Count);

}