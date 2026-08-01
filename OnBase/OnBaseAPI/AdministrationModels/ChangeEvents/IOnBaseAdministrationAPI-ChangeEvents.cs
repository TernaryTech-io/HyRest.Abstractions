using Refit;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Gets a list of change events.</summary>
    /// <remarks>Gets a list of change events.</remarks>
    /// <param name="beforeDateChanged">The upper bound of the range to search for</param>
    /// <param name="afterDateChanged">The lower bound of the range to search for</param>
    /// <param name="author">The id of the user to search changes for</param>
    /// <param name="itemType">The object type to search for</param>
    /// <param name="itemName">The object name to search for</param>
    /// <param name="itemId">The object id to search for</param>
    /// <param name="changeType">The object change type to search for</param>
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
    [Get("/api/change-events")]
    Task<ChangeEventCollection> ChangeEvents([Query] string beforeDateChanged, [Query] string afterDateChanged, [Query] string author, [Query] string itemType, [Query] string itemName, [Query] string itemId, [Query] ChangeType? changeType);

    /// <summary>Gets a list of valid values for change type property.</summary>
    /// <remarks>Gets a list of valid values for change type property.</remarks>
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
    [Get("/api/change-events/change-type")]
    Task<PropertyDescription> ChangeType();

    /// <summary>Gets a list of valid values for change source property.</summary>
    /// <remarks>Gets a list of valid values for change source property.</remarks>
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
    [Get("/api/change-events/change-source")]
    Task<PropertyDescription> ChangeSource();

    /// <summary>Gets a list of valid values for item type property.</summary>
    /// <remarks>Gets a list of valid values for item type property.</remarks>
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
    [Get("/api/change-events/item-type")]
    Task<PropertyDescription> ItemType();
}