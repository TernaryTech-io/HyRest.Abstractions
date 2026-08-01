using Refit;

namespace HyRest.API;

public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Get a list of document type groups.</summary>
    /// <remarks>Get all the document type groups the logged in user has permissions to view.</remarks>
    /// <param name="id">The unique identifiers of document type groups. This parameter cannot be used in conjunction with the `systemName` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?id=102&amp;id=103</param>
    /// <param name="systemName">The unique system names of document type groups. This parameter cannot be used in conjunction with the `id` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?systemName=docTypeGroup1&amp;systemName=docTypeGroup2</param>
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
    /// <term>400</term>
    /// <description>Response when the user tries to combine id and systemName query parameters.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/core/document-type-groups")]
    Task<ApiResponse<DocumentTypeGroupCollectionModel>> GetDocumentTypeGroupCollection([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Get a document type group</summary>
    /// <remarks>Gets the document type group with the associated id.</remarks>
    /// <param name="documentTypeGroupId">The unique identifier of a document type group</param>
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
    [Get("/onbase/core/document-type-groups/{documentTypeGroupId}")]
    Task<ApiResponse<DocumentTypeGroupModel>> GetDocumentTypeGroupById(string documentTypeGroupId, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Gets the associated document types for a document type group</summary>
    /// <remarks>Gets the associated document type collection for the document type group</remarks>
    /// <param name="documentTypeGroupId">The unique identifier of a document type group</param>
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
    [Get("/onbase/core/document-type-groups/{documentTypeGroupId}/document-types")]
    Task<ApiResponse<DocumentTypeCollectionModel>> GetDocumentTypeCollectionForDocumentTypeGroup(string documentTypeGroupId);

}