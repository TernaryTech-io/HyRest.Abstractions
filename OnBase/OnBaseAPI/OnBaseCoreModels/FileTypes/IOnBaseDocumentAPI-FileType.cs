using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Get file type metadata for all file types.</summary>
    /// <remarks>
    /// Get the file type metadata for all file types in
    /// the system.
    /// </remarks>
    /// <param name="id">The unique identifiers of file types. This parameter cannot be used in conjunction with the `systemName` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?id=2&amp;id=16</param>
    /// <param name="systemName">The unique configured system names of file types. This parameter cannot be used in conjunction with the `id` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?systemName=Image File Format&amp;systemName=PDF</param>
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
    [Get("/onbase/core/file-types")]
    Task<ApiResponse<FileTypeCollectionModel>> GetFileTypeCollection([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Get file type metadata.</summary>
    /// <remarks>Get file type metadata for the specified file type id.</remarks>
    /// <param name="fileTypeId">The unique identifier of a file type.</param>
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
    [Get("/onbase/core/file-types/{fileTypeId}")]
    Task<ApiResponse<FileTypeModel>> GetFileTypeById(string fileTypeId, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Gets the "best guess" file type for upload based on a given extension.</summary>
    /// <remarks>Gets the "best guess" file type for upload based on a given extension.</remarks>
    /// <param name="extension">The extension that will determine the File Type that is appropriate for upload.</param>
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
    [Get("/onbase/core/default-upload-file-types")]
    Task<ApiResponse<FileTypeModel>> GetFileTypeForUpload([Query] string extension, [Header("Accept-Language")] string accept_Language = "en-US");
}
