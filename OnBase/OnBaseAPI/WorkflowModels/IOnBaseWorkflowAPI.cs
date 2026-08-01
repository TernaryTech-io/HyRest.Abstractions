using Refit;
using System.Text.Json.Serialization;

#nullable enable annotations

namespace HyRest.API
{
    /// <summary>OnBase Workflow REST API</summary>
    [System.CodeDom.Compiler.GeneratedCode("Refitter", "2.0.0.0")]
    public partial interface IOnBaseWorkflowAPI : IHylandRestAPI
    {
        /// <summary>Gets a list of life cycles.</summary>
        /// <remarks>Gets a list of life cycles the user has rights to access in a client.</remarks>
        /// <param name="id">
        /// The unique indentifiers of life cycles.  This parameter cannot be used in conjuntion
        /// with the systemName parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?id=101&amp;id=102
        /// </param>
        /// <param name="systemName">
        /// The name of life cycles.  This parameter cannot be used in conjunction
        /// with the id parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?name=lifecycle_1&amp;name=lifecycle_2
        /// </param>
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
        /// <term>400</term>
        /// <description>Response when the user tries to combine id and systemName query parameters.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/life-cycles")]
        Task<LifeCycleCollectionModel> GetLifeCycles([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the life cycle with the associated id.</summary>
        /// <param name="lifeCycleId">The unique identifier of a life cycle.</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the life cycle id does not exist or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/life-cycles/{lifeCycleId}")]
        Task<LifeCycleModel> GetLifeCycleById(string lifeCycleId, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets a list of queues.</summary>
        /// <remarks>Gets a list of queues the user has rights to access in a client.</remarks>
        /// <param name="id">
        /// The unique indentifiers of queues.  This parameter cannot be used in conjuntion
        /// with the systemName parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?id=101&amp;id=102
        /// </param>
        /// <param name="systemName">
        /// The name of queues.  This parameter cannot be used in conjunction
        /// with the id parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?name=queue_1&amp;name=queue_2
        /// </param>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="lifeCycleId">
        /// If specified only the queues the user has rights to and are in the specified life cycle
        /// will be returned. If the life cycle Id does not exist, or the user does not have rights
        /// to the life cycle then an empty list of queues will be returned.
        /// </param>
        /// <param name="lifeCycleName">
        /// If specified only the queues the user has rights to and are in the specified life cycle
        /// will be returned. If a life cycle with this name does not exist, or the user does not have rights
        /// to the life cycle then an empty list of queues will be returned.
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
        /// <term>400</term>
        /// <description>Response when the user tries to combine id and systemName query parameters.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/queues")]
        Task<QueueCollectionModel> GetQueues([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName, [Query] string lifeCycleId, [Query] string lifeCycleName, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the queue with the associated id.</summary>
        /// <param name="queueId">The unique identifier of a queue.</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the queue id does not exist or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/queues/{queueId}")]
        Task<QueueModel> GetQueueById(string queueId, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the list of filters that can be applied to the queue that the user has rights to.</summary>
        /// <param name="queueId">The unique identifier of a queue.</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the queue id does not exist or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/queues/{queueId}/filters")]
        Task<WorkflowFilterCollectionModel> GetInboxFiltersByQueueId(string queueId, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the list of work items in the queue.</summary>
        /// <param name="queueId">The unique identifier of a queue.</param>
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
        /// <description>The query is not valid for the queue.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the queue id does not exist or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
        [Post("/queues/{queueId}/work-items")]
        Task<QueueQueryResultModel> GetQueueWorkItems(string queueId, [Body] Body body);

        /// <summary>Gets a list of ad-hoc tasks.</summary>
        /// <remarks>Gets a list of ad-hoc tasks the user has rights to in the given queue.</remarks>
        /// <param name="queueId">The unique identifier of a queue.</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json")]
        [Get("/ad-hoc-tasks")]
        Task<AdHocTaskCollectionModel> GetAdHocTasks([Query] string queueId, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the information about an ad hoc task.</summary>
        /// <param name="adhocTaskId">The unique identifier of an ad hoc task.</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the ad-hoc task id does not exist or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/ad-hoc-tasks/{adhocTaskId}")]
        Task<AdHocTaskModel> GetAdHocTaskById(string adhocTaskId, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Executes an ad hoc task</summary>
        /// <remarks>
        /// Executes an ad hoc task.
        /// 
        /// **WARNING:** The API will not return until the ad hoc task has completed execution or requires
        /// user interaction.  If the ad hoc task execution takes a while to complete it may result in
        /// request timeout errors.
        /// </remarks>
        /// <param name="adhocTaskId">The unique identifier of an ad hoc task.</param>
        /// <param name="queueId">The unique identifier of a queue.</param>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="body">body parameter</param>
        /// <returns>Task execution is complete</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>400</term>
        /// <description>Response when one of the following occurs:
        /// * The client specifies an invalid queue or ad hoc task ID.
        /// * The client does not have rights to the queue or ad hoc task.
        /// * The request body does not contain the required information.
        /// * An error was encountered executing the task</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
        [Post("/ad-hoc-tasks/{adhocTaskId}/execute")]
        Task<ExecuteTaskResultModel> ExecuteAdHocTask(string adhocTaskId, [Query] string queueId, [Body] ExecuteTaskModel body, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the information about system tasks.</summary>
        /// <param name="id">
        /// The unique indentifiers of system tasks.  This parameter cannot be used in conjuntion
        /// with the systemName parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?id=101&amp;id=102
        /// </param>
        /// <param name="systemName">
        /// The name of system tasks.  This parameter cannot be used in conjunction
        /// with the id parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?name=systask_1&amp;name=systask_2
        /// </param>
        /// <param name="workItemType">The type of work item the system task can execute on.</param>
        /// <param name="itemTypeId">
        /// ID of the type of item to retrieve the system tasks for.  For documents this would
        /// be the document type ID, for WorkView objects this would be the WorkView class ID etc..
        /// </param>
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
        /// <term>400</term>
        /// <description>Response when the user tries to combine id and systemName query parameters.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/system-tasks")]
        Task<SystemTaskCollectionModel> GetSystemTasks([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName, [Query] WorkItemTypeEnum workItemType, [Query] string itemTypeId, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the information about a system task.</summary>
        /// <param name="systemTaskId">The unique identifier of a system task.</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the system task id does not exist or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/system-tasks/{systemTaskId}")]
        Task<SystemTaskModel> GetSystemTaskById(string systemTaskId, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Executes a system task</summary>
        /// <remarks>
        /// Executes a system task.
        /// 
        /// **WARNING:** The API will not return until the system has completed execution or requires
        /// user interaction.  If the system task execution takes a while to complete it may result in
        /// request timeout errors.
        /// </remarks>
        /// <param name="systemTaskId">The unique identifier of a system task.</param>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="body">body parameter</param>
        /// <returns>Task execution is complete</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>400</term>
        /// <description>Response when one of the following occurs:
        /// * The client specifies an invalid system task ID.
        /// * The client does not have rights to the system task.
        /// * The request body does not contain the required information.
        /// * An error was encountered executing the task</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
        [Post("/system-tasks/{systemTaskId}/execute")]
        Task<ExecuteTaskResultModel> ExecuteSystemTask(string systemTaskId, [Body] ExecuteTaskModel body, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Cancels/aborts task execution</summary>
        /// <remarks>Cancels/aborts a task execution that is waiting for user interaction.</remarks>
        /// <param name="operationId">The unique identifier representing an ad hoc or system task execution that is waiting for user interaction.</param>
        /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the operation id does not exist</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/problem+json")]
        [Post("/tasks/operations/{operationId}/cancel")]
        Task CancelTask(string operationId);

        /// <summary>Posts the results of a task execution requiring user interaction</summary>
        /// <param name="operationId">The unique identifier representing an ad hoc or system task execution that is waiting for user interaction.</param>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="body">Contains the information required to resume the task execution.</param>
        /// <returns>Task execution is complete</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>400</term>
        /// <description>Response when the request body does not contain the required information.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the operation id does not exist</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
        [Post("/tasks/operations/{operationId}/ui-interaction")]
        Task<ExecuteTaskResultModel> ResumeTaskUserInteraction(string operationId, [Body] ExecuteTaskUIResponseBreakpointModel body, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Posts HTML form data for validation</summary>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="body">Contains HTML form post data.</param>
        /// <returns>Validation result is returned</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json", "Content-Type: application/json")]
        [Post("/tasks/operations/forms/validate")]
        Task<PostDataValidationResponseModel> Validate([Body] PostDataValidationRequestModel body, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the locations where a work item is within workflow.</summary>
        /// <param name="workItemType">The type of work item the system task can execute on.</param>
        /// <param name="id">
        /// ID of work item.
        /// For documents this is the document ID, for WorkView this is the WorkView object id.
        /// </param>
        /// <param name="classId">
        /// Class ID of work item.
        /// Required for WorkView, Entity and EISMessageItem work item types
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the work item does not exist or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/work-items/locations")]
        Task<WorkItemLocationCollectionModel> GetWorkItemLocations([Query] WorkItemTypeEnum workItemType, [Query] string id, [Query] string classId);

        /// <summary>Gets the list of ad hoc and system tasks that are available to work items.</summary>
        /// <remarks>
        /// Gets the list of ad hoc and system tasks that are available to be executed
        /// on the specified list of work items.
        /// </remarks>
        /// <param name="queueId">
        /// If specified, the list of ad hoc tasks will be limited to those that are
        /// specified in this queue.
        /// </param>
        /// <param name="workItems">
        ///  ;a href="https://tools.ietf.org/id/draft-nottingham-atompub-fiql-00.txt"&gt;FIQL ;/a&gt; query
        /// describing a list of work items to retrieve the list of ad hoc and system tasks for.
        /// 
        /// If an ad hoc task has filter rules configured, then they will be evaluated and tasks that
        /// do not meet the filter rules conditions will not be returned.
        /// 
        /// An example of specifying document id 101 and 102
        /// ```
        /// (type==document;id==101),(type==document;id==102)
        /// ```
        /// 
        /// An example of specifying a WorkView object id 101 and 102 in class 201
        /// ```
        /// (type==workview;classid==201;id==101),(type==workview;classid==201;id==101)
        /// ```
        /// 
        /// Only the equals operator will be supported, submitting a query with any other
        /// operator will result in a 400 Bad Request response.
        /// 
        /// For information about how FIQL is used for this parameter see
        /// https://confluence.hyland.com/display/WF/APIs+using+FIQL+for+Work+Items
        /// </param>
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
        /// <term>400</term>
        /// <description>Response when FIQL query is invalid or not supported.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the queue id is invalid or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/work-items/tasks")]
        Task<AdHocAndSystemTasksModel> GetWorkItemsAdHocAndSystemTasks([Query] string queueId, [Query] string workItems, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the Workflow history for a work item.</summary>
        /// <remarks>Gets a list of the Workflow history items for the specified work item.</remarks>
        /// <param name="workItemType">The type of work item the system task can execute on.</param>
        /// <param name="id">
        /// The unique identifier of a work item.
        /// For documents this is the document ID, for WorkView this is the WorkView object id.
        /// </param>
        /// <param name="classId">Class ID of work item.</param>
        /// <param name="lifeCycleId">The unique identifier of a life cycle.</param>
        /// <param name="queueId">The unique identifier of a queue.</param>
        /// <param name="startDate">The start date to be set for the history search.  ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 date format.</param>
        /// <param name="endDate">The end date to be set for the history search.  ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 date format.</param>
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
        /// <description>Response when FIQL query is invalid or not supported.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the work item \'101\'
        /// is invalid or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json")]
        [Get("/work-items/history")]
        Task<WorkItemWorkFlowHistoryModel> GetWorkItemWorkflowHistory([Query] WorkItemTypeEnum workItemType, [Query] string id, [Query] string classId, [Query] string lifeCycleId, [Query] string queueId, [Query] System.DateTimeOffset? startDate, [Query] System.DateTimeOffset? endDate);

        /// <summary>Gets a list of actions.</summary>
        /// <param name="id">
        /// If specified then the list of actions is filtered to only include actions
        /// with the specified ids.
        /// </param>
        /// <param name="lifeCycleId">
        /// If specified then the list of actions is filtered to only include actions
        /// in the specified life cycle.
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json")]
        [Get("/actions")]
        Task<ActionCollectionModel> GetActions([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query] int? lifeCycleId);

        /// <summary>Gets the action with the associated id.</summary>
        /// <param name="actionId">The id of the action to retrieve</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the action id does not exist</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/actions/{actionId}")]
        Task<ActionModel> GetActionById(string actionId);

        /// <summary>Gets a list of rules.</summary>
        /// <param name="id">
        /// If specified then the list of rules is filtered to only include rules
        /// with the specified ids.
        /// </param>
        /// <param name="lifeCycleId">
        /// If specified then the list of rules is filtered to only include rules
        /// in the specified life cycle.
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json")]
        [Get("/rules")]
        Task<RuleCollectionModel> GetRules([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query] int? lifeCycleId);

        /// <summary>Gets the rule with the associated id.</summary>
        /// <param name="ruleId">The id of the rule to retrieve</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the rule id does not exist</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/rules/{ruleId}")]
        Task<RuleModel> GetRuleById(string ruleId);

        /// <summary>Gets a list of task lists.</summary>
        /// <param name="id">
        /// If specified then the list of task lists is filtered to only include task lists
        /// with the specified ids.
        /// </param>
        /// <param name="lifeCycleId">
        /// If specified then the list of task lists is filtered to only include task lists
        /// in the specified life cycle.
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json")]
        [Get("/tasklists")]
        Task<TaskListCollectionModel> GetTaskLists([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query] int? lifeCycleId);

        /// <summary>Gets the task list with the associated id.</summary>
        /// <param name="tasklistId">The id of the task list to retrieve</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the task list id does not exist</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/tasklists/{tasklistId}")]
        Task<TaskListModel> GetTaskListById(string tasklistId);

        /// <summary>Gets a list of API tasks.</summary>
        /// <remarks>Gets a list of API tasks the user has rights to execute.</remarks>
        /// <param name="id">
        /// The unique indentifiers of API tasks.  This parameter cannot be used in conjuntion
        /// with the systemName parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?id=101&amp;id=102
        /// </param>
        /// <param name="systemName">
        /// The name of API tasks.  This parameter cannot be used in conjunction
        /// with the id parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?name=apitask_1&amp;name=apitask_2
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
        /// <term>400</term>
        /// <description>Response when the user tries to combine id and systemName query parameters.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/api-tasks")]
        Task<ApiTaskCollectionModel> GetApiTasks([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName);

        /// <summary>Gets the API task with the associated id.</summary>
        /// <param name="apiTaskId">The unique identifier of an API task.</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the API task id does not exist or the user does not have rights to it</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/api-tasks/{apiTaskId}")]
        Task<ApiTaskModel> GetApiTaskById(string apiTaskId);

        /// <summary>Executes an API task</summary>
        /// <remarks>
        /// Executes an API task
        /// 
        /// **WARNING:** The API will not return until the system has completed execution or requires
        /// user interaction.  If the API task execution takes a while to complete it may result in
        /// request timeout errors.
        /// </remarks>
        /// <param name="apiTaskId">The unique identifier of an API task.</param>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="body">body parameter</param>
        /// <returns>Task execution is complete</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>400</term>
        /// <description>Response when one of the following occurs:
        /// * The client specifies an invalid system task ID.
        /// * The client does not have rights to the system task.
        /// * The request body does not contain the required information.
        /// * An error was encountered executing the task</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json", "Content-Type: application/json")]
        [Post("/api-tasks/{apiTaskId}/execute")]
        Task<ExecuteTaskResultModel> ExecuteApiTask(string apiTaskId, [Body] ExecuteApiTaskModel body, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets a list of approval roles.</summary>
        /// <param name="id">
        /// The unique indentifiers of approval roles.  This parameter cannot be used in conjuntion
        /// with the systemName parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?id=101&amp;id=102
        /// </param>
        /// <param name="systemName">
        /// The name of approval roles.  This parameter cannot be used in conjunction
        /// with the id parameter.  Multiple values are supported and in a URL should be
        /// joined using the "&amp;" character. Ex: ?name=role_1&amp;name=role_2
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
        /// <term>400</term>
        /// <description>Response when the user tries to combine id and systemName query parameters.</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/wam/approval-roles")]
        Task<ApprovalRoleCollectionModel> GetWamApprovalRoles([Query(CollectionFormat.Multi)] IEnumerable<string> id, [Query(CollectionFormat.Multi)] IEnumerable<string> systemName);

        /// <summary>Gets the approval role with the associated id.</summary>
        /// <param name="approvalRoleId">The id of the approval role to retrieve</param>
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
        /// <description>Response when the client does not supply authorization credentials.</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Response when the server is not licensed for workflow or failed to
        /// acquire a workflow license.</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Response when the approval role id does not exist</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: application/json, application/problem+json")]
        [Get("/wam/approval-roles/{approvalRoleId}")]
        Task<ApprovalRoleModel> GetWamApprovalRoleById(string approvalRoleId);

        /// <summary>Performs a healthcheck for the REST APIs</summary>
        /// <remarks>Performs a healthcheck for the REST APIs</remarks>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">Thrown when the request returns a non-success status code.</exception>
        [Headers("Accept: application/json")]
        [Get("/healthcheck")]
        Task<Response> Healthcheck();


    }

}


namespace HyRest.API
{
    using System = global::System;

    

    /// <summary>
    /// Information that is returned when a task has completed executing.
    /// </summary>
    
    public partial class ExecuteTaskCompletedModel : ExecuteTaskResultModel
    {

        /// <summary>
        /// List of work items that were not executed on due to them being locked by another user, not in the queue etc...
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<Items> Items { get; set; }

        /// <summary>
        /// Only present if this is related to the execution of an API task
        /// </summary>
        [JsonPropertyName("apiTask")]
        public ApiTask ApiTask { get; set; }

    }

    /// <summary>
    /// Information that is returned when a task failed to execute a task.
    /// </summary>
    
    public partial class ExecuteTaskFailedModel : ExecuteTaskResultModel
    {

        [JsonPropertyName("details")]
        public ProblemModel Details { get; set; }

    }

    /// <summary>
    /// Information that a client should display relating to the current action/rule being executed.
    /// <br/>This interaction type is generated just prior to an action/rule/task list execution for
    /// <br/>action/rule/task lists that have the **Enable Debug Breakpoint** option set.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestBreakpointModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires user interaction.
    /// </summary>
    [JsonInheritanceConverter(typeof(ExecuteTaskUIResponseBreakpointModel), "type")]
    [JsonInheritanceAttribute("CreateAgendaItem", typeof(ExecuteTaskUIResponseCreateAgendaItemModel))]
    [JsonInheritanceAttribute("CreateEForm", typeof(ExecuteTaskUIResponseCreateEFormModel))]
    [JsonInheritanceAttribute("CreateNote", typeof(ExecuteTaskUIResponseCreateNoteModel))]
    [JsonInheritanceAttribute("DisplayHtmlForm", typeof(ExecuteTaskUIResponseDisplayHtmlFormModel))]
    [JsonInheritanceAttribute("DisplayElectronicForm", typeof(ExecuteTaskUIResponseDisplayElectronicFormModel))]
    [JsonInheritanceAttribute("DisplayFormUrl", typeof(ExecuteTaskUIResponseDisplayFormUrlModel))]
    [JsonInheritanceAttribute("DisplayHtml", typeof(ExecuteTaskUIResponseDisplayHtmlModel))]
    [JsonInheritanceAttribute("DisplayUnityForm", typeof(ExecuteTaskUIResponseDisplayUnityFormModel))]
    [JsonInheritanceAttribute("DisplayUrl", typeof(ExecuteTaskUIResponseDisplayUrlModel))]
    [JsonInheritanceAttribute("DisplayWorkItemList", typeof(ExecuteTaskUIResponseDisplayWorkItemListModel))]
    [JsonInheritanceAttribute("QuestionBox", typeof(ExecuteTaskUIResponseQuestionBoxModel))]
    [JsonInheritanceAttribute("SelectAutoFillKeywordSet", typeof(ExecuteTaskUIResponseSelectAutoFillKeywordSetModel))]
    [JsonInheritanceAttribute("SelectRole", typeof(ExecuteTaskUIResponseSelectRoleModel))]
    [JsonInheritanceAttribute("SelectUser", typeof(ExecuteTaskUIResponseSelectUserModel))]
    [JsonInheritanceAttribute("SelectUserGroup", typeof(ExecuteTaskUIResponseSelectUserGroupModel))]
    [JsonInheritanceAttribute("SignDocument", typeof(ExecuteTaskUIResponseSignDocumentModel))]
    [JsonInheritanceAttribute("StampVersion", typeof(ExecuteTaskUIResponseStampVersionModel))]
    
    public partial class ExecuteTaskUIResponseBreakpointModel
    {

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information the message the client should display to the user asking if they
    /// <br/>want to create the agenda item.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestCreateAgendaItemModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction2 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the CreateAgendaItem user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseCreateAgendaItemModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// The users response to the message.  Workflow uses this to determine if it should
        /// <br/>create the agenda item.
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseCreateAgendaItemModelResult Result { get; set; }

    }

    /// <summary>
    /// Information the client needs to display to allow the user to create an E-Form.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestCreateEFormModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction3 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the CreateEForm user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseCreateEFormModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// List of name/value pairs containing the information from the form
        /// <br/>being submitted by the user.
        /// </summary>
        [JsonPropertyName("fields")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<PostDataItemModel> Fields { get; set; } = new System.Collections.ObjectModel.Collection<PostDataItemModel>();

    }

    /// <summary>
    /// Information the client needs to display to allow the user to create a note.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestCreateNoteModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction4 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the CreateNote user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseCreateNoteModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// Determines if workflow should create the note, or if the user canceled the creation.
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseCreateNoteModelResult Result { get; set; }

        /// <summary>
        /// Index of the page to place the note on. Required if pageOption is SpecifiedPage.  If promptForPage was false
        /// <br/>then this should be set to the currently display page.
        /// </summary>
        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Contents of the note text
        /// </summary>
        [JsonPropertyName("noteText")]
        public string NoteText { get; set; }

        /// <summary>
        /// Determines what page the note should be placed on.  If promptForPage was false then this should be set to
        /// <br/>SpecifiedPage
        /// </summary>
        [JsonPropertyName("pageOption")]
public ExecuteTaskUIResponseCreateNoteModelPageOption PageOption { get; set; }

    }

    /// <summary>
    /// Information the client needs in order to display an electronic form
    /// </summary>
    
    public partial class ExecuteTaskUIRequestDisplayElectronicFormModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction5 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the DisplayElectronicForm user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseDisplayElectronicFormModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// The type of button the user pressed on the form
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseDisplayElectronicFormModelResult Result { get; set; }

    }

    /// <summary>
    /// Information the client needs in order to display a HTML form
    /// </summary>
    
    public partial class ExecuteTaskUIRequestDisplayHtmlFormModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction6 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the DisplayHtmlForm user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseDisplayHtmlFormModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// List of name/value pairs containing the information from the form
        /// <br/>being submitted by the user.
        /// </summary>
        [JsonPropertyName("fields")]
        public ICollection<PostDataItemModel> Fields { get; set; }

    }

    /// <summary>
    /// Information the client needs in order to display a URL
    /// </summary>
    
    public partial class ExecuteTaskUIRequestDisplayFormUrlModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction7 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the DisplayFormUrl user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseDisplayFormUrlModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// List of name/value pairs containing the information from the form
        /// <br/>being submitted by the user.
        /// </summary>
        [JsonPropertyName("fields")]
        public ICollection<PostDataItemModel> Fields { get; set; }

    }

    /// <summary>
    /// Information the client needs in order to display HTML
    /// </summary>
    
    public partial class ExecuteTaskUIRequestDisplayHtmlModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction8 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the DisplayHtml user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseDisplayHtmlModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// List of name/value pairs containing the information from the form
        /// <br/>being submitted by the user.
        /// </summary>
        [JsonPropertyName("fields")]
        public ICollection<PostDataItemModel> Fields { get; set; }

    }

    /// <summary>
    /// Information the client needs in order to display a Unity form
    /// </summary>
    
    public partial class ExecuteTaskUIRequestDisplayUnityFormModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction9 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the DisplayUnityForm user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseDisplayUnityFormModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// The action that user has taken
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseDisplayUnityFormModelResult Result { get; set; }

        /// <summary>
        /// A piece of XML content containing Unity form field changes
        /// </summary>
        [JsonPropertyName("submittedData")]
        public string SubmittedData { get; set; }

    }

    /// <summary>
    /// Information the client needs in order to display a URL
    /// </summary>
    
    public partial class ExecuteTaskUIRequestDisplayUrlModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction10 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the DisplayUrl user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseDisplayUrlModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// List of name/value pairs containing the information from the form
        /// <br/>being submitted by the user.
        /// </summary>
        [JsonPropertyName("fields")]
        public ICollection<PostDataItemModel> Fields { get; set; }

    }

    /// <summary>
    /// Information the client needs to display a list of work items the user can select from.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestDisplayWorkItemListModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction11 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the DisplayWorkItemList user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseDisplayWorkItemListModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// List of work items selected by the user
        /// </summary>
        [JsonPropertyName("workItems")]
        public ICollection<WorkItemIDModel> WorkItems { get; set; }

    }

    /// <summary>
    /// Information describing the message box a client should display.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestMessageBoxModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction12 UserInteraction { get; set; }

    }

    /// <summary>
    /// Information describing a question box a client should display
    /// </summary>
    
    public partial class ExecuteTaskUIRequestQuestionBoxModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction13 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for a QuestionBox user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseQuestionBoxModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// The button the user pressed.
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseQuestionBoxModelResult Result { get; set; }

    }

    /// <summary>
    /// Information the client needs to allow the user to select a certificate to sign the document with.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestSignDocumentModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction14 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the SignDocument user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseSignDocumentModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// Determines if a certificate was selected
        /// <br/> ;table&gt;
        /// <br/>   ;tr&gt;
        /// <br/>     ;th&gt;CertificateSelected ;/th&gt;
        /// <br/>     ;td&gt;The user selected a certificate ;/td&gt;
        /// <br/>   ;/tr&gt;
        /// <br/>   ;tr&gt;
        /// <br/>     ;th&gt;Cancel ;/th&gt;
        /// <br/>     ;td&gt;The user canceled the certificate selection ;/td&gt;
        /// <br/>   ;/tr&gt;
        /// <br/> ;/table&gt;
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseSignDocumentModelResult Result { get; set; }

        /// <summary>
        /// The thumb print of the user selected certificate.  **Required** when result is CertificateSelected.
        /// </summary>
        [JsonPropertyName("thumbPrint")]
        public string ThumbPrint { get; set; }

    }

    /// <summary>
    /// Information the client needs in order to version stamp the document
    /// </summary>
    
    public partial class ExecuteTaskUIRequestStampVersionModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction15 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for the SignDocument user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseStampVersionModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// Determines if workflow should version stamp the document
        /// <br/> ;table&gt;
        /// <br/>   ;tr&gt;
        /// <br/>     ;th&gt;StampVersion ;/th&gt;
        /// <br/>     ;td&gt;Workflow should version stamp the document ;/td&gt;
        /// <br/>   ;/tr&gt;
        /// <br/>   ;tr&gt;
        /// <br/>     ;th&gt;Cancel ;/th&gt;
        /// <br/>     ;td&gt;The user canceled the version stamping ;/td&gt;
        /// <br/>   ;/tr&gt;
        /// <br/> ;/table&gt;
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseStampVersionModelResult Result { get; set; }

        /// <summary>
        /// The name of the stamped version
        /// </summary>
        [JsonPropertyName("versionName")]
        public string VersionName { get; set; }

    }

    /// <summary>
    /// Information that a client should display relating to the action/rule/task list that has just been executed.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestStepBreakpointModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction16 UserInteraction { get; set; }

    }

    /// <summary>
    /// Information describing a select auto fill keyword sets a client should display.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestSelectAutoFillKeywordSetModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction17 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for a SelectAutoFillKeywordSet user interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseSelectAutoFillKeywordSetModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// List of auto fill keyword set instance ids selected by the user
        /// </summary>
        [JsonPropertyName("selectedInstanceIds")]
        public ICollection<string> SelectedInstanceIds { get; set; }

        /// <summary>
        /// The action the user has taken.
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseSelectAutoFillKeywordSetModelResult Result { get; set; }

    }

    /// <summary>
    /// Information describing the instruction and list of OnBase user accounts that a client should display.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestSelectUserModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction18 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for a SelectUser interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseSelectUserModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// Selected OnBase user account id
        /// </summary>
        [JsonPropertyName("selectedUserId")]
        public string SelectedUserId { get; set; }

        /// <summary>
        /// The action that user has taken.
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseSelectUserModelResult Result { get; set; }

    }

    /// <summary>
    /// Information describing the instruction and list of OnBase user groups that a client should display.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestSelectUserGroupModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction19 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for a SelectUserGroup interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseSelectUserGroupModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// Selected OnBase user group id
        /// </summary>
        [JsonPropertyName("selectedUserGroupId")]
        public string SelectedUserGroupId { get; set; }

        /// <summary>
        /// The action that user has taken.
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseSelectUserGroupModelResult Result { get; set; }

    }

    /// <summary>
    /// Information describing the instruction and list of OnBase roles that a client should display.
    /// </summary>
    
    public partial class ExecuteTaskUIRequestSelectRoleModel : ExecuteTaskRequiresUIModel
    {

        [JsonPropertyName("userInteraction")]
        public UserInteraction20 UserInteraction { get; set; }

    }

    /// <summary>
    /// Contains the response information from a client for a task execution
    /// <br/>that requires information for a SelectRole interaction type.
    /// </summary>
    
    public partial class ExecuteTaskUIResponseSelectRoleModel : ExecuteTaskUIResponseBreakpointModel
    {

        /// <summary>
        /// Selected OnBase role id
        /// </summary>
        [JsonPropertyName("selectedRoleId")]
        public string SelectedRoleId { get; set; }

        /// <summary>
        /// The action that user has taken.
        /// </summary>
        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ExecuteTaskUIResponseSelectRoleModelResult Result { get; set; }

    }

    /// <summary>
    /// Gets the life cycle with the associated id.
    /// </summary>
    
    public partial class LifeCycleModel
    {

        /// <summary>
        /// The unique identifier of the life cycle.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The untranslated system name of the life cycle.  Localization is controlled by the Accept-Language header and the 
        /// <br/>language of the response is represented by the Content-Language header.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The localized name of the life cycle.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The document ID in SYS System Icons or SYS System Bitmaps which is the image for the item.
        /// </summary>
        [JsonPropertyName("smallImageID")]
        public string SmallImageID { get; set; }

        /// <summary>
        /// The life cycle help text.
        /// </summary>
        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// A list of life cycles.
    /// </summary>
    
    public partial class LifeCycleCollectionModel
    {

        /// <summary>
        /// List of life cycles.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<LifeCycleModel> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// The  ;a href="https://tools.ietf.org/html/rfc7807"&gt;Problem Detail ;/a&gt;
    /// <br/>format defines a way to carry machine-readable details of errors in a
    /// <br/>HTTP response to avoid the need to define new error response formats for
    /// <br/>HTTP APIs.
    /// <br/>
    /// <br/>Problem details can be extended and defined for specific
    /// <br/>problem types.
    /// </summary>
    
    public partial class ProblemModel
    {

        /// <summary>
        /// An absolute URI that identifies the problem type.  When
        /// <br/>dereferenced, it should provide human-readable documentation
        /// <br/>for the problem type (e.g., using HTML).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// A short, human-readable summary of the problem type. It should
        /// <br/>not change from occurrence to occurrence of the problem.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The HTTP status code generated by the origin server for this
        /// <br/>occurrence of the problem.
        /// </summary>
        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Range(100, 599)]
        public int Status { get; set; }

        /// <summary>
        /// A human readable explanation specific to this occurrence of the
        /// <br/>problem.
        /// </summary>
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// A URI reference that identifies the specific occurrence of
        /// <br/>the problem.  It may or may not yield further information
        /// <br/>if dereferenced.
        /// </summary>
        [JsonPropertyName("instance")]
        public string Instance { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Gets the queue with the associated id.
    /// </summary>
    
    public partial class QueueModel
    {

        /// <summary>
        /// The unique identifier of the queue.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The untranslated system name of the queue.  Localization is controlled by the Accept-Language header and the 
        /// <br/>language of the response is represented by the Content-Language header.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The localized name of the queue.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The document ID in SYS System Icons or SYS System Bitmaps which is the image for the item.
        /// </summary>
        [JsonPropertyName("smallImageID")]
        public string SmallImageID { get; set; }

        /// <summary>
        /// The document ID in SYS System Icons or SYS System Bitmaps which is the image for the item.
        /// </summary>
        [JsonPropertyName("largeImageID")]
        public string LargeImageID { get; set; }

        /// <summary>
        /// The unique identifier of the life cycle containing this queue.
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public string LifeCycleId { get; set; }

        /// <summary>
        /// The order of this queue relative to other queues in the same life cycle.
        /// </summary>
        [JsonPropertyName("sequence")]
        public int Sequence { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// A list of queues.
    /// </summary>
    
    public partial class QueueCollectionModel
    {

        /// <summary>
        /// List of queues.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<QueueModel> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// A Workflow filter.
    /// </summary>
    
    public partial class WorkflowFilterModel
    {

        /// <summary>
        /// The unique identifier of the Workflow filter.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The untranslated system name of the Workflow filter.  Localization is controlled by the Accept-Language header and the 
        /// <br/>language of the response is represented by the Content-Language header.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The localized name of the Workflow filter.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// A list of Workflow filters.
    /// </summary>
    
    public partial class WorkflowFilterCollectionModel
    {

        /// <summary>
        /// List of Workflow filters.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<WorkflowFilterModel> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Represents the configuration of a display column.
    /// </summary>
    
    public partial class DisplayColumnConfigurationModel
    {

        /// <summary>
        /// Index representing the display column configuration associated with this display column.
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; }

        /// <summary>
        /// Describes the type of display column.
        /// </summary>
        [JsonPropertyName("type")]
public DisplayColumnConfigurationModelType Type { get; set; }

        /// <summary>
        /// The header value for the display column.
        /// </summary>
        [JsonPropertyName("heading")]
        public string Heading { get; set; }

        /// <summary>
        /// The keyword type associated with the display column.  Only necessary if the display column type is "Keyword".
        /// </summary>
        [JsonPropertyName("keywordTypeId")]
        public string KeywordTypeId { get; set; }

        /// <summary>
        /// The data type of the value of the display column.  This is only necessary if the display column type is not "Keyword".
        /// <br/>For keyword display columns, data type can be retrieved from the keyword type.
        /// </summary>
        [JsonPropertyName("dataType")]
public DisplayColumnConfigurationModelDataType DataType { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Display column values
    /// </summary>
    
    public partial class WorkflowDisplayColumnModel
    {

        /// <summary>
        /// Index representing the Display column configuration associated with this display column.
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; }

        /// <summary>
        /// Display column value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Represents a work item returned from a queue query
    /// </summary>
    
    public partial class QueueQueryWorkItemResultModel
    {

        /// <summary>
        /// ID of the work item.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Class ID of the work item.
        /// </summary>
        [JsonPropertyName("classId")]
        public string ClassId { get; set; }

        /// <summary>
        /// Type of work item.
        /// </summary>
        [JsonPropertyName("workItemType")]
public QueueQueryWorkItemResultModelWorkItemType WorkItemType { get; set; }

        /// <summary>
        /// List of display columns returned from executing the query
        /// </summary>
        [JsonPropertyName("displayColumns")]
        public ICollection<DisplayColumnModel> DisplayColumns { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Contains the results of a queue query.
    /// </summary>
    
    public partial class QueueQueryResultModel
    {

        /// <summary>
        /// List of display columns returned from executing a query
        /// </summary>
        [JsonPropertyName("displayColumns")]
        public ICollection<DisplayColumnConfigurationModel> DisplayColumns { get; set; }

        /// <summary>
        /// List of work items returned from executing a query.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<QueueQueryWorkItemResultModel> Items { get; set; }

        /// <summary>
        /// ID of the filter that was applied to the items, or zero if no filter was applied
        /// </summary>
        [JsonPropertyName("filterId")]
        public string FilterId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to an ad-hoc task.
    /// </summary>
    
    public partial class AdHocTaskModel
    {

        /// <summary>
        /// The unique identifier of the ad-hoc task.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The untranslated system name of the ad-hoc task.  Localization is controlled by the Accept-Language header and the
        /// <br/>language of the response is represented by the Content-Language header.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The localized name of the ad-hoc task.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The display name of the ad hoc task.  If a display name was not configured then this contains the localized name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The life cycle id this ad hoc task is in
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public object LifeCycleId { get; set; }

        /// <summary>
        /// The document ID in SYS System Icons or SYS System Bitmaps which is the image for the item.
        /// </summary>
        [JsonPropertyName("smallImageId")]
        public string SmallImageId { get; set; }

        /// <summary>
        /// The document ID in SYS System Icons or SYS System Bitmaps which is the image for the item.
        /// </summary>
        [JsonPropertyName("largeImageId")]
        public string LargeImageId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to an ad-hoc task.
    /// </summary>
    
    public partial class AdHocTaskCollectionModel
    {

        /// <summary>
        /// List of ad-hoc tasks in the life cycle and queue
        /// </summary>
        [JsonPropertyName("items")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<AdHocTaskModel> Items { get; set; } = new System.Collections.ObjectModel.Collection<AdHocTaskModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Interaction types that tasks can require.
    /// </summary>
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaskInteractionTypeEnum
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Breakpoint")]
        Breakpoint = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CreateAgendaItem")]
        CreateAgendaItem = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CreateEForm")]
        CreateEForm = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CreateNote")]
        CreateNote = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DisplayElectronicForm")]
        DisplayElectronicForm = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"DisplayHtmlForm")]
        DisplayHtmlForm = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"DisplayFormUrl")]
        DisplayFormUrl = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"DisplayHtml")]
        DisplayHtml = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"DisplayUnityForm")]
        DisplayUnityForm = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"DisplayUrl")]
        DisplayUrl = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"DisplayWorkItemList")]
        DisplayWorkItemList = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"MessageBox")]
        MessageBox = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"QuestionBox")]
        QuestionBox = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"SelectAutoFillKeywordSet")]
        SelectAutoFillKeywordSet = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"SelectRole")]
        SelectRole = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"SelectUser")]
        SelectUser = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"SelectUserGroup")]
        SelectUserGroup = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"SignDocument")]
        SignDocument = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"StampVersion")]
        StampVersion = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"StepBreakpoint")]
        StepBreakpoint = 19,

    }

    /// <summary>
    /// Type of work item.
    /// </summary>
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkItemTypeEnum
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Document")]
        Document = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Folder")]
        Folder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"WorkView")]
        WorkView = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Entity")]
        Entity = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"EISMessageItem")]
        EISMessageItem = 4,

    }

    /// <summary>
    /// Contains the information that uniquely identifies a work item.
    /// </summary>
    
    public partial class WorkItemIDModel
    {

        /// <summary>
        /// ID of work item.
        /// </summary>
        [JsonPropertyName("id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }

        /// <summary>
        /// Class ID of work item if required.
        /// </summary>
        [JsonPropertyName("classId")]
        public string ClassId { get; set; }

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public WorkItemTypeEnum Type { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information required for workflow to execute an ad hoc or system task.
    /// </summary>
    
    public partial class ExecuteTaskModel
    {

        /// <summary>
        /// List of task interaction types the client supports.  An action or rule may perform
        /// <br/>a default operation if it is executed and wanted to require a task interaction
        /// <br/>that is not in this list.
        /// </summary>
        [JsonPropertyName("allowedInteractions")]
        // TODO(system.text.json): Add ItemConverterType with enum converter when supported
        public ICollection<TaskInteractionTypeEnum> AllowedInteractions { get; set; }

        /// <summary>
        /// List of work items to execute the task on.
        /// </summary>
        [JsonPropertyName("workItems")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<WorkItemIDModel> WorkItems { get; set; } = new System.Collections.ObjectModel.Collection<WorkItemIDModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Contains the status of an ad hoc or system task executon.
    /// </summary>
    [JsonInheritanceConverter(typeof(ExecuteTaskResultModel), "status")]
    [JsonInheritanceAttribute("Completed", typeof(ExecuteTaskCompletedModel))]
    [JsonInheritanceAttribute("Failed", typeof(ExecuteTaskFailedModel))]
    
    public partial class ExecuteTaskResultModel
    {

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Status of a task execution
    /// </summary>
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaskExecutionStatusEnum
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Completed")]
        Completed = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Failed")]
        Failed = 1,

    }

    [JsonInheritanceConverter(typeof(ExecuteTaskRequiresUIModel), "type")]
    [JsonInheritanceAttribute("Breakpoint", typeof(ExecuteTaskUIRequestBreakpointModel))]
    [JsonInheritanceAttribute("CreateAgendaItem", typeof(ExecuteTaskUIRequestCreateAgendaItemModel))]
    [JsonInheritanceAttribute("CreateEForm", typeof(ExecuteTaskUIRequestCreateEFormModel))]
    [JsonInheritanceAttribute("CreateNote", typeof(ExecuteTaskUIRequestCreateNoteModel))]
    [JsonInheritanceAttribute("DisplayElectronicForm", typeof(ExecuteTaskUIRequestDisplayElectronicFormModel))]
    [JsonInheritanceAttribute("DisplayHtmlForm", typeof(ExecuteTaskUIRequestDisplayHtmlFormModel))]
    [JsonInheritanceAttribute("DisplayFormUrl", typeof(ExecuteTaskUIRequestDisplayFormUrlModel))]
    [JsonInheritanceAttribute("DisplayHtml", typeof(ExecuteTaskUIRequestDisplayHtmlModel))]
    [JsonInheritanceAttribute("DisplayUnityForm", typeof(ExecuteTaskUIRequestDisplayUnityFormModel))]
    [JsonInheritanceAttribute("DisplayUrl", typeof(ExecuteTaskUIRequestDisplayUrlModel))]
    [JsonInheritanceAttribute("DisplayWorkItemList", typeof(ExecuteTaskUIRequestDisplayWorkItemListModel))]
    [JsonInheritanceAttribute("MessageBox", typeof(ExecuteTaskUIRequestMessageBoxModel))]
    [JsonInheritanceAttribute("QuestionBox", typeof(ExecuteTaskUIRequestQuestionBoxModel))]
    [JsonInheritanceAttribute("SelectAutoFillKeywordSet", typeof(ExecuteTaskUIRequestSelectAutoFillKeywordSetModel))]
    [JsonInheritanceAttribute("SelectRole", typeof(ExecuteTaskUIRequestSelectRoleModel))]
    [JsonInheritanceAttribute("SelectUser", typeof(ExecuteTaskUIRequestSelectUserModel))]
    [JsonInheritanceAttribute("SelectUserGroup", typeof(ExecuteTaskUIRequestSelectUserGroupModel))]
    [JsonInheritanceAttribute("SignDocument", typeof(ExecuteTaskUIRequestSignDocumentModel))]
    [JsonInheritanceAttribute("StampVersion", typeof(ExecuteTaskUIRequestStampVersionModel))]
    [JsonInheritanceAttribute("StepBreakpoint", typeof(ExecuteTaskUIRequestStepBreakpointModel))]
    
    public partial class ExecuteTaskRequiresUIModel
    {

        /// <summary>
        /// The id of the resource the results of the user interaction should be posted to.
        /// <br/>This will be located at /tasks/operations/{operationId}/ui-interaction
        /// </summary>
        [JsonPropertyName("operationId")]
        public string OperationId { get; set; }

        [JsonPropertyName("workItem")]
        public WorkItemIDModel WorkItem { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Represents a keyword
    /// </summary>
    
    public partial class AutoFillKeywordSetKeywordModel
    {

        /// <summary>
        /// Id of the keyword type the values are for
        /// </summary>
        [JsonPropertyName("keywordTypeId")]
        public string KeywordTypeId { get; set; }

        /// <summary>
        /// Depending on the underlying keyword type datatype, the specific
        /// <br/>format of the underlying string adheres to the following formatting
        /// <br/>rules.
        /// <br/>
        /// <br/>Values are normalized and locale specific formatting is not applied.
        /// <br/>Formatting to a specific currency is not applied. Consumers can
        /// <br/>apply this formatting through libraries and client locale
        /// <br/>preferences. Determining data type or currency format
        /// <br/>is retrieved from other metadata resources.
        /// <br/>
        /// <br/> ;table&gt;
        /// <br/>   ;tr&gt;
        /// <br/>     ;th&gt;Data Type ;/th&gt;  ;th&gt;Format ;/th&gt;  ;th&gt;Example ;/th&gt;
        /// <br/>   ;/tr&gt;  ;tr&gt;
        /// <br/>     ;td&gt;Numeric9 ;/td&gt;  ;td&gt;A whole positive number up to 9 digits, or
        /// <br/>    negative number up to 8 digits without commas. ;/td&gt;
        /// <br/>     ;td&gt;123456789  ;br /&gt; -12345678 ;/td&gt;
        /// <br/>   ;/tr&gt;  ;tr&gt;
        /// <br/>     ;td&gt;Numeric20 ;/td&gt;  ;td&gt;A whole number up to 20 digits without
        /// <br/>    commas, or a negative number with 19 digits without commas. ;/td&gt;
        /// <br/>     ;td&gt;12345678901234567890  ;br /&gt; -1234567890123456789 ;/td&gt;
        /// <br/>   ;/tr&gt;  ;tr&gt;
        /// <br/>     ;td&gt;Alphanumeric ;/td&gt;  ;td&gt;A string value. ;/td&gt;  ;td&gt;ABC 123 ;/td&gt;
        /// <br/>   ;/tr&gt;  ;tr&gt;
        /// <br/>     ;td&gt;Currency ;/td&gt;  ;td&gt;Positive or negative numeric value with a
        /// <br/>    whole number and decimal portion separated by a period. ;/td&gt;
        /// <br/>     ;td&gt;123456.00 ;/td&gt;
        /// <br/>   ;/tr&gt;  ;tr&gt;
        /// <br/>     ;td&gt;SpecificCurrency ;/td&gt;  ;td&gt;Positive or negative numeric value
        /// <br/>    with a whole number and decimal portion separated by a
        /// <br/>    period. ;/td&gt;  ;td&gt;123456.00 ;/td&gt;
        /// <br/>   ;/tr&gt;  ;tr&gt;
        /// <br/>     ;td&gt;Date ;/td&gt;  ;td&gt; ;a
        /// <br/>    href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601
        /// <br/>    Date ;/a&gt; ;/td&gt;  ;td&gt;2018-02-21 ;/td&gt;
        /// <br/>   ;/tr&gt;  ;tr&gt;
        /// <br/>     ;td&gt;DateTime ;/td&gt;  ;td&gt; ;a
        /// <br/>    href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 Date and
        /// <br/>    time without time zone. ;/td&gt;  ;td&gt;2018-02-21T21:17:28 ;/td&gt;
        /// <br/>   ;/tr&gt;  ;tr&gt;
        /// <br/>     ;td&gt;FloatingPoint ;/td&gt;  ;td&gt;Positive or negative numeric value
        /// <br/>    with a whole number and decimal portion separated by a
        /// <br/>    period. ;/td&gt;  ;td&gt;123456.091231 ;/td&gt;
        /// <br/>   ;/tr&gt;
        /// <br/> ;/table&gt;
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// The data for a single instance of an AutoFill Keyword Set row
    /// </summary>
    
    public partial class AutoFillKeywordSetDataModel
    {

        /// <summary>
        /// The unique identifier of the instance
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The list of keywords in the instance
        /// </summary>
        [JsonPropertyName("keywords")]
        public ICollection<AutoFillKeywordSetKeywordModel> Keywords { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to id and name of an OnBase object.
    /// </summary>
    
    public partial class IDAndNameModel
    {

        /// <summary>
        /// The unique identifier of an OnBase object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of an OnBase object.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Contains the information about a certificate
    /// </summary>
    
    public partial class X509Certificate2Model
    {

        /// <summary>
        /// Certificate thumb print
        /// </summary>
        [JsonPropertyName("thumbPrint")]
        public string ThumbPrint { get; set; }

        /// <summary>
        /// Certificate name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Certificate subject name
        /// </summary>
        [JsonPropertyName("subjectName")]
        public string SubjectName { get; set; }

        /// <summary>
        /// Date/time the certificate is valid from.
        /// <br/> ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 Date and time without time zone. ;/a&gt;
        /// </summary>
        [JsonPropertyName("validFrom")]
        public string ValidFrom { get; set; }

        /// <summary>
        /// Date/time the certificate is valid to.
        /// <br/> ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 Date and time without time zone. ;/a&gt;
        /// </summary>
        [JsonPropertyName("validTo")]
        public string ValidTo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a system task.
    /// </summary>
    
    public partial class SystemTaskModel
    {

        /// <summary>
        /// The unique identifier of the system task.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The untranslated system name of the system task.  Localization is controlled by the Accept-Language header and the
        /// <br/>language of the response is represented by the Content-Language header.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The localized name of the system task.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The document ID in SYS System Icons or SYS System Bitmaps which is the image for the item.
        /// </summary>
        [JsonPropertyName("smallImageID")]
        public string SmallImageID { get; set; }

        /// <summary>
        /// The document ID in SYS System Icons or SYS System Bitmaps which is the image for the item.
        /// </summary>
        [JsonPropertyName("largeImageId")]
        public string LargeImageId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to an system task.
    /// </summary>
    
    public partial class SystemTaskCollectionModel
    {

        /// <summary>
        /// List of system tasks in the life cycle and queue
        /// </summary>
        [JsonPropertyName("items")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<SystemTaskModel> Items { get; set; } = new System.Collections.ObjectModel.Collection<SystemTaskModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Name / values pair containing in the post data of a HTML form
    /// </summary>
    
    public partial class PostDataItemModel
    {

        /// <summary>
        /// Name of the item in the post data
        /// </summary>
        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        /// <summary>
        /// List of values for the item in the post data
        /// </summary>
        [JsonPropertyName("values")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<string> Values { get; set; } = new System.Collections.ObjectModel.Collection<string>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Contains the information server needs in order to validate HTML form post data
    /// </summary>
    
    public partial class PostDataValidationRequestModel
    {

        /// <summary>
        /// List of name/value pairs containing the information submitted from a HTML form by the user.
        /// </summary>
        [JsonPropertyName("fields")]
        public ICollection<PostDataItemModel> Fields { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Validation result about HTML form post data
    /// </summary>
    
    public partial class PostDataValidationResponseModel
    {

        /// <summary>
        /// Validation result.
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }

        /// <summary>
        /// Validation error message if it fails.
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// The ID of keyword type that causes validation failure.
        /// </summary>
        [JsonPropertyName("keywordTypeId")]
        public string KeywordTypeId { get; set; }

        /// <summary>
        /// The name of keyword type that causes validation failure.
        /// </summary>
        [JsonPropertyName("keywordTypeName")]
        public string KeywordTypeName { get; set; }

        /// <summary>
        /// The keyword value that causes validation failure.
        /// </summary>
        [JsonPropertyName("keywordValue")]
        public string KeywordValue { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Contains the life cycle and queue id a work item is in.  If the user does not have rights
    /// <br/>to the life cycle and/or queue the id will be zero.
    /// </summary>
    
    public partial class WorkItemLocationModel
    {

        /// <summary>
        /// The unique identifier of the life cycle or zero if the user does not have rights to the life cycle.
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public string LifeCycleId { get; set; }

        /// <summary>
        /// The unique identifier of the queue or zero if the user does not have rights to the queue.
        /// </summary>
        [JsonPropertyName("queueId")]
        public string QueueId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// List of life cycle and queue locations a work item is in.  
    /// </summary>
    
    public partial class WorkItemLocationCollectionModel
    {

        /// <summary>
        /// List of life cycle and queue locations a work item is in.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<WorkItemLocationModel> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Gets the list of ad hoc and system tasks that can be executed on the work items.
    /// </summary>
    
    public partial class QueueIdAndAdHocTasksModel
    {

        /// <summary>
        /// Queue id containing the ad hoc tasks
        /// </summary>
        [JsonPropertyName("queueId")]
        public object QueueId { get; set; }

        /// <summary>
        /// List of ad hoc task in the queue which can be executed on the work items.
        /// </summary>
        [JsonPropertyName("adhocTasks")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<AdHocTaskModel> AdhocTasks { get; set; } = new System.Collections.ObjectModel.Collection<AdHocTaskModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Gets the list of ad hoc and system tasks that can be executed on the work items.
    /// </summary>
    
    public partial class AdHocAndSystemTasksModel
    {

        /// <summary>
        /// List of ad hoc tasks and the queues they are in which can be executed on the work items.
        /// </summary>
        [JsonPropertyName("adhocTasks")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<QueueIdAndAdHocTasksModel> AdhocTasks { get; set; } = new System.Collections.ObjectModel.Collection<QueueIdAndAdHocTasksModel>();

        /// <summary>
        /// List of system tasks that can be executed on the work items.
        /// </summary>
        [JsonPropertyName("systemTasks")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<SystemTaskModel> SystemTasks { get; set; } = new System.Collections.ObjectModel.Collection<SystemTaskModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information about a work item's workflow history
    /// </summary>
    
    public partial class WorkItemWorkFlowHistoryModel
    {

        /// <summary>
        /// The date/time work item entered the queue.
        /// <br/> ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 Date and
        /// <br/>    time with milliseconds and without time zone.
        /// </summary>
        [JsonPropertyName("entryDate")]
        public string EntryDate { get; set; }

        /// <summary>
        /// The unique identifier of the user under which the work item entered queue.
        /// </summary>
        [JsonPropertyName("entryUserId")]
        public string EntryUserId { get; set; }

        /// <summary>
        /// The date/time the work item exited the queue. Field is excluded if work item has not exited the queue.
        /// <br/> ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 Date and
        /// <br/>    time with milliseconds and without time zone.
        /// </summary>
        [JsonPropertyName("exitDate")]
        public string ExitDate { get; set; }

        /// <summary>
        /// The unique identifier of the user under which the work item exited the queue or not included. Field is excluded if work item has not exited the queue.
        /// </summary>
        [JsonPropertyName("exitUserId")]
        public string ExitUserId { get; set; }

        /// <summary>
        /// The unique identifier of a life cycle
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public string LifeCycleId { get; set; }

        /// <summary>
        /// The unique identifier of a queue
        /// </summary>
        [JsonPropertyName("queueId")]
        public string QueueId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a workflow action or rule type
    /// </summary>
    
    public partial class TaskTypeModel
    {

        /// <summary>
        /// The unique identifier of the action or rule type
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the action or rule type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a workflow action.
    /// </summary>
    
    public partial class ActionModel
    {

        /// <summary>
        /// The unique identifier of the action.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the action.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The life cycle id this action is scoped to
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public string LifeCycleId { get; set; }

        /// <summary>
        /// The action type information.
        /// </summary>
        [JsonPropertyName("type")]
        public TaskTypeModel Type { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a list of workflow actions.
    /// </summary>
    
    public partial class ActionCollectionModel
    {

        /// <summary>
        /// List of actions
        /// </summary>
        [JsonPropertyName("items")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<ActionModel> Items { get; set; } = new System.Collections.ObjectModel.Collection<ActionModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a workflow rule.
    /// </summary>
    
    public partial class RuleModel
    {

        /// <summary>
        /// The unique identifier of the rule.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The life cycle id this rule is scoped to
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public string LifeCycleId { get; set; }

        /// <summary>
        /// The rule  type information.
        /// </summary>
        [JsonPropertyName("type")]
        public TaskTypeModel Type { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a list of workflow rules.
    /// </summary>
    
    public partial class RuleCollectionModel
    {

        /// <summary>
        /// List of rules
        /// </summary>
        [JsonPropertyName("items")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<RuleModel> Items { get; set; } = new System.Collections.ObjectModel.Collection<RuleModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a  workflow task list.
    /// </summary>
    
    public partial class TaskListModel
    {

        /// <summary>
        /// The unique identifier of the task list.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the task list.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The life cycle id this task list is scoped to
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public string LifeCycleId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a list of workflow task lists.
    /// </summary>
    
    public partial class TaskListCollectionModel
    {

        /// <summary>
        /// List of task lists
        /// </summary>
        [JsonPropertyName("items")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<TaskListModel> Items { get; set; } = new System.Collections.ObjectModel.Collection<TaskListModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Gets the API task with the associated id.
    /// </summary>
    
    public partial class ApiTaskModel
    {

        /// <summary>
        /// The unique identifier of the API task.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The system name of the API task.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// A list of API tasks.
    /// </summary>
    
    public partial class ApiTaskCollectionModel
    {

        /// <summary>
        /// List of API tasks.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<ApiTaskModel> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information required for workflow to execute an API task.
    /// </summary>
    
    public partial class ExecuteApiTaskModel
    {

        /// <summary>
        /// List of task interaction types the client supports.  An action or rule may perform
        /// <br/>a default operation if it is executed and wanted to require a task interaction
        /// <br/>that is not in this list.
        /// </summary>
        [JsonPropertyName("allowedInteractions")]
        // TODO(system.text.json): Add ItemConverterType with enum converter when supported
        public ICollection<TaskInteractionTypeEnum> AllowedInteractions { get; set; }

        /// <summary>
        /// JSON object passed to the execution of the API Task.  The configuration of the API task
        /// <br/>determines the format of this object.
        /// </summary>
        [JsonPropertyName("data")]
        public object Data { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a workflow approvals management approval role
    /// </summary>
    
    public partial class ApprovalRoleModel
    {

        /// <summary>
        /// The unique identifier of the approval role.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the approval role.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Information relating to a list of workflow approvals management approval roles
    /// </summary>
    
    public partial class ApprovalRoleCollectionModel
    {

        /// <summary>
        /// List of approval roles
        /// </summary>
        [JsonPropertyName("items")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<ApprovalRoleModel> Items { get; set; } = new System.Collections.ObjectModel.Collection<ApprovalRoleModel>();

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class Body
    {

        /// <summary>
        /// Type of query to execute.
        /// <br/> * `CurrentUserWorkItems`: If the queue is a:
        /// <br/>   * **Standard queue**: All work items in the queue will be returned.
        /// <br/>   * **Load balanced queue**: All work items assigned to the current user will be returned.
        /// <br/>   * **Queue contained in a life cycle supporting ownership**: All work items owned by the current user and all work items owned by no one will be returned.
        /// <br/>   * **Queue contained in a life cycle supporting ownership and load balanced**: All work items owned by the current user and all work items assigned to the current user (load balanced) will be returned.
        /// <br/>   * **Approval queue**: All work items that are waiting the current users approval will be returned.
        /// </summary>
        [JsonPropertyName("queryType")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public BodyQueryType QueryType { get; set; }

        /// <summary>
        /// If true and the queue has a default filter configured then the work items returned will be from the filter.
        /// <br/>Default is true.
        /// </summary>
        [JsonPropertyName("applyDefaultFilter")]
        public bool ApplyDefaultFilter { get; set; }

        /// <summary>
        /// If specified, the list of work items will be filtered. This property cannot be set with 'applyDefaultFilter' property.
        /// </summary>
        [JsonPropertyName("filterId")]
        public int FilterId { get; set; }

        /// <summary>
        /// Limits the number of results that the execution of a query can create.  Default is 2000 items.
        /// </summary>
        [JsonPropertyName("maxResults")]
        public int MaxResults { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class Response
    {

        /// <summary>
        /// The version of the core the REST APIs are using.
        /// </summary>
        [JsonPropertyName("coreVersion")]
        public string CoreVersion { get; set; }

        /// <summary>
        /// The version of the REST APIs.
        /// </summary>
        [JsonPropertyName("RestApiVersion")]
        public string RestApiVersion { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class Items : WorkItemIDModel
    {

        /// <summary>
        /// The reason why the task was not executed on the work item.
        /// <br/>- Locked: The work item was locked by another user.
        /// <br/>- NotInQueue: The work item was no longer in the queue.
        /// <br/>- NotOwnedByUser: The work item was not owned by the user and the task was configured to take ownership.
        /// <br/>- Other: The work item was not execute on due to other reasons.
        /// </summary>
        [JsonPropertyName("reason")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
public ItemsReason Reason { get; set; }

    }

    
    public partial class ApiTask
    {

        /// <summary>
        /// ID of the API task that was executed
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// If workflow was unable to find a work item to execute the API tasks On Found task list and the API task
        /// <br/>was configured to create a work item to execute its On Not Found task list then this object contains the
        /// <br/>information about the work item that was created.
        /// </summary>
        [JsonPropertyName("createdWorkItem")]
        public CreatedWorkItem CreatedWorkItem { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction
    {

        /// <summary>
        /// Id of the task that is about to be executed
        /// </summary>
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Determines if the taskId property is the id of an action, rule or task list
        /// </summary>
        [JsonPropertyName("taskType")]
public UserInteractionTaskType TaskType { get; set; }

        /// <summary>
        /// If an ad hoc task is being executed then this is the life cycle ID the task is contained in.
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public string LifeCycleId { get; set; }

        /// <summary>
        /// If an ad hoc task is being executed then this is the queue ID the task is contained in.
        /// </summary>
        [JsonPropertyName("queueId")]
        public string QueueId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction2
    {

        /// <summary>
        /// The message to display to the user asking if they would like
        /// <br/>to create the agenda item.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseCreateAgendaItemModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Yes")]
        Yes = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"No")]
        No = 1,

    }

    
    public partial class UserInteraction3
    {

        /// <summary>
        /// The HTML that should be displayed
        /// </summary>
        [JsonPropertyName("html")]
        public string Html { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction4
    {

        /// <summary>
        /// The default note text
        /// </summary>
        [JsonPropertyName("noteText")]
        public string NoteText { get; set; }

        /// <summary>
        /// Determines if the user should be able to view/modify the note text
        /// </summary>
        [JsonPropertyName("displayNoteText")]
        public bool DisplayNoteText { get; set; }

        /// <summary>
        /// Determines if the note text should be read-only
        /// </summary>
        [JsonPropertyName("noteTextReadOnly")]
        public bool NoteTextReadOnly { get; set; }

        /// <summary>
        /// Determines if the user should be able to select a page to add the note onto
        /// </summary>
        [JsonPropertyName("promptForPage")]
        public bool PromptForPage { get; set; }

        /// <summary>
        /// Determines if "Cancel" button should be displayed
        /// </summary>
        [JsonPropertyName("allowCancel")]
        public bool AllowCancel { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseCreateNoteModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"CreateNote")]
        CreateNote = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 1,

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseCreateNoteModelPageOption
    {

        [System.Runtime.Serialization.EnumMember(Value = @"FirstPage")]
        FirstPage = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"FirstNonBlankPage")]
        FirstNonBlankPage = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"LastPage")]
        LastPage = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"SpecifiedPage")]
        SpecifiedPage = 3,

    }

    
    public partial class UserInteraction5
    {

        /// <summary>
        /// The document ID of the electronic form to display
        /// </summary>
        [JsonPropertyName("documentId")]
        public string DocumentId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseDisplayElectronicFormModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Yes")]
        Yes = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"No")]
        No = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 2,

    }

    
    public partial class UserInteraction6
    {

        /// <summary>
        /// The HTML form to display
        /// </summary>
        [JsonPropertyName("html")]
        public string Html { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction7
    {

        /// <summary>
        /// The URL to display
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction8
    {

        /// <summary>
        /// The HTML to display
        /// </summary>
        [JsonPropertyName("html")]
        public string Html { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction9
    {

        /// <summary>
        /// The instance ID of the Unity form to display
        /// </summary>
        [JsonPropertyName("instanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language ID used when creating an Image form
        /// </summary>
        [JsonPropertyName("languageId")]
        public string LanguageId { get; set; }

        /// <summary>
        /// Determines if 'Discard and Continue' is allowed
        /// </summary>
        [JsonPropertyName("allowDiscardAndContinue")]
        public bool AllowDiscardAndContinue { get; set; }

        /// <summary>
        /// Determines if 'Discard and Cancel' is allowed
        /// </summary>
        [JsonPropertyName("allowDiscardAndCancel")]
        public bool AllowDiscardAndCancel { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseDisplayUnityFormModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Submit")]
        Submit = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"DiscardAndContinue")]
        DiscardAndContinue = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 2,

    }

    
    public partial class UserInteraction10
    {

        /// <summary>
        /// URL to display
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction11
    {

        /// <summary>
        /// List of work items the user can select from
        /// </summary>
        [JsonPropertyName("workItems")]
        public ICollection<WorkItemIDModel> WorkItems { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction12
    {

        /// <summary>
        /// Message to display to the user.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction13
    {

        /// <summary>
        /// Message to display to the user.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Text to display on the Yes button.
        /// </summary>
        [JsonPropertyName("yesButtonCaption")]
        public string YesButtonCaption { get; set; }

        /// <summary>
        /// Text to display on the No button.
        /// </summary>
        [JsonPropertyName("noButtonCaption")]
        public string NoButtonCaption { get; set; }

        /// <summary>
        /// Text to display on the Cancel button.
        /// </summary>
        [JsonPropertyName("cancelButtonCaption")]
        public string CancelButtonCaption { get; set; }

        /// <summary>
        /// Determines if the Cancel button should be displayed in the message prompt.
        /// </summary>
        [JsonPropertyName("includeCancelButton")]
        public bool IncludeCancelButton { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseQuestionBoxModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Yes")]
        Yes = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"No")]
        No = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 2,

    }

    
    public partial class UserInteraction14
    {

        /// <summary>
        /// List of certificates the user should choose from
        /// </summary>
        [JsonPropertyName("certificates")]
        public ICollection<X509Certificate2Model> Certificates { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseSignDocumentModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"CertificateSelected")]
        CertificateSelected = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 1,

    }

    
    public partial class UserInteraction15
    {

        /// <summary>
        /// The release date of the verion.  ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 Date ;/a&gt;.
        /// </summary>
        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseStampVersionModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"StampVersion")]
        StampVersion = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 1,

    }

    
    public partial class UserInteraction16
    {

        /// <summary>
        /// Id of the task that was executed
        /// </summary>
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Determines if the taskId property is the id of an action, rule or task list
        /// </summary>
        [JsonPropertyName("taskType")]
public UserInteraction16TaskType TaskType { get; set; }

        /// <summary>
        /// If an ad hoc task is being executed then this is the life cycle ID the task is contained in.
        /// </summary>
        [JsonPropertyName("lifeCycleId")]
        public string LifeCycleId { get; set; }

        /// <summary>
        /// If an ad hoc task is being executed then this is the queue ID the task is contained in.
        /// </summary>
        [JsonPropertyName("queueId")]
        public string QueueId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class UserInteraction17
    {

        /// <summary>
        /// Id of the auto fill keyword set
        /// </summary>
        [JsonPropertyName("autoFillKeywordSetId")]
        public string AutoFillKeywordSetId { get; set; }

        [JsonPropertyName("keywordSetInstances")]
        public ICollection<AutoFillKeywordSetDataModel> KeywordSetInstances { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseSelectAutoFillKeywordSetModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"InstanceSelected")]
        InstanceSelected = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 1,

    }

    
    public partial class UserInteraction18
    {

        /// <summary>
        /// List of OnBase user account ids
        /// </summary>
        [JsonPropertyName("userIds")]
        public ICollection<string> UserIds { get; set; }

        /// <summary>
        /// List of OnBase user accounts
        /// </summary>
        [JsonPropertyName("users")]
        public ICollection<IDAndNameModel> Users { get; set; }

        /// <summary>
        /// Instructions to display in the user interface
        /// </summary>
        [JsonPropertyName("instructions")]
        public string Instructions { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseSelectUserModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Selected")]
        Selected = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 1,

    }

    
    public partial class UserInteraction19
    {

        /// <summary>
        /// List of OnBase user group ids
        /// </summary>
        [JsonPropertyName("userGroupIds")]
        public ICollection<string> UserGroupIds { get; set; }

        /// <summary>
        /// List of OnBase user groups
        /// </summary>
        [JsonPropertyName("userGroups")]
        public ICollection<IDAndNameModel> UserGroups { get; set; }

        /// <summary>
        /// Instructions to display in the user interface
        /// </summary>
        [JsonPropertyName("instructions")]
        public string Instructions { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseSelectUserGroupModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Selected")]
        Selected = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 1,

    }

    
    public partial class UserInteraction20
    {

        /// <summary>
        /// List of OnBase role ids
        /// </summary>
        [JsonPropertyName("roleIds")]
        public ICollection<string> RoleIds { get; set; }

        /// <summary>
        /// List of OnBase roles
        /// </summary>
        [JsonPropertyName("roles")]
        public ICollection<IDAndNameModel> Roles { get; set; }

        /// <summary>
        /// Instructions to display in the user interface
        /// </summary>
        [JsonPropertyName("instructions")]
        public string Instructions { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExecuteTaskUIResponseSelectRoleModelResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Selected")]
        Selected = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Cancel")]
        Cancel = 1,

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DisplayColumnConfigurationModelType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Keyword")]
        Keyword = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Id")]
        Id = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Name")]
        Name = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"DocumentTypeId")]
        DocumentTypeId = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"DocumentDate")]
        DocumentDate = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"ArchivalDate")]
        ArchivalDate = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"Institution")]
        Institution = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"AuthorId")]
        AuthorId = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"AuthorName")]
        AuthorName = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"Batch")]
        Batch = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"RevisionCount")]
        RevisionCount = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"DocumentTypeGroup")]
        DocumentTypeGroup = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"DocumentTypeName")]
        DocumentTypeName = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"NoteContents")]
        NoteContents = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"NoteCount")]
        NoteCount = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"NoteTypeName")]
        NoteTypeName = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"WorkflowQueue")]
        WorkflowQueue = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"WorkflowAssignedTo")]
        WorkflowAssignedTo = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"WorkflowArrivalTime")]
        WorkflowArrivalTime = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"FullTextScore")]
        FullTextScore = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"FullTextFileTypeName")]
        FullTextFileTypeName = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"FullTextSummary")]
        FullTextSummary = 21,

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DisplayColumnConfigurationModelDataType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Numeric9")]
        Numeric9 = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Numeric20")]
        Numeric20 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Alphanumeric")]
        Alphanumeric = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Currency")]
        Currency = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"SpecificCurrency")]
        SpecificCurrency = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Date")]
        Date = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"DateTime")]
        DateTime = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"FloatingPoint")]
        FloatingPoint = 7,

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QueueQueryWorkItemResultModelWorkItemType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Document")]
        Document = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Folder")]
        Folder = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"WorkView")]
        WorkView = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Entity")]
        Entity = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"EISMessageItem")]
        EISMessageItem = 4,

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BodyQueryType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"CurrentUserWorkItems")]
        CurrentUserWorkItems = 0,

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ItemsReason
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Locked")]
        Locked = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"NotInQueue")]
        NotInQueue = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"NotOwnedByUser")]
        NotOwnedByUser = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Other")]
        Other = 3,

    }

    
    public partial class CreatedWorkItem : WorkItemIDModel
    {

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserInteractionTaskType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Action")]
        Action = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Rule")]
        Rule = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"TaskList")]
        TaskList = 2,

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserInteraction16TaskType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Action")]
        Action = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Rule")]
        Rule = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"TaskList")]
        TaskList = 2,

    }

    
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple = true)]
    internal class JsonInheritanceAttribute : System.Attribute
    {
        public JsonInheritanceAttribute(string key, System.Type type)
        {
            Key = key;
            Type = type;
        }

        public string Key { get; }

        public System.Type Type { get; }
    }

    
    internal class JsonInheritanceConverterAttribute : JsonConverterAttribute
    {
        public string DiscriminatorName { get; }

        public JsonInheritanceConverterAttribute(System.Type baseType, string discriminatorName = "discriminator")
            : base(typeof(JsonInheritanceConverter<>).MakeGenericType(baseType))
        {
            DiscriminatorName = discriminatorName;
        }
    }

    public class JsonInheritanceConverter<TBase> : JsonConverter<TBase>
    {
        private readonly string _discriminatorName;

        public JsonInheritanceConverter()
        {
            var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<JsonInheritanceConverterAttribute>(typeof(TBase));
            _discriminatorName = attribute?.DiscriminatorName ?? "discriminator";
        }

        public JsonInheritanceConverter(string discriminatorName)
        {
            _discriminatorName = discriminatorName;
        }

        public string DiscriminatorName { get { return _discriminatorName; } }

        public override TBase Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
        {
            var document = System.Text.Json.JsonDocument.ParseValue(ref reader);
            var hasDiscriminator = document.RootElement.TryGetProperty(_discriminatorName, out var discriminator);
            var subtype = GetDiscriminatorType(document.RootElement, typeToConvert, hasDiscriminator ? discriminator.GetString() : null);

            var bufferWriter = new System.IO.MemoryStream();
            using (var writer = new System.Text.Json.Utf8JsonWriter(bufferWriter))
            {
                document.RootElement.WriteTo(writer);
            }

            return (TBase)System.Text.Json.JsonSerializer.Deserialize(bufferWriter.ToArray(), subtype, options);
        }

        public override void Write(System.Text.Json.Utf8JsonWriter writer, TBase value, System.Text.Json.JsonSerializerOptions options)
        {
            if (value != null)
            {
                writer.WriteStartObject();
                writer.WriteString(_discriminatorName, GetDiscriminatorValue(value.GetType()));

                var bytes = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes((object)value, options);
                var document = System.Text.Json.JsonDocument.Parse(bytes);
                foreach (var property in document.RootElement.EnumerateObject())
                {
                    property.WriteTo(writer);
                }

                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }
        }

        public string GetDiscriminatorValue(System.Type type)
        {
            var jsonInheritanceAttributeDiscriminator = GetSubtypeDiscriminator(type);
            if (jsonInheritanceAttributeDiscriminator != null)
            {
                return jsonInheritanceAttributeDiscriminator;
            }

            return type.Name;
        }

        protected System.Type GetDiscriminatorType(System.Text.Json.JsonElement jObject, System.Type objectType, string discriminatorValue)
        {
            if (discriminatorValue != null)
            {
                var jsonInheritanceAttributeSubtype = GetObjectSubtype(objectType, discriminatorValue);
                if (jsonInheritanceAttributeSubtype != null)
                {
                    return jsonInheritanceAttributeSubtype;
                }

                if (objectType.Name == discriminatorValue)
                {
                    return objectType;
                }

                var typeName = objectType.Namespace + "." + discriminatorValue;
                var subtype = System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType).Assembly.GetType(typeName);
                if (subtype != null)
                {
                    return subtype;
                }
            }

            throw new System.InvalidOperationException("Could not find subtype of '" + objectType.Name + "' with discriminator '" + discriminatorValue + "'.");
        }

        private System.Type GetObjectSubtype(System.Type baseType, string discriminatorValue)
        {
            foreach (var attribute in System.Reflection.CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(System.Reflection.IntrospectionExtensions.GetTypeInfo(baseType), true))
            {
                if (attribute.Key == discriminatorValue)
                    return attribute.Type;
            }

            return null;
        }

        private string GetSubtypeDiscriminator(System.Type objectType)
        {
            foreach (var attribute in System.Reflection.CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType), true))
            {
                if (attribute.Type == objectType)
                    return attribute.Key;
            }

            return null;
        }
    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore  649
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8600
#pragma warning restore 8602
#pragma warning restore 8603
#pragma warning restore 8604
#pragma warning restore 8625
#pragma warning restore 8765