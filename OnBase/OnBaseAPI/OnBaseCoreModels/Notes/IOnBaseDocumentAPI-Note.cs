using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{
    /// <summary>Get the information of a given note.</summary>
    /// <param name="noteId">The identifier of the note.</param>
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
    /// <description>The user does not have rights to view this note.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json")]
    [Get("/onbase/core/notes/{noteId}")]
    Task<ApiResponse<NoteModel>> GetNoteByNoteId(string noteId);

    /// <summary>Update the information of a given note.</summary>
    /// <param name="noteId">Id of the note to update.</param>
    /// <param name="body">Model containing the note data to update.</param>
    /// <returns>The note was updated.</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>The body of the request is not present or the note type of the note is unsupported.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>The user does not have rights to update the note or
    /// the document lock prevents the note from being updated or
    /// the noteType is not movable.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// <item>
    /// <term>422</term>
    /// <description>The note type is not movable.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
    [Patch("/onbase/core/notes/{noteId}")]
    Task<ApiResponse<NoteModel>> PatchNoteByNoteId(string noteId, [Body] UpdateNoteProperties body);

    /// <summary>Delete a single note.</summary>
    /// <param name="noteId">Id of the note to delete.</param>
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
    /// <description>The note is a note type that is unsupported.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>The user does not have rights to delete the note or
    /// the document lock prevents the note from being deleted.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/problem+json")]
    [Delete("/onbase/core/notes/{noteId}")]
    Task<IApiResponse> DeleteNoteByNoteId(string noteId);

    /// <summary>Gets a collection of notes for a given document.</summary>
    /// <remarks>
    /// Gets a collection of notes for a given document.
    /// Use `latest` to retrieve the most recent revision's notes.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="revisionId">The unique identifier of a document revision.</param>
    /// <param name="page">
    /// The page of the document to retrieve notes from. A page is one based.
    /// If the value is not present then all notes on the document revision will be retrieved.
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
    [Get("/onbase/core/documents/{documentId}/revisions/{revisionId}/notes")]
    Task<ApiResponse<NoteCollectionModel>> GetNoteCollectionForDocument(string documentId, string revisionId, [Query] int? page = null);

    /// <summary>Create a new note and add it to a given document revision.</summary>
    /// <remarks>
    /// Create a new note and add it to a given document revision.
    /// Use `latest` to add to the most recent revision.
    /// </remarks>
    /// <param name="documentId">The unique identifier of a document.</param>
    /// <param name="revisionId">The unique identifier of a document revision.</param>
    /// <param name="body">Model containing the note metadata to save.</param>
    /// <returns>The note was successfully created.</returns>
    /// <exception cref="ApiException">
    /// Thrown when the request returns a non-success status code:
    /// <list type="table">
    /// <listheader>
    /// <term>Status</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>400</term>
    /// <description>The note has an invalid size, the note type of the note is unsupported, or the note
    /// could not be created.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>The user does not have rights to create notes on this document or
    /// the document lock prevents the note from being created.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
    [Post("/onbase/core/documents/{documentId}/revisions/{revisionId}/notes")]
    Task<IApiResponse> PostNoteOnDocument(string documentId, string revisionId, [Body] AddNoteProperties body);
}
