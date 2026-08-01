using Refit;

namespace HyRest.API;

public partial interface IOnBaseAdministrationAPI : IHylandRestAPI
{
    /// <summary>Creates a new file type.</summary>
    /// <remarks>Creates a new file type based on the model that is sent in the request.</remarks>
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
    /// <term>403</term>
    /// <description>Response when the user does not have permissions to access the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Post("/onbase/administration/api/file-types")]
    Task<ApiResponse<FileTypeModel>> FileTypesPost([Body] FileTypeModel body);

    /// <summary>Get file type identifiers for all file types.</summary>
    /// <remarks>
    /// Get the file type identifiers for all file types in
    /// the system.
    /// </remarks>
    /// <param name="ids">The unique identifier of one or more items.</param>
    /// <param name="limit">The maximum amount of items per page. 0 indicates no limit.</param>
    /// <param name="lastValue">name of the last value shown on previous page. Null indicates to start from first value.</param>
    /// <param name="descendingOrder">boolean to retrive the values in descending order.</param>
    /// <param name="x_Custom_Content_Hash">The hash value of associated primary config object</param>
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
    /// </list>
    /// </exception>
    [Headers("Accept: application/json")]
    [Get("/onbase/administration/api/file-types")]
    Task<ApiResponse<FileTypeCollectionModel>> FileTypesGet([Query(CollectionFormat.Multi)] IEnumerable<string> ids, [Query] int? limit, [Query] string lastValue, [Query] bool? descendingOrder, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Get file type metadata.</summary>
    /// <remarks>Get file type metadata for the specified file type id.</remarks>
    /// <param name="fileTypeId">The unique identifier of a file type.</param>
    /// <param name="x_Custom_Content_Hash">The hash value of associated primary config object</param>
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
    [Get("/onbase/administration/api/file-types/{fileTypeId}")]
    Task<ApiResponse<FileTypeModel>> FileTypesGet2(string fileTypeId, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Sets all file type values for an existing file type.</summary>
    /// <remarks>Sets all file type values for an existing file type. Existing values will be replaced with the supplied list of file type values.</remarks>
    /// <param name="fileTypeId">The unique identifier of a file type.</param>
    /// <param name="x_Custom_Content_Hash">The hash value of associated primary config object</param>
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
    [Headers("Accept: application/json", "Content-Type: application/json")]
    [Put("/onbase/administration/api/file-types/{fileTypeId}")]
    Task<ApiResponse<FileTypeModel>> FileTypesPut(string fileTypeId, [Body] FileTypeModel body, [Header("X-Custom-Content-Hash")] string x_Custom_Content_Hash);

    /// <summary>Update an existing file type.</summary>
    /// <remarks>Updates the file type information for a specific keyword type.</remarks>
    /// <param name="fileTypeId">The unique identifier of a file type.</param>
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
    [Headers("Accept: application/json", "Content-Type: application/json-patch+json")]
    [Patch("/onbase/administration/api/file-types/{fileTypeId}")]
    Task<ApiResponse<FileTypeModel>> FileTypesPatch(string fileTypeId, [Body] IEnumerable<ApiResponse<PatchCommand>> body);

    /// <summary>delete an existing filetype.</summary>
    /// <remarks>Delete a filetype object from a valid id number</remarks>
    /// <param name="fileTypeId">The unique identifier of a file type.</param>
    /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Delete("/onbase/administration/api/file-types/{fileTypeId}")]
    Task FileTypesDelete(string fileTypeId);

    /// <summary>Get display type identifiers and values for all display types.</summary>
    /// <remarks>
    /// Get the display type identifiers and values for all display types in
    /// the system.
    /// </remarks>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">Thrown when the request returns a non-success status code.</exception>
    [Headers("Accept: application/json")]
    [Get("/api/file-types/display-types")]
    Task<DisplayTypeWithValuesCollectionModel> DisplayTypes();
}