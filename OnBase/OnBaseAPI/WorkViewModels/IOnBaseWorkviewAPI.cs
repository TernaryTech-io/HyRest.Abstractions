using Refit;

namespace HyRest.API;

public partial interface IOnBaseWorkViewAPI : IHylandRestAPI
{    
    /// <summary>Saves a settings blob in json form using the specified keys.</summary>
    /// <param name="objectType">metadata type name or id.</param>
    /// <param name="objectKey">item id of a metadata object.</param>
    /// <param name="settingType">name given for a specific persisted setting</param>
    /// <param name="body">Value of the requested setting</param>
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
    /// <description>Response for when a bad request is provided.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Content-Type: application/json")]
    [Put("/onbase/workview/user-settings/{objectType}/{objectKey}/{settingType}")]
    Task<IApiResponse> UserSettingsPut(ObjectType objectType, string objectKey, string settingType, [Body] SettingModel body);

    /// <summary>Returns a settings blob in json form using the specified keys.</summary>
    /// <param name="objectType">metadata type name or id.</param>
    /// <param name="objectKey">item id of a metadata object.</param>
    /// <param name="settingType">name given for a specific persisted setting</param>
    /// <returns>Value of the requested setting</returns>
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
    [Headers("Accept: application/json, text/plain")]
    [Get("/onbase/workview/user-settings/{objectType}/{objectKey}/{settingType}")]
    Task<ApiResponse<SettingModel>> UserSettingsGet(ObjectType objectType, string objectKey, string settingType);
}
