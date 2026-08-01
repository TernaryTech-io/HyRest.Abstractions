using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Get a list of document types.</summary>
    /// <remarks>Get all the document types the logged in user has permissions to view.</remarks>
    /// <param name="id">The unique identifiers of document types.This parameter cannot be used in conjunction with the `systemName` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?id=102&amp;id=103</param>
    /// <param name="systemName">The unique configured system names of document types. This parameter cannot be used in conjunction with the `id` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?systemName=docType1&amp;systemName=docType2</param>
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
    [Get("/onbase/core/document-types")]
    Task<ApiResponse<DocumentTypeCollectionModel>> GetDocumentTypeCollection([Query(CollectionFormat.Multi)] IEnumerable<string>? id = default, [Query(CollectionFormat.Multi)] IEnumerable<string>? systemName = default, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Get a document type</summary>
    /// <remarks>Gets the document type with the associated id.</remarks>
    /// <param name="documentTypeId">The unique identifier of a document type.</param>
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
    [Get("/onbase/core/document-types/{documentTypeId}")]
    Task<ApiResponse<DocumentTypeModel>> GetDocumentTypeById(string documentTypeId, [Header("Accept-Language")] string accept_Language = "en-US");
}