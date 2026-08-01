using System.Text.Json.Serialization;

namespace HyRest;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentTypeGroupDocumentSource
{

    [System.Runtime.Serialization.EnumMember(Value = @"Normal")]
    Normal = 0,

    [System.Runtime.Serialization.EnumMember(Value = @"GroupEnabled")]
    GroupEnabled = 1,

    [System.Runtime.Serialization.EnumMember(Value = @"OleAPI")]
    OleAPI = 2,

    [System.Runtime.Serialization.EnumMember(Value = @"DMA")]
    DMA = 3,

    [System.Runtime.Serialization.EnumMember(Value = @"Catalog")]
    Catalog = 4,

}