using Refit;

namespace HyRest.API;

/// <summary>OnBase Document API</summary>
public partial interface IOnBaseDocumentAPI : IHylandRestAPI
{    
    Task<ApiResponse<AutoFillKeywordSetCollectionModel>> GetAutofillKeywordSetCollection([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Get autofill keyword set metadata.</summary>
    /// <remarks>Get autofill keyword set metadata for the specified autofill keyword set id.</remarks>
    /// <param name="autoFillKeywordSetId">The unique identifier of a autofill keyword set.</param>
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
    [Get("/onbase/core/autofill-keyword-sets/{autoFillKeywordSetId}")]
    Task<ApiResponse<AutoFillKeywordSetModel>> GetAutofillKeywordSetById(string autoFillKeywordSetId, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Get keyword metadata for a autofill type.</summary>
    /// <remarks>Gets the associated keyword types.</remarks>
    /// <param name="autoFillKeywordSetId">The unique identifier of a autofill keyword set.</param>
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
    [Get("/onbase/core/autofill-keyword-sets/{autoFillKeywordSetId}/keyword-types")]
    Task<ApiResponse<AutoFillKeywordSetKeywordTypeCollectionModel>> GetKeywordTypeCollectionForAutofillKeywordSet(string autoFillKeywordSetId);

    /// <summary>Get the keyword set data.</summary>
    /// <remarks>Get the keyword set data instances based on query parameters.</remarks>
    /// <param name="autoFillKeywordSetId">The unique identifier of a autofill keyword set.</param>
    /// <param name="accept_Language">
    /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
    /// header field can be used by user agents to
    /// indicate the set of natural languages that are preferred in the
    /// response.  Language tags are defined in RFC 5646. If none of the
    /// languages given are supported, a default language will be returned.
    /// </param>
    /// <param name="primaryValue">The primary keyword value associated with the particular autofill keyword set.</param>
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
    [Get("/onbase/core/autofill-keyword-sets/{autoFillKeywordSetId}/keyword-set-data")]
    Task<ApiResponse<KeywordSetDataCollectionModel>> GetKeywordDataCollectionForAutofillKeywordSet(string autoFillKeywordSetId, [Query] string primaryValue, [Header("Accept-Language")] string accept_Language = "en-US");

    /// <summary>Performs modification of keyword data during indexing processes like Reindex and Archival.</summary>
    /// <remarks>
    /// During the indexing process, some actions require additional information from the server before indexing can continue. This
    /// end point provides the ability to perform these actions.
    /// This end point is intended to assist with indexing processes that are interactive. Requests to this end point do not persist
    /// any indexing data on the document.
    /// # Expand AutoFill Keyword Sets
    /// AutoFill Keyword Sets can be expanded during the Reindex process and during the Archival process. Information about the desired AutoFill
    /// to expand is sent to the server to perform the operation and sends back the results based on a Primary Keyword value. Expansion will
    /// occur if a single Primary Keyword value match is found and will return back the updated Keyword Collection. If multiple matches are
    /// found the endpoint will behave differently depending on the following AutoFill Keyword Set configuration.
    /// 
    ///  ;table&gt;
    ///  ;tr&gt;
    ///  ;th&gt;Expansion Type ;/th&gt;  ;th&gt;Behavior ;/th&gt;
    ///  ;/tr&gt;  ;tr&gt;
    ///  ;td&gt;Single Selection ;/td&gt;  ;td&gt;A collection of AutoFill Keyword Set Data Sets will be sent
    /// back that requires a selection of a single AutoFill Keyword Set Data Set Instance Id
    /// to be passed back for successful expansion. ;/td&gt;
    ///  ;/tr&gt;  ;tr&gt;
    ///  ;td&gt;Multiple Selection ;/td&gt;  ;td&gt;A collection of AutoFill Keyword Set Data Sets will be sent back
    /// that requires a selection of AutoFill Keyword Set Data Set Instance Ids to be passed
    /// back for successful expansion. ;/td&gt;
    ///  ;/tr&gt;  ;tr&gt;
    ///  ;td&gt;Expand All ;/td&gt;  ;td&gt;All matching AutoFill Keyword Set Data Sets will be
    /// expanded without any other interaction. ;/td&gt;
    ///  ;/tr&gt;
    ///  ;/table&gt;
    /// </remarks>
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
    /// <term>300</term>
    /// <description>Multiple AutoFill Keyword Set Data Set items are found matching the Primary Keyword Value.</description>
    /// </item>
    /// <item>
    /// <term>400</term>
    /// <description>Response when the user sends an invalid AutoFill Keyword Expansion Properties.</description>
    /// </item>
    /// <item>
    /// <term>401</term>
    /// <description>Response when the user does not supply valid authorization credentials.</description>
    /// </item>
    /// <item>
    /// <term>403</term>
    /// <description>Response when the user does not have the necessary privileges.</description>
    /// </item>
    /// <item>
    /// <term>404</term>
    /// <description>Response when the resource does not exist or the user does not have rights
    /// to the resource.</description>
    /// </item>
    /// </list>
    /// </exception>
    [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
    [Post("/onbase/core/indexing-modifiers")]
    Task<ApiResponse<IndexingModifiersPostResponse>> PostIndexingModifier([Body] ReindexAutoFillExpansionModifierProperties body);
}
