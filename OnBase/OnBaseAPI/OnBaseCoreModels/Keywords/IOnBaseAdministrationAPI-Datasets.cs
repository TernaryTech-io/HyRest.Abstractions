using Refit;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Gets the list of keyword dataset.</summary>
    /// <remarks>Gets the list of keyword dataset.</remarks>
    /// <param name="keywordTypeId">The unique identifier of a keyword type.</param>
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
    [Get("/onbase/administration/api/keyword-types/{keywordTypeId}/dataset")]
    Task<ApiResponse<KeywordDatasetCollectionModel>> DatasetGet(string keywordTypeId);

    /// <summary>Replace an existing keyword datasets.</summary>
    /// <remarks>Replace an existing keyword datasets.</remarks>
    /// <param name="keywordTypeId">The unique identifier of a keyword type.</param>
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
    [Headers("Accept: application/json", "Content-Type: application/JSON")]
    [Put("/onbase/administration/api/keyword-types/{keywordTypeId}/dataset")]
    Task<ApiResponse<KeywordDatasetCollectionModel>> DatasetPut(string keywordTypeId, [Body] IEnumerable<KeywordDatasetValueModel> body);

}