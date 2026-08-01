using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// File type metadata.
/// </summary>

public partial class FileTypeModel : OnBaseItemType
{
    /// <summary>
    /// The extension of the file type. '???' represents no associated
    /// <br/>extension.
    /// </summary>
    [JsonPropertyName("extension")]
    public string Extension { get; set; } = "???";

    /// <summary>
    /// This represents the type of viewer for the file type.
    /// </summary>
    [JsonPropertyName("commandLine")]
    public string CommandLine { get; set; } = "";

    /// <summary>
    /// This represents the display type for the file type.
    /// </summary>
    [JsonPropertyName("displayType")]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string DisplayType { get; set; }

    /// <summary>
    /// The media type for the file type, if one exists.
    /// </summary>
    [JsonPropertyName("mediaType")]
    public string MediaType { get; set; } = "";

    /// <summary>
    /// Indicates if security is disabled for this File Type.
    /// </summary>
    [JsonPropertyName("disableSecurity")]
    public bool DisableSecurity { get; set; } = false;

    /// <summary>
    /// Indicates if verity is disabled for this File Type.
    /// </summary>
    [JsonPropertyName("disableVerity")]
    public bool DisableVerity { get; set; } = false;

    /// <summary>
    /// Indicates if is ExternalEngineering is enabled for this File Type.
    /// </summary>
    [JsonPropertyName("externalEngineering")]
    public bool ExternalEngineering { get; set; } = false;

    /// <summary>
    /// Indicates if is PCLBestFit is enabled for this File Type.
    /// </summary>
    [JsonPropertyName("pclBestFit")]
    public bool PclBestFit { get; set; } = false;

    /// <summary>
    /// This represents the print type for the file type.
    /// </summary>
    [JsonPropertyName("printType")]
    public long PrintType { get; set; } = 0L;
}
public partial class DisplayTypeWithValuesCollectionModel : OnBaseItemTypeCollection<DisplayTypeModel>
{

}

/// <summary>
/// Display type metadata.
/// </summary>

public partial class DisplayTypeModel : OnBaseItemType
{
    private string SystemName { get; set; } = "";
}