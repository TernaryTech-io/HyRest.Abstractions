using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Get the metadata for all currency formats.</summary>
    /// <remarks>
    /// Get all the currency formats configured. This list will not include the currency
    /// used to support Workstation Region Settings.
    /// </remarks>
    /// <param name="id">The unique identifiers of currency formats. This parameter cannot be used in conjunction with the `systemName` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?id=102&amp;id=103</param>
    /// <param name="systemName">The unique configured system names of currency formats. This parameter cannot be used in conjunction with the `id` parameter. Multiple values are supported and in a URL should be joined using the "&amp;" character.  Ex:?systemName=currencyFormat1&amp;systemName=currencyFormat2</param>
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
    [Get("/onbase/core/currency-formats")]
    Task<ApiResponse<CurrencyFormatCollectionModel>> GetCurrencyFormatCollection([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Gets currency format metadata.</summary>
    /// <remarks>
    /// Gets currency format metadata.  When Keyword Type is configured to use Workstation Regional Settings
    /// 'default' can be used.
    /// </remarks>
    /// <param name="currencyFormatId">The unique identifier of a currency format.</param>
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
    [Get("/onbase/core/currency-formats/{currencyFormatId}")]
    Task<ApiResponse<CurrencyFormatModel>> GetCurrencyFormatById(string currencyFormatId, [Header("Accept-Language")] string accept_Language = "en-US");
}
