using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Gets history for a document</summary>
    /// <remarks>Gets a list of the document history with the provided data.</remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="startDate">The start date to be set.  ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 date format.</param>
    /// <param name="endDate">The end date to be set.  ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 date format.</param>
    /// <param name="userId">The user under which action was taken.</param>
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
    [Headers("Accept: application/json")]
    [Get("/onbase/core/documents/{documentId}/history")]
    Task<ApiResponse<DocumentHistory>> History(string documentId, [Query] System.DateTimeOffset? startDate, [Query] System.DateTimeOffset? endDate, [Query] string? userId);

}
