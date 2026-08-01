using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Gets a collection of document revisions.</summary>
    /// <remarks>Gets collection of document revisions.</remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
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
    [Get("/onbase/core/documents/{documentId}/revisions")]
    Task<ApiResponse<RevisionCollectionModel>> GetRevisionCollectionForDocument(string documentId);

    /// <summary>Store a new revision</summary>
    /// <remarks>
    /// Archives or Reindexes the document as a latest revision to the current document.
    /// Keywords supplied with this request are merged with the existing keywords on the document. For Single Instance keywords, old values are replaced by the new values.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="body">body parameter</param>
    /// <returns>Revision successfully stored.</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>A reference to an uploaded file resource is not found, invalid File
    /// Type Id is provided, the document type is not revisable, invalid keywords are supplied or
    /// a comment is not supplied when \'Force Comments\' is set to true.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have rights to create or reindex a document, when the user is trying to add/modify keywords with an invalid Keyword Guid, or when the user is trying to add/modify read-only keywords without `Access Restricted Keywords`.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
    [Post("/onbase/core/documents/{documentId}/revisions")]
    Task<ApiResponse<RevisionModel>> PostRevisionForDocument(string documentId, [Body] RevisionArchivePropertiesModel body);

    /// <summary>Gets the metadata for a revision.</summary>
    /// <remarks>
    /// Gets the metadata for a revision.
    /// Use `latest` to retrieve the most recent revision.
    /// The `latest` revision will be available regardless of permission to view revisions.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="revisionId">The unique identifier of a document revision.</param>
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
    [Get("/onbase/core/documents/{documentId}/revisions/{revisionId}")]
    Task<ApiResponse<RevisionModel>> GetRevisionByIdForDocument(string documentId, string revisionId);
}
