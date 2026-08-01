using Refit;
using HyRest.Api.Models;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Gets the list of disk groups.</summary>
    /// <remarks>Gets the list of disk groups.</remarks>
    /// <param name="type">The disk group types.</param>
    /// <param name="ids">The unique identifier of one or more items.</param>
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
    [Get("/onbase/administration/api/disk-groups")]
    Task<ApiResponse<DiskGroupCollectionModel>> DiskGroups([Query(CollectionFormat.Multi)] IEnumerable<string> type, [Query(CollectionFormat.Multi)] IEnumerable<string> ids);

}