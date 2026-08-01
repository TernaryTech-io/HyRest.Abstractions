using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// An Array of revisions.
/// </summary>    
public partial class RevisionCollectionModel : OnBaseItemCollection<RevisionModel>
{

}

/// <summary>
/// Revision metadata
/// </summary>    
public partial class RevisionModel : OnBaseItem
{

    [JsonPropertyName("revisionId")]
    public override string Id { get => base.Id; set => base.Id = value; }

    /// <summary>
    /// The revision number for display purposes and provide ordering of revisions.
    /// </summary>
    [JsonPropertyName("revisionNumber")]
    public int RevisionNumber { get; set; }

    [JsonIgnore]
    public List<NoteModel> Notes { get; set; } = [];

    [JsonIgnore]
    public List<RenditionModel> Renditions { get; set; } = [];
}


