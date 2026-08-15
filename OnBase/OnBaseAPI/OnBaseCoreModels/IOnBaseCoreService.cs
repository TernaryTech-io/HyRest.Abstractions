using HyRest.Cache;
using HyRest.OnBase.Core;
using Microsoft.Extensions.Logging;
using Refit;

namespace HyRest.OnBase.ApiServices;

/// <summary>
/// Serives that executes the REST API Calls, logs, interacts with the Cache
/// </summary>
public interface IOnBaseCoreService : IOnBaseService
{
    new ILogger<IOnBaseCoreService> Logger { get; }
    ILogger<IOnBaseService> IOnBaseService.Logger => Logger;
    Task<AutoFillKeywordSetCollectionModel?> GetAutoFillKeywordSets(CancellationToken token = default);
    Task<AutoFillKeywordSetModel?> GetAutoFillKeywordSet(string identifier, CancellationToken token = default);
    Task<AutoFillKeywordSetKeywordTypeCollectionModel?> GetAutoFillKeywordSetKeywordTypes(string id, CancellationToken token = default);
    Task<KeywordSetDataCollectionModel?> GetAutoFillKeySetData(string id, string primaryValue, CancellationToken token = default);
    Task<CurrencyFormatCollectionModel?> GetCurrencyFormats(CancellationToken token = default);
    Task<CurrencyFormatModel?> GetCurrencyFormat(string identifier, CancellationToken token = default);
    Task<CustomQueryCollectionModel?> GetCustomQueries(CancellationToken token = default);
    Task<CustomQueryModel?> GetCustomQuery(string identifier, CancellationToken token = default);
    Task<CustomQueryKeywordTypeCollectionModel?> GetKeywordsForCustomQuery(string id, CancellationToken token = default);
    Task<QueryResultsModel?> GetQueryResults(string id, CancellationToken token = default);
    public Task<QueriesPostResponseModel?> PostDocumentQuery(QueryInformationModel model, bool includeItemCount = false, CancellationToken token = default);
    Task<DocumentTypeCollectionModel?> GetDocumentTypes(CancellationToken token = default);
    Task<DocumentTypeModel?> GetDocumentType(string identifier, CancellationToken token = default);
    Task<KeywordCollectionModel?> GetDefaultKeywordsForDocumentType(string id, CancellationToken token);
    Task<KeywordTypeGroupCollectionModel?> GetKeywordTypeGroupsForDocumentType(string id, CancellationToken token = default);
    Task<DocumentModel?> GetDocumentById(string id, CancellationToken token);
    Task<LockInfoCollectionModel?> GetDocumentLocks(string id, CancellationToken token = default);
    Task CreateDocumentLock(string id, LockType type, CancellationToken token = default);
    Task DeleteDocumentLock(string id, LockType type, CancellationToken token = default);
    Task DeleteDocument(string id, CancellationToken token = default);
    Task PatchDocumentDate(string id, DocumentPatchRequestModel documentDate, CancellationToken token = default);
    Task PutKeywordsForDocument(string id, KeywordCollectionModel keyColl, CancellationToken token = default);
    Task<KeywordCollectionModel?> GetKeywordsForDocument(string id, bool? unmask = false, CancellationToken token = default);
    Task<RevisionCollectionModel?> GetDocumentRevisions(string id, CancellationToken token = default);
    Task<RevisionModel?> GetDocumentRevision(string id, string revisionId, CancellationToken token = default);
    Task<NoteCollectionModel?> GetNotesForDocument(string id, string revisionid = "latest", CancellationToken token = default);
    Task<DocumentHistory?> GetDocumentHistory(string id, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null,
        string? userId = null, CancellationToken token = default);
    Task<ApiResponse<Stream>> GetDocumentContent(string id, string revisionId = "latest", string fileTypeId = "default", string? pages = null, Context? context = Context.View,
        int? height = null, int? width = null, Fit? fit = null, string? accept = "*/*", string? if_Match = null, string? range = null, CancellationToken token = default);
    Task PostNoteOnDocument(string id, AddNoteProperties addNoteProperties, string revisionId = "latest", CancellationToken token = default);
    Task DeleteFileUpload(string id, CancellationToken token = default);
    Task<UploadsPostResponseModel?> PostFileUpLoad(UploadPostRequestModel model, CancellationToken token = default);
    Task PutFileUpLoad(string id, int partNo, ByteArrayContent content, CancellationToken token = default);
    Task<DocumentsPostResponse?> PostDocument(DocumentArchivePropertiesModel props, CancellationToken token = default);
    Task<DocumentTypeGroupCollectionModel?> GetDocumentTypeGroups(CancellationToken token = default);
    Task<DocumentTypeGroupModel?> GetDocumentTypeGroup(string identifier, CancellationToken token = default);
    Task<DocumentTypeCollectionModel?> GetDocumentTypesForDocumentTypeGroup(string id, CancellationToken token = default);
    Task<FileTypeCollectionModel?> GetFileTypes(CancellationToken token = default);
    Task<FileTypeModel?> GetFileType(string identifier, CancellationToken token = default);
    Task<FileTypeModel> GetBestGuessFileType(string extension, CancellationToken token);
    Task<KeywordTypeGroupCollectionModel?> GetKeywordTypeGroups(CancellationToken token = default);
    Task<KeywordTypeGroupModel?> GetKeywordTypeGroup(string identifier, CancellationToken token = default);
    Task<KeywordTypeCollectionModel?> GetKeywordTypesForKeywordTypeGroup(string id, CancellationToken token = default);
    Task<KeywordTypeCollectionModel?> GetKeywordTypes(CancellationToken token = default);
    Task<KeywordTypeModel?> GetKeywordType(string identifier, CancellationToken token = default);
    Task<NoteTypeCollectionModel?> GetNoteTypes(CancellationToken token = default);
    Task<NoteTypeModel?> GetNoteType(string identifier, CancellationToken token = default);
    Task<NoteModel?> GetNote(string id, CancellationToken token = default);
    Task<NoteModel?> PatchNote(string id, UpdateNoteProperties properties, CancellationToken token = default);
    Task DeleteNote(string id, CancellationToken token = default);
    Task<RenditionCollectionModel?> GetRevisionRenditions(string id, string revisionId, CancellationToken token = default);
}
