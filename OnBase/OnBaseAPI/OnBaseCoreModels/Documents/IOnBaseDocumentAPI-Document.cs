using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Get a list of documents.</summary>
    /// <remarks>Get the list of documents with the given ids that the user has permission to view. An empty list is returned if the user does not have access to any documents or the documents cannot be found.</remarks>
    /// <param name="id">
    /// The unique identifiers of Document. Multiple values are supported and in a URL should be joined using the '&amp;' character.
    /// Ex: ?id=101&amp;id=102&amp;id=103.
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
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/core/documents")]
    Task<ApiResponse<DocumentCollectionModel>> GetDocumentCollection([Query(CollectionFormat.Multi)] IEnumerable<string> id);

    /// <summary>Archive the document.</summary>
    /// <remarks>Finishes the document upload by archiving the document into the given document type. Can also optionally specify the document date, comments if the document type is Revisable/Renditionable and also a boolean to indicate if this needs to be stored as a new document regardless of the document type settings. If fileTypeId is not specified, then the default file type for the document type will be used. Providing a keyword collection with a keyword guid is required. Takes a list of references to uploaded file resources.</remarks>
    /// <param name="body">body parameter</param>
    /// <returns>Document successfully archived.</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>300</term>
    /// <description>Document(s) are found for which the new document can be added as Revision/Rendition.</description>
    /// </item>
    /// <item>
    /// <term>400</term>
    /// <description>Document Type Id and/or File Type Id is invalid,
    /// Keyword information is invalid, unique handle(s)
    /// are invalid, no comments are provided when the document type is set to "Force Comments",
    /// or an invalid archival option has been provided for Revisable/Renditionable document type.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>User does not have rights to create document or when the user is trying to add read-only and hidden keywords without \'Access Restricted Keywords\' privilege.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
    [Post("/onbase/core/documents")]
    Task<ApiResponse<DocumentsPostResponse>> PostDocument([Body] DocumentArchivePropertiesModel body);

    /// <summary>Gets document metadata.</summary>
    /// <remarks>Gets document metadata.</remarks>
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
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/core/documents/{documentId}")]
    Task<ApiResponse<DocumentModel>> GetDocumentById(string documentId);

    /// <summary>Deletes a document.</summary>
    /// <remarks>Deletes a document.</remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
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
    /// <description>Response when the user does not have delete rights to the specified document,
    /// retention criteria has not been met, or the resource is checked out.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have view rights to the specified document.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/problem+json")]
    [Delete("/onbase/core/documents/{documentId}")]
    Task<IApiResponse> DeleteDocumentById(string documentId);

    /// <summary>Updates document metadata.</summary>
    /// <remarks>Updates document metadata.</remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
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
    /// <description>Response when the user sends invalid data to modify document metadata.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have rights to modify document metadata.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
    [Patch("/onbase/core/documents/{documentId}")]
    Task<ApiResponse<DocumentModel>> PatchDocumentById(string documentId, [Body] DocumentPatchRequestModel body);

    /// <summary>Reindex document.</summary>
    /// <remarks>
    /// Reindexes a document by first checking if there is a match for rendition or revisions
    /// and then applies the reindex if there are no matches, the user verifies that it will not
    /// store as a new revision or rendition, or if there is no document type change.
    /// The keywordCollection requires a keyword GUID. For reindexing, this must come from the source document (/document/{id}/keywords) rather than the target document type.
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
    /// <term>300</term>
    /// <description>Document(s) are found for which the new document can be added as Revision/Rendition.</description>
    /// </item>
    /// <item>
    /// <term>400</term>
    /// <description>Response when the user sends invalid data to reindex.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have rights to reindex.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
    [Put("/onbase/core/documents/{documentId}")]
    Task<ApiResponse<ReindexPutResponseModel>> PutDocumentById(string documentId, [Body] DocumentReindexPropertiesModel body);

    /// <summary>Get document content for a rendition of a revision.</summary>
    /// <remarks>
    /// To retrieve the default rendition of the latest revision,
    /// use 'default' for the fileTypeId and 'latest' for the revisionId.
    /// 
    /// The `latest` revision will be available regardless of permission to view revisions.
    /// 
    /// Consumers can `GET` the content resource by supplying the required
    /// parameters.  A response will be returned
    /// based on the result of Content Negotiation. For more detailed information
    /// regarding how the response content type will be determined, please review
    /// the Document Retrieval section of the Programmers Guide.
    /// 
    /// The `pages` query parameter can be used to retrieve a single page of the document.
    /// When the `pages` query parameter is provided, the total page count for the document
    /// will be included on the response in the `Hyland-Item-Count` header.
    /// The Range header can be used to retrieve a specific byte range.
    /// 
    /// The `Hyland-Item-Count` header will only be included if the `pages` query parameter is used.
    /// 
    /// When the `pages` query parameter and 'Range' request header is omitted, document content is returned
    /// in its entirety as a single file with a 200 OK Status code.
    /// 
    /// The `context` query parameter can be used to provide additional context of what the
    /// client is retrieving the page data for. This will perform client privilege checks and
    /// log more appropriate messages to the document history indicating what action the client
    /// will be performing.
    /// 
    /// When retrieving a byte range of a document, the response will include an ETag
    /// representing the specific document that the byte range is from. When retrieving
    /// a second byte range from the same document, this ETag should be included in the
    /// request header If-Match. This will ensure that the second byte range is taken
    /// from the same exact document as the first. If this original document does not
    /// exist anymore, or if it has been changed in the interim, a status code of 412
    /// Precondition Failed will be returned.
    /// 
    /// When requesting a byte range 206 Partial Content response will be returned.
    /// 
    /// The `height` and `width` query parameters can be used to retrieve a smaller scale version
    /// of the resource with the provided dimensions, in pixels. The `fit` query parameter can also be
    /// included to define how the scaling should occur. When the `fit` query parameter is not provided
    /// the default value of `Both` is used.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="revisionId">The unique identifier of a document revision.</param>
    /// <param name="fileTypeId">The unique identifier of a file type.</param>
    /// <param name="pages">
    /// The page to be retrieved. Currently only a single
    /// page number is supported. If a valid page number is provided,
    /// the `Hyland-Item-Count` custom header will be included on the response.
    /// 
    /// If the page number does not exist or the value provided is not a single
    /// page number, a 404 Not Found will be returned.
    /// 
    /// Page number is one-based.
    /// </param>
    /// <param name="context">
    /// The context for which the document content is being retrieved. If retrieving the document
    /// for client purposes, it is recommended to use the context to verify correct privileges
    /// and log the most appropriate message in document history.
    /// </param>
    /// <param name="height">The height of the resource in pixels.</param>
    /// <param name="width">The width of the resource in pixels.</param>
    /// <param name="fit">Options for scaling the resource to the provided dimensions.</param>
    /// <param name="accept">
    /// The  ;a
    /// href="https://tools.ietf.org/html/rfc7231#section-5.3.2"&gt;Accept ;/a&gt;
    /// header field can be used by consumers to specify response media types
    /// that are preferred.
    /// 
    /// Upon receiving this header the server will use  ;a
    /// href="https://tools.ietf.org/html/rfc7231#section-3.4.1"&gt;Proactive
    /// Content Negotiation ;/a&gt; to determine the "best guess" format for the
    /// consumer.
    /// 
    /// In cases where the underlying resource can not be returned as a
    /// requested format, the server may make a determination of which format
    /// of the content will be returned.
    /// 
    /// In cases where the Accept header is omitted or has the value `*/*`, the
    /// server will make a determination of which format of the content will
    /// be returned.
    /// 
    /// Consumers should inspect the `Content-Type` response header to determine
    /// the actual format of the content returned.
    /// 
    /// Review documentation for the specific end point for more detailed information.
    /// on Content Negotiation or how the Accept header.
    /// </param>
    /// <param name="if_Match">
    /// The  ;a href="https://tools.ietf.org/html/rfc7232#section-3.1"&gt;If-Match ;/a&gt;
    /// header field makes the request method conditional on
    /// the recipient origin server either having at least one current
    /// representation of the target resource, when the field-value is "*",
    /// or having a current representation of the target resource that has an
    /// entity-tag matching a member of the list of entity-tags provided in
    /// the field-value.
    /// </param>
    /// <param name="range">
    /// The  ;a href="https://tools.ietf.org/html/rfc7233#section-3.1"&gt;Range ;/a&gt;
    /// header field on a request modifies the method semantics to request
    /// transfer of only one or more subranges of the selected representation
    /// data, rather than the entire selected representation data.
    /// 
    /// The Range unit `bytes` is supported to represent byte ranges of the
    /// page or document of the specific rendition's content.
    /// 
    /// For the cases where the Range header is omitted, the full document or page will be
    /// returned.
    /// </param>
    /// <returns>Response containing document content.</returns>
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
    /// <description>Response for content when the document does not exist a requested
    /// page does not exist, or the user does not have rights to access.</description>
    /// </item>
    /// <item>
    /// <term>406</term>
    /// <description>Response for when a response matching the list of acceptable values
    /// defined in `Accept` cannot be served.</description>
    /// </item>
    /// <item>
    /// <term>412</term>
    /// <description>Response for when a user is attempting to retrieve a byte range for
    /// specific document and that document no longer exists or has been changed.</description>
    /// </item>
    /// <item>
    /// <term>416</term>
    /// <description>Response for content when the specified range is not valid for the
    /// content or when the specified range requested is for more than one
    /// part.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: */*, application/problem+json")]
    [Get("/onbase/core/documents/{documentId}/revisions/{revisionId}/renditions/{fileTypeId}/content")]
    Task<ApiResponse<Stream>> GetContentForRenditionOfRevisionOfDocument(string documentId, string revisionId, string fileTypeId, [Query] string? pages, [Query] Context? context, [Query] int? height, [Query] int? width, [Query] Fit? fit, [Header("Accept")] string? accept, [Header("If-Match")] string? if_Match, [Header("Range")] string? range);

    /// <summary>Preview document content.</summary>
    /// <remarks>
    /// Consumers can make a `HEAD` request to see the response
    /// headers without the response body. This allows previewing
    /// the result of Content Negotiation with Content-Type,
    /// and Hyland-Item-Count headers.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="revisionId">The unique identifier of a document revision.</param>
    /// <param name="fileTypeId">The unique identifier of a file type.</param>
    /// <param name="pages">
    /// The page to be retrieved. Currently only a single
    /// page number is supported. If a valid page number is provided,
    /// the `Hyland-Item-Count` custom header will be included on the response.
    /// 
    /// If the page number does not exist or the value provided is not a single
    /// page number, a 404 Not Found will be returned.
    /// 
    /// Page number is one-based.
    /// </param>
    /// <param name="context">
    /// The context for which the document content is being retrieved. If retrieving the document
    /// for client purposes, it is recommended to use the context to verify correct privileges
    /// and log the most appropriate message in document history.
    /// </param>
    /// <param name="height">The height of the resource in pixels.</param>
    /// <param name="width">The width of the resource in pixels.</param>
    /// <param name="fit">Options for scaling the resource to the provided dimensions.</param>
    /// <param name="accept">
    /// The  ;a
    /// href="https://tools.ietf.org/html/rfc7231#section-5.3.2"&gt;Accept ;/a&gt;
    /// header field can be used by consumers to specify response media types
    /// that are preferred.
    /// 
    /// Upon receiving this header the server will use  ;a
    /// href="https://tools.ietf.org/html/rfc7231#section-3.4.1"&gt;Proactive
    /// Content Negotiation ;/a&gt; to determine the "best guess" format for the
    /// consumer.
    /// 
    /// In cases where the underlying resource can not be returned as a
    /// requested format, the server may make a determination of which format
    /// of the content will be returned.
    /// 
    /// In cases where the Accept header is omitted or has the value `*/*`, the
    /// server will make a determination of which format of the content will
    /// be returned.
    /// 
    /// Consumers should inspect the `Content-Type` response header to determine
    /// the actual format of the content returned.
    /// 
    /// Review documentation for the specific end point for more detailed information.
    /// on Content Negotiation or how the Accept header.
    /// </param>
    /// <param name="if_Match">
    /// The  ;a href="https://tools.ietf.org/html/rfc7232#section-3.1"&gt;If-Match ;/a&gt;
    /// header field makes the request method conditional on
    /// the recipient origin server either having at least one current
    /// representation of the target resource, when the field-value is "*",
    /// or having a current representation of the target resource that has an
    /// entity-tag matching a member of the list of entity-tags provided in
    /// the field-value.
    /// </param>
    /// <param name="range">
    /// The  ;a href="https://tools.ietf.org/html/rfc7233#section-3.1"&gt;Range ;/a&gt;
    /// header field on a request modifies the method semantics to request
    /// transfer of only one or more subranges of the selected representation
    /// data, rather than the entire selected representation data.
    /// 
    /// The Range unit `bytes` is supported to represent byte ranges of the
    /// page or document of the specific rendition's content.
    /// 
    /// For the cases where the Range header is omitted, the full document or page will be
    /// returned.
    /// </param>
    /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
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
    /// <description>Response for content when the document does not exist, a requested
    /// page does not exist, or the user does not have rights to access.</description>
    /// </item>
    /// <item>
    /// <term>406</term>
    /// <description>Response for when a response matching the list of acceptable values
    /// defined in `Accept` cannot be served.</description>
    /// </item>
    /// <item>
    /// <term>412</term>
    /// <description>Response for when a user is attempting to retrieve a byte range for
    /// specific document and that document no longer exists or has been changed.</description>
    /// </item>
    /// <item>
    /// <term>416</term>
    /// <description>Response for content when the specified range is not valid for the
    /// content or when the specified range requested is for more than one
    /// part.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/problem+json")]
    [Head("/onbase/core/documents/{documentId}/revisions/{revisionId}/renditions/{fileTypeId}/content")]
    Task<IApiResponse> HeadContentForRenditionOfRevisionOfDocument(string documentId, string revisionId, string fileTypeId, [Query] string pages, [Query] Context? context, [Query] int? height, [Query] int? width, [Query] Fit? fit, [Header("Accept")] string accept, [Header("If-Match")] string if_Match, [Header("Range")] string range);

    /// <summary>Prepare the staging area to start the upload process.</summary>
    /// <remarks>
    /// Prepares the staging area to start the upload.
    /// Returns a reference to the file being uploaded.
    /// </remarks>
    /// <param name="body">body parameter</param>
    /// <returns>Upload staging area created.</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>Invalid or missing file metadata. Such as missing extension
    /// or file or file part size that is less than or equal to zero.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
    [Post("/onbase/core/documents/uploads")]
    Task<ApiResponse<UploadsPostResponseModel>> PostFileUploadMetadata([Body] UploadPostRequestModel body);

    /// <summary>Upload file data.</summary>
    /// <remarks>
    /// Upload file to a location identified by the unique file reference.
    /// This end-point can be called multiple times, to upload multiple files.
    /// Each file will have it's own unique reference.
    /// When uploading a single file as chunks, upload it to the same file reference.
    /// </remarks>
    /// <param name="uploadId">The unique reference to the file being uploaded</param>
    /// <param name="filePart">part number of the file to upload. Part numbers are sequential and start at 1.</param>
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
    /// <description>File part number is provided in incorrect format</description>
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
    [Headers("Accept: application/problem+json", "Content-Type: application/octet-stream")]
    [Put("/onbase/core/documents/uploads/{uploadId}")]
    Task<IApiResponse> PutFileUploadById(string uploadId, [Query] int filePart, [Body] ByteArrayContent body);

    /// <summary>Delete file corresponding to the given uploadId</summary>
    /// <remarks>
    /// Deletes an uploaded file corresponding to the given uploadId.
    /// This can be used to cancel the upload.
    /// </remarks>
    /// <param name="uploadId">The unique reference to the file being uploaded</param>
    /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
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
    /// </list>
    /// </exception>
    [Delete("/onbase/core/documents/uploads/{uploadId}")]
    Task<IApiResponse> DeleteFileUploadById(string uploadId);
}
