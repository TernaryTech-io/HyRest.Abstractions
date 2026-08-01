using Refit;

namespace HyRest.API;

public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Get keyword type metadata for all keyword types.</summary>
    /// <remarks>
    /// Get the keyword type metadata for all keyword types in
    /// the system.
    /// </remarks>
    /// <param name="id">The unique identifiers of keyword types. This parameter cannot be used in conjunction with the `systemName` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?id=102&amp;id=103</param>
    /// <param name="systemName">The unique configured system names of keyword types. This parameter cannot be used in conjunction with the `id` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?systemName=keywordType1&amp;systemName=keywordType2</param>
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
    [Get("/onbase/core/keyword-types")]
    Task<ApiResponse<KeywordTypeCollectionModel>> GetKeywordTypeCollection([Query(CollectionFormat.Multi)] IEnumerable<string>? id, [Query(CollectionFormat.Multi)] IEnumerable<string>? systemName, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Get keyword type metadata.</summary>
    /// <remarks>Get keyword type metadata for the specified keyword type id.</remarks>
    /// <param name="keywordTypeId">The unique identifier of a keyword type.</param>
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
    [Get("/onbase/core/keyword-types/{keywordTypeId}")]
    Task<ApiResponse<KeywordTypeModel>> GetKeywordTypeById(string keywordTypeId, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Get a list of keyword types in the keyword type group.</summary>
    /// <remarks>Get a list of keyword types in the keyword type group with the specified id.</remarks>
    /// <param name="keywordTypeGroupId">The unique identifier of a keyword type group.</param>
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
    [Get("/onbase/core/keyword-type-groups/{keywordTypeGroupId}/keyword-types")]
    Task<ApiResponse<KeywordTypeCollectionModel>> GetKeywordTypeCollectionForKeywordTypeGroup(string keywordTypeGroupId, [Header("Accept-Language")] string accept_Language = "en-US");

}
