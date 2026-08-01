using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// Meta-data information about the file being uploaded.
/// </summary>    
public partial class UploadPostRequestModel : HylandBase
{
    /// <summary>
    /// Extension of the file being uploaded. The extension does not need a leading period `.`
    /// </summary>
    [JsonPropertyName("fileExtension")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string FileExtension { get; set; }

    /// <summary>
    /// Size of the file in bytes. Recommended maximum size of a file is 4GB, but the maximum size is only limited by the programming language being used and the host's file system.
    /// </summary>
    [JsonPropertyName("fileSize")]
    public long FileSize { get; set; }
}
/// <summary>
/// Unique file reference corresponding to the uploaded file.
/// </summary>    
public partial class UploadsPostResponseModel : HylandBase
{
    /// <summary>
    /// Unique reference for the uploaded file
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Size in bytes of the file parts that will be uploaded. All file parts except the last one must be of size filePartSize. Last part will be either less than or equal to filePartSize.
    /// </summary>
    [JsonPropertyName("filePartSize")]
    public int FilePartSize { get; set; }

    /// <summary>
    /// Total number of parts a file must be divided into when uploading. This must be used in conjunction with filePartSize.
    /// </summary>
    [JsonPropertyName("numberOfParts")]
    public int NumberOfParts { get; set; }
}

//public partial class FileParameterModel
//{
//    public FileParameterModel(Stream data)
//        : this(data, null, null)
//    {
//    }

//    public FileParameterModel(Stream data, string fileName)
//        : this(data, fileName, null)
//    {
//    }

//    public FileParameterModel(Stream data, string fileName, string? contentType)
//    {
//        Data = data;
//        FileName = fileName;
//        ContentType = contentType;
//    }

//    public Stream Data { get; private set; }

//    public string FileName { get; private set; }

//    public string? ContentType { get; private set; }
//}



/// <summary>
/// Reference to an uploaded file.
/// </summary>    
public partial class UploadModel : HylandBase
{
    public required string Id { get; set; }
}


/// <summary>
/// Meta-data information required to upload documents
/// </summary>
public partial class DocumentArchivePropertiesModel : HylandBase
{

    /// <summary>
    /// The Id of the document type to store the document into
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DocumentTypeId { get; set; }

    /// <summary>
    /// Id of the file Type for the document.
    /// </summary>
    [JsonPropertyName("fileTypeId")]
    public string FileTypeId { get; set; }

    /// <summary>
    /// Boolean indicating if the document should be stored as a new document.
    /// <br/>This should be used in conjunction with a Revisable/Renditionable document type to indicate that the document should be stored as a new document regardless of the settings.
    /// <br/>This would be considered false by default and if it's a Revisable/Renditionable document type, existing documents are checked to find matching documents for which this new document can be added as a Revision/Rendition.
    /// </summary>
    [JsonPropertyName("storeAsNew")]
    public bool StoreAsNew { get; set; }

    /// <summary>
    /// Comments if the document type is Revisable/Renditionable.
    /// </summary>
    [JsonPropertyName("comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Document's date
    /// </summary>
    [JsonPropertyName("documentDate")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset DocumentDate { get; set; }

    /// <summary>
    /// List of references to uploaded files. The order of uploaded file references will be used for the document page order.
    /// </summary>
    [JsonPropertyName("uploads")]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<UploadModel> Uploads { get; set; } = [];

    /// <summary>
    /// An array of keywords grouped by the keyword group they belong to.
    /// </summary>
    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; }
}

/// <summary>
/// Meta-data information required to upload revision
/// </summary>

public partial class RevisionArchivePropertiesModel : DiscriminatorObject
{

    /// <summary>
    /// Comment for the revision
    /// </summary>
    [JsonPropertyName("comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Id of the File Type for the document. If File Type Id is not provided, Document Type's default File Type will be used.
    /// </summary>
    [JsonPropertyName("fileTypeId")]
    public string FileTypeId { get; set; }

    /// <summary>
    /// List of references to uploaded files. The order of uploaded file references will be used for the document page order.
    /// </summary>
    [JsonPropertyName("uploads")]
    public ICollection<UploadModel> Uploads { get; set; }

    /// <summary>
    /// An array of keywords grouped by the keyword group they belong to.
    /// </summary>
    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; }

}

/// <summary>
/// Meta-data information required to upload rendition
/// </summary>

public partial class RenditionArchivePropertiesModel : DiscriminatorObject
{

    /// <summary>
    /// Comment for the rendition
    /// </summary>
    [JsonPropertyName("comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Id of the File Type for the document. If a File Type Id is not provided, then the Document Type's default File Type ID will be used. If the revision already contains the File Type Id then 400 Bad Request will be returned.
    /// </summary>
    [JsonPropertyName("fileTypeId")]
    public string FileTypeId { get; set; }

    /// <summary>
    /// List of references to uploaded files. The order of uploaded file references will be used for the document page order.
    /// </summary>
    [JsonPropertyName("uploads")]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<UploadModel> Uploads { get; set; } = [];

    /// <summary>
    /// An array of keywords grouped by the keyword group they belong to.
    /// </summary>
    [JsonPropertyName("keywordCollection")]
    public KeywordCollectionModel KeywordCollection { get; set; }

}

public class ReindexPutResponseModel : HylandBase
{
    [JsonPropertyName("canAddAsNew")]
    public bool CanAddAsNew { get; set; }
    [JsonPropertyName("items")]
    public ICollection<ReindexResponseItemsModel> Items { get; set; } = [];
}

public class ReindexResponseItemsModel
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("canAddAsRevision")]
    public bool CanAddAsRevision { get; set; }
    [JsonPropertyName("canAddAsRendition")]
    public bool CanAddAsRendition { get; set; }
}
