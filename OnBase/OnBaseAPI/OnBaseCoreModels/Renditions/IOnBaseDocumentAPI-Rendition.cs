using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Gets a collection of document renditions.</summary>
    /// <remarks>
    /// Gets a collection of document renditions.
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
    [Get("/onbase/core/documents/{documentId}/revisions/{revisionId}/renditions")]
    Task<ApiResponse<RenditionCollectionModel>> GetRenditionCollectionForRevisionOfDocument(string documentId, string revisionId);

    /// <summary>Store rendition to the latest revision</summary>
    /// <remarks>
    /// Archives or Reindexes the document as a rendition to the latest revision.
    /// Keywords supplied with this request are merged with the existing keywords on the document. For Single Instance keywords, old values are replaced by the new values.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="body">body parameter</param>
    /// <returns>Document successfully archived as rendition to the given revision.</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>A reference to the uploaded file resource is not found,
    /// an invalid File Type Id is provided,
    /// the document already contains a rendition of the given File Type Id,
    /// the document type is not renditionable,
    /// invalid keywords are supplied or
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
    [Post("/onbase/core/documents/{documentId}/revisions/latest/renditions")]
    Task<ApiResponse<RenditionModel>> PostRenditionForLatestRevisionOfDocument(string documentId, [Body] RenditionArchivePropertiesModel body);

    /// <summary>Gets the metadata for a rendition of a revision.</summary>
    /// <remarks>
    /// Gets the metadata for a rendition of a revision.
    /// Use `latest` to retrieve the most recent revision.
    /// The `latest` revision will be available regardless of permission to view revisions.
    /// Use `default` to retrieve the default rendition.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="revisionId">The unique identifier of a document revision.</param>
    /// <param name="fileTypeId">The unique identifier of a file type.</param>
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
    [Headers("Accept: application/json")]
    [Get("/onbase/core/documents/{documentId}/revisions/{revisionId}/renditions/{fileTypeId}")]
    Task<ApiResponse<RenditionModel>> GetRenditionByIdForRevisionOfDocument(string documentId, string revisionId, string fileTypeId);
}
