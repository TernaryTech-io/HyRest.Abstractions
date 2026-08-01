using Refit;
using System.Text.Json.Serialization;


namespace HyRest.API
{
    /// <summary>OnBase Forms REST API</summary>
    [System.CodeDom.Compiler.GeneratedCode("Refitter", "2.0.0.0")]
    public partial interface IOnBaseFormsAPI : IHylandRestAPI
    {
        /// <summary>Gets E-Form templates</summary>
        /// <remarks>Returns E-Form templates.</remarks>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="creatable">Specifies whether or not only the logged in user's creatable templates will be returned.</param>
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
        [Get("/e-form-templates")]
        Task<EFormTemplateCollection> GetEFormTemplateCollection([Query] bool? creatable, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the latest or a given revision E-Form.</summary>
        /// <remarks>
        /// Specify `revisionId` to retrieve a specific idempotent revision of the E-Form. Otherwise, the latest revision will be retrieved.
        /// Returns `404` NotFound if there is not an E-Form rendition for the specified document or no such specified revision for the E-Form.
        /// </remarks>
        /// <param name="documentId">The unique identifier of a document.</param>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="revisionId">The unique id for the E-Form Revision.</param>
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
        [Get("/e-forms/{documentId}")]
        Task<EForm> GetEForm(string documentId, [Query] string revisionId, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>
        /// Gets Unity Form templates.
        /// Returns Unity Form templates.
        /// </summary>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="creatable">Specifies whether or not only the logged in user's creatable templates will be returned.</param>
        /// <param name="includeFieldSecurityProperties">Specifies whether the field security properties such as `editable` and `visible` will be included.</param>
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
        [Get("/unity-form-templates")]
        Task<UnityFormTemplateCollection> GetUnityFormTemplateCollection([Query] bool? creatable, [Query] bool? includeFieldSecurityProperties, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets Unity Form template metadata</summary>
        /// <remarks>Gets Unity Form template metadata</remarks>
        /// <param name="unityFormTemplateId">The identifier of the Unity Form template.</param>
        /// <param name="includeFieldSecurityProperties">Specifies whether the field security properties such as `editable` and `visible` will be included.</param>
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
        [Get("/unity-form-templates/{unityFormTemplateId}")]
        Task<UnityFormTemplate> GetUnityFormTemplateById(string unityFormTemplateId, [Query] bool? includeFieldSecurityProperties, [Header("Accept-Language")] string accept_Language = "en-US");

        /// <summary>Gets the latest or a given revision Unity Form.</summary>
        /// <remarks>Specify `revisionId` to retrieve a specific idempotent revision of the Unity Form. Otherwise, the latest revision will be retrieved. Returns `404` NotFound if there is not a Unity Form rendition for the specified document or no such specified revision for the Unity Form.</remarks>
        /// <param name="documentId">The unique identifier of a document.</param>
        /// <param name="accept_Language">
        /// The  ;a href="https://tools.ietf.org/html/rfc7231#section-5.3.5"&gt;Accept-Language ;/a&gt;
        /// header field can be used by user agents to
        /// indicate the set of natural languages that are preferred in the
        /// response.  Language tags are defined in RFC 5646. If none of the
        /// languages given are supported, a default language will be returned.
        /// </param>
        /// <param name="revisionId">The unique id for the Unity Form Revision.</param>
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
        [Get("/unity-forms/{documentId}")]
        Task<UnityForm> GetUnityForm(string documentId, [Query] string revisionId, [Header("Accept-Language")] string accept_Language = "en-US");


    }

}


namespace HyRest.API
{
    using System = global::System;

    

    /// <summary>
    /// A collection of E-Form templates.
    /// </summary>
    
    public partial class EFormTemplateCollection
    {

        /// <summary>
        /// A collection of E-Form templates.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<EFormTemplate> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// E-Form template metadata.
    /// </summary>
    
    public partial class EFormTemplate
    {

        /// <summary>
        /// The localized name of the E-Form template.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The untranslated system name of the E-Form template.
        /// <br/>Localization is controlled by the Accept-Language header and
        /// <br/>the language of the response is represented by the Content-Language
        /// <br/>header.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The unique identifier of the document type for the E-Form template.
        /// </summary>
        [JsonPropertyName("documentTypeId")]
        public string DocumentTypeId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class EForm
    {

        /// <summary>
        /// The unique id for the E-Form Revision.
        /// </summary>
        [JsonPropertyName("revisionId")]
        public string RevisionId { get; set; }

        /// <summary>
        /// The list of fields for the E-Form.
        /// </summary>
        [JsonPropertyName("fields")]
        public ICollection<EFormField> Fields { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class EFormField
    {

        /// <summary>
        /// The name of the field.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the field.
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
    /// A collection of Unity Form templates.
    /// </summary>
    
    public partial class UnityFormTemplateCollection
    {

        /// <summary>
        /// A collection of Unity Form templates.
        /// </summary>
        [JsonPropertyName("items")]
        public ICollection<UnityFormTemplate> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Unity Form template metadata.
    /// </summary>
    
    public partial class UnityFormTemplate
    {

        /// <summary>
        /// The unique identifier of the Unity Form template.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The localized name of the Unity Form template.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The untranslated system name of the Unity Form template.
        /// <br/>Localization is controlled by the Accept-Language header and
        /// <br/>the language of the response is represented by the Content-Language
        /// <br/>header.
        /// </summary>
        [JsonPropertyName("systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// The type of Unity Form template.
        /// <br/>`Html` represents an Html Form.
        /// <br/>`Image` represents an Image Form.
        /// </summary>
        [JsonPropertyName("type")]
public UnityFormTemplateType Type { get; set; }

        /// <summary>
        /// The boolean value representing whether or not the template is creatable.
        /// </summary>
        [JsonPropertyName("creatable")]
        public bool Creatable { get; set; }

        /// <summary>
        /// The unique identifier of the document type for the Unity Form template.
        /// </summary>
        [JsonPropertyName("documentTypeId")]
        public string DocumentTypeId { get; set; }

        /// <summary>
        /// The revision number for display and ordering purposes of the Unity Form template.
        /// </summary>
        [JsonPropertyName("revisionNumber")]
        public int RevisionNumber { get; set; }

        /// <summary>
        /// The collection of form field definitions on the Unity Form template.
        /// </summary>
        [JsonPropertyName("formFieldDefinitions")]
        public ICollection<CalculatedFieldDefinition> FormFieldDefinitions { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class DefinitionCommon : DiscriminatorObject
    {

        /// <summary>
        /// The name of the definition.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns whether or not the field is editable. The property will be Omitted if `includeFieldSecurityProperties` is false.
        /// </summary>
        [JsonPropertyName("editable")]
        public bool? Editable { get; set; }

        /// <summary>
        /// Returns whether or not the field is visible to the user. The property will be Omitted if `includeFieldSecurityProperties` is false.
        /// </summary>
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

    }

    
    public partial class FieldDefinition
    {

        /// <summary>
        /// The name of the field definition.
        /// </summary>
        [JsonPropertyName("name")]
        public object Name { get; set; }

        /// <summary>
        /// Describes the type of data represented by the keyword type or field definition.
        /// <br/>
        /// <br/>`Numeric9` represents a number up to 9 digits in length.
        /// <br/>
        /// <br/>`Numeric20` represents a number up to 20 digits in length.
        /// <br/>
        /// <br/>`Alphanumeric` represents any value with letters and/or numbers.
        /// <br/>
        /// <br/>`Currency` represents a monetary value.
        /// <br/>
        /// <br/>`Date` represents a date.
        /// <br/>
        /// <br/>`DateTime` represents both a date and a time.
        /// <br/>
        /// <br/>`Decimal` represents a high-precision decimal value (128-bit).
        /// <br/>
        /// <br/>`FloatingPoint` represents numeric values that have variable decimal
        /// <br/> point locations.
        /// <br/>
        /// <br/>`Boolean` represents a true or false value
        /// </summary>
        [JsonPropertyName("dataType")]
public FieldDefinitionDataType DataType { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// A nested table definition.
    /// </summary>
    
    public partial class NestedTableDefinition : DefinitionCommon
    {

        /// <summary>
        /// The child (sub) nested table definition under the top nested table definition.
        /// </summary>
        [JsonPropertyName("childNestedTableDefinition")]
        public NestedTableDefinition ChildNestedTableDefinition { get; set; }

        /// <summary>
        /// The collection of field definitions on the Unity Form template.
        /// </summary>
        [JsonPropertyName("fieldDefinitions")]
        public ICollection<CalculatedFieldDefinition> FieldDefinitions { get; set; }

    }

    /// <summary>
    /// A repeater field definition.
    /// </summary>
    
    public partial class RepeaterDefinition : DefinitionCommon
    {

        /// <summary>
        /// The ID of the keyword type group associated with the Repeater.
        /// </summary>
        [JsonPropertyName("keywordTypeGroupId")]
        public string KeywordTypeGroupId { get; set; }

        /// <summary>
        /// The collection of field definitions on the Unity Form template.
        /// </summary>
        [JsonPropertyName("fieldDefinitions")]
        public ICollection<CalculatedFieldDefinition> FieldDefinitions { get; set; }

    }

    /// <summary>
    /// Calculated field definition for a Unity Form template.
    /// </summary>
    
    public partial class CalculatedFieldDefinition : DefinitionCommon
    {              
        /// <summary>
        /// Describes the type of data represented by the keyword type or field definition.
        /// <br/>
        /// <br/>`Numeric9` represents a number up to 9 digits in length.
        /// <br/>
        /// <br/>`Numeric20` represents a number up to 20 digits in length.
        /// <br/>
        /// <br/>`Alphanumeric` represents any value with letters and/or numbers.
        /// <br/>
        /// <br/>`Currency` represents a monetary value.
        /// <br/>
        /// <br/>`Date` represents a date.
        /// <br/>
        /// <br/>`DateTime` represents both a date and a time.
        /// <br/>
        /// <br/>`Decimal` represents a high-precision decimal value (128-bit).
        /// <br/>
        /// <br/>`FloatingPoint` represents numeric values that have variable decimal
        /// <br/> point locations.
        /// <br/>
        /// <br/>`Boolean` represents a true or false value
        /// </summary>
        [JsonPropertyName("dataType")]
public FieldDefinitionDataType DataType { get; set; }

    }

    /// <summary>
    /// Value field definition for a Unity Form template.
    /// </summary>
    
    public partial class ValueFieldDefinition : DefinitionCommon
    {

        /// <summary>
        /// The unique identifier of the currency format, if applicable.
        /// </summary>
        [JsonPropertyName("currencyFormatId")]
        public string CurrencyFormatId { get; set; }

        /// <summary>
        /// The default value of the field, if applicable.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The unique identifier of the keyword type, if applicable.
        /// </summary>
        [JsonPropertyName("keywordTypeId")]
        public string KeywordTypeId { get; set; }

        /// <summary>
        /// The mask, if applicable.
        /// </summary>
        [JsonPropertyName("mask")]
        public string Mask { get; set; }

        /// <summary>
        /// The maximum length of the value field.
        /// </summary>
        [JsonPropertyName("maximumLength")]
        public string MaximumLength { get; set; }

        /// <summary>
        /// The boolean value representing whether or not the value field is required.
        /// </summary>
        [JsonPropertyName("required")]
        public bool Required { get; set; }

        /// <summary>
        /// The workflow property represented by the value field definition.
        /// </summary>
        [JsonPropertyName("workflowProperty")]
        public string WorkflowProperty { get; set; }

        /// <summary>
        /// The name of the field definition.
        /// </summary>
        [JsonPropertyName("name")]
        public object Name { get; set; }

        /// <summary>
        /// Describes the type of data represented by the keyword type or field definition.
        /// <br/>
        /// <br/>`Numeric9` represents a number up to 9 digits in length.
        /// <br/>
        /// <br/>`Numeric20` represents a number up to 20 digits in length.
        /// <br/>
        /// <br/>`Alphanumeric` represents any value with letters and/or numbers.
        /// <br/>
        /// <br/>`Currency` represents a monetary value.
        /// <br/>
        /// <br/>`Date` represents a date.
        /// <br/>
        /// <br/>`DateTime` represents both a date and a time.
        /// <br/>
        /// <br/>`Decimal` represents a high-precision decimal value (128-bit).
        /// <br/>
        /// <br/>`FloatingPoint` represents numeric values that have variable decimal
        /// <br/> point locations.
        /// <br/>
        /// <br/>`Boolean` represents a true or false value
        /// </summary>
        [JsonPropertyName("dataType")]
public FieldDefinitionDataType DataType { get; set; }

    }

    /// <summary>
    /// Unity Form metadata
    /// </summary>
    
    public partial class UnityForm
    {

        /// <summary>
        /// The unique identifier of the Unity Form template
        /// </summary>
        [JsonPropertyName("templateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// The unique id for the Unity Form Revision.
        /// </summary>
        [JsonPropertyName("revisionId")]
        public string RevisionId { get; set; }

        /// <summary>
        /// The collection of fields on the Unity Form
        /// </summary>
        [JsonPropertyName("formFields")]
        public ICollection<Field> FormFields { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Represents a Field object
    /// </summary>
    
    public partial class Field : FormFieldCommon
    {

        /// <summary>
        /// The value of the field
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

    }

    /// <summary>
    /// Represents a Repeater object
    /// </summary>
    
    public partial class Repeater : FormFieldCommon
    {

        [JsonPropertyName("repeaterItems")]
        public ICollection<RepeaterItem> RepeaterItems { get; set; }

    }

    
    public partial class RepeaterItem
    {

        /// <summary>
        /// An array of fields.
        /// </summary>
        [JsonPropertyName("fields")]
        public ICollection<Field> Fields { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Represents a NestedTable
    /// </summary>
    
    public partial class NestedTable : FormFieldCommon
    {

        [JsonPropertyName("nestedTableItems")]
        public ICollection<NestedTableItem> NestedTableItems { get; set; }

    }

    
    public partial class NestedTableItem
    {

        /// <summary>
        /// The child (sub) nested table under the top nested table.
        /// </summary>
        [JsonPropertyName("childNestedTable")]
        public NestedTable ChildNestedTable { get; set; }

        /// <summary>
        /// An array of fields.
        /// </summary>
        [JsonPropertyName("fields")]
        public ICollection<Field> Fields { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial class FormFieldCommon : DiscriminatorObject
    {

        /// <summary>
        /// The name of the field definition.
        /// </summary>
        [JsonPropertyName("definitionName")]
        public string DefinitionName { get; set; }

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
    
    public partial class ProblemDetail
    {

        /// <summary>
        /// An absolute URI that identifies the problem type.  When
        /// <br/>dereferenced, it should provide human-readable documentation
        /// <br/>for the problem type (e.g., using HTML).
        /// </summary>
        [JsonPropertyName("type")]
        public System.Uri Type { get; set; }

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
        public System.Uri Instance { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// The generic type with a discriminator property, which is an object type name
    /// <br/>that is used to differentiate between other schemas which may satisfy
    /// <br/>the payload description.
    /// </summary>
    
    public partial class DiscriminatorObject
    {

        /// <summary>
        /// The object type of the schema specified for the request body or used for the response payload.          
        /// </summary>
        [JsonPropertyName("objectType")]
        public string ObjectType { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnityFormTemplateType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Html")]
        Html = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Image")]
        Image = 1,

    }

    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FieldDefinitionDataType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Numeric9")]
        Numeric9 = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Numeric20")]
        Numeric20 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Alphanumeric")]
        Alphanumeric = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Currency")]
        Currency = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Date")]
        Date = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"DateTime")]
        DateTime = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"Decimal")]
        Decimal = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"FloatingPoint")]
        FloatingPoint = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"Boolean")]
        Boolean = 8,

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