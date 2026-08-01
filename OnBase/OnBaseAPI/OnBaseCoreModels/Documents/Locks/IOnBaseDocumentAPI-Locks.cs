using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Gets the current locks for the document.</summary>
    /// <remarks>Gets the list of locks that are currently placed on a document.</remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
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
    [Get("/onbase/core/onbase/core/documents/{documentId}/locks")]
    Task<ApiResponse<LockInfoCollectionModel>> GetDocumentLocks(string documentId);

    /// <summary>Create a lock on a document.</summary>
    /// <remarks>
    /// Creates lock on a document. The type of lock is
    /// specified in the required query parameter `lockType`.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="lockType">
    /// The type of lock to retrieve.
    /// Currently, only keyword locks are supported.
    /// </param>
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
    /// <description>Response when lockType is not included.</description>
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
    /// <item>
    /// <term>409</term>
    /// <description>Response when the user tries to obtain a lock on an item that is already locked.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/problem+json")]
    [Post("/onbase/core/documents/{documentId}/locks")]
    Task<IApiResponse> PostDocumentLocks(string documentId, [Query] LockType lockType);

    /// <summary>Delete a lock on a document.</summary>
    /// <remarks>
    /// Deletes a lock on a document. The type of lock is
    /// specified in the required query parameter `lockType`.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="lockType">
    /// The type of lock to retrieve.
    /// Currently, only keyword locks are supported.
    /// </param>
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
    /// <description>Response when lockType is not included.</description>
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
    [Headers("Accept: application/problem+json")]
    [Delete("/onbase/core/documents/{documentId}/locks")]
    Task<IApiResponse> DeleteDocumentLock(string documentId, [Query] LockType lockType);
}
