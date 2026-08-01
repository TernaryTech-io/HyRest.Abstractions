using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HyRest.API.Models;

/// <summary>
/// System Insight Discovery Setting data.
/// </summary>

public partial class InsightDiscoverySysteminformationModel : HylandBase
{

    /// <summary>
    /// The unique identifier representing the environment in which the system operates.
    /// </summary>
    [JsonPropertyName("environmentGuid")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? EnvironmentGuid { get; set; }

    /// <summary>
    /// The unique identifier of the client to authenticate it for communication with the Insight Discovery.
    /// </summary>
    [JsonPropertyName("clientId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? ClientId { get; set; }

    /// <summary>
    /// The confidential client secret received from the Insight Discovery platform.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? ClientSecret { get; set; }

    /// <summary>
    /// The unique identifier for the source system from which the request originates.
    /// </summary>
    [JsonPropertyName("sourceGuid")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? SourceGuid { get; set; }
}

/// <summary>
/// Collection to relate to documents types to be processed by the Insight Discovery.
/// </summary>

public partial class InsightDiscoveryCollection
{

    /// <summary>
    /// The unique identifier representing the Insight Collection to relate to documents types
    /// </summary>
    [JsonPropertyName("id")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Id { get; set; }

    /// <summary>
    /// The name of the Insight Collection to relate to documents types
    /// </summary>
    [JsonPropertyName("name")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
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
/// An array of Insight Discovery Collection.
/// </summary>

public partial class InsightDiscoveryCollectionCollection
{
    /// <summary>
    /// An array of Insight Discovery collection.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<InsightDiscoveryCollection> Items { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}

/// <summary>
/// An assignment of a document type to a insight collection.
/// </summary>

public partial class InsightCollectionDocumentTypeAssignment
{

    /// <summary>
    /// Id of the insight collection.
    /// </summary>
    [JsonPropertyName("insightCollectionId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string InsightCollectionId { get; set; }

    /// <summary>
    /// Id of the document type.
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DocumentTypeId { get; set; }

    /// <summary>
    /// Document creation date.
    /// </summary>
    [JsonPropertyName("beginDate")]
    public string BeginDate { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}

/// <summary>
/// An array of insight collection, document type assignments.
/// </summary>

public partial class InsightCollectionDocumentTypeAssignmentCollection
{

    /// <summary>
    /// An array of insight collection, document type assignments.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<InsightCollectionDocumentTypeAssignment> Items { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}

/// <summary>
/// An assignment of a keyword type to a insight collection.
/// </summary>

public partial class InsightCollectionKeywordTypeAssignment
{

    /// <summary>
    /// Id of the insight collection.
    /// </summary>
    [JsonPropertyName("insightCollectionId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string InsightCollectionId { get; set; }

    /// <summary>
    /// Id of the item type.
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DocumentTypeId { get; set; }

    /// <summary>
    /// Id of the keyword type.
    /// </summary>
    [JsonPropertyName("keywordTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string KeywordTypeId { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}

/// <summary>
/// An array of insight collection, keyword type assignments.
/// </summary>

public partial class InsightCollectionKeywordTypeAssignmentCollection
{

    /// <summary>
    /// An array of insight collection, keyword type assignments.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<InsightCollectionKeywordTypeAssignment> Items { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}

/// <summary>
/// An assignment of a file type to a insight collection.
/// </summary>

public partial class InsightCollectionFileTypesAssignment
{

    /// <summary>
    /// Id of the insight collection.
    /// </summary>
    [JsonPropertyName("insightCollectionId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string InsightCollectionId { get; set; }

    /// <summary>
    /// Id of the item type.
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DocumentTypeId { get; set; }

    /// <summary>
    /// Id of the file type.
    /// </summary>
    [JsonPropertyName("fileTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string FileTypeId { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}

/// <summary>
/// An array of insight collection, file type assignments.
/// </summary>
public partial class InsightCollectionFileTypesAssignmentCollection
{

    /// <summary>
    /// An array of insight collection, file type assignments.
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<InsightCollectionFileTypesAssignment> Items { get; set; }

    private IDictionary<string, object> _additionalProperties;

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
        set { _additionalProperties = value; }
    }

}