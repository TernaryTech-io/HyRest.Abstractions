using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Gets default keywords for a new document.</summary>
    /// <remarks>
    /// Gets the default keyword values for a document type grouped by keyword type group and
    /// keyword type.
    /// </remarks>
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
    /// <description>Response when the user does not have the document privilege `Create Document\' or
    /// document privilege \'ReIndex Document\'</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json")]
    [Get("/onbase/core/document-types/{documentTypeId}/default-keywords")]
    Task<ApiResponse<KeywordCollectionModel>> GetDefaultKeywordCollectionForDocumentType(string documentTypeId, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Gets keywords for a document.</summary>
    /// <remarks>
    /// Gets the keyword values for a document grouped by keyword type group and
    /// keyword type.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="unmask">
    /// Value determining whether to unmask security masked Keywords. If true and user does not
    /// have Access Security Masked Keywords privilege, security masked Keywords will stay masked.
    /// Setting unmask to false is equivalent to omitting the query string parameter.
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
    /// <term>403</term>
    /// <description>Response when the user does not have the document privilege `View Keywords\'</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json")]
    [Get("/onbase/core/documents/{documentId}/keywords")]
    Task<ApiResponse<KeywordCollectionModel>> GetKeywordCollectionForDocument(string documentId, [Query] bool? unmask);

    /// <summary>Sets all keyword values for an indexed document.</summary>
    /// <remarks>
    /// Sets all keyword values for an indexed document. Existing values will be
    /// replaced with the supplied list of keyword values grouped by keyword type
    /// group and keyword type.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
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
    /// <description>Response when the user sends a empty request body,
    /// invalid keyword syntax, invalid keyword data, or missing restricted keyword guid.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have the document privilege `Modify Keywords\',
    /// the document is locked by Records Management or Medical records.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/problem+json", "Content-Type: application/json")]
    [Put("/onbase/core/documents/{documentId}/keywords")]
    Task<IApiResponse> PutKeywordCollectionForDocument(string documentId, [Body] KeywordCollectionModel body);
}
