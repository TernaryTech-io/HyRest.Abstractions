
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

public partial class NoteCollectionModel : OnBaseItemCollection<NoteModel>
{

}

public partial class NoteModel : OnBaseItem
{    
    /// <summary>
    /// The note type identifier of the note.
    /// </summary>
    [JsonPropertyName("noteTypeId")]
    public string? NoteTypeId { get; set; }

    /// <summary>
    /// The title of the note.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The text in the note.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// The unique id of the user this note was created by.
    /// </summary>
    [JsonPropertyName("createdUserId")]
    public string? CreatedUserId { get; set; }

    /// <summary>
    /// The date the note was created.
    /// </summary>
    [JsonPropertyName("created")]
    public string? Created { get; set; }

    /// <summary>
    /// The unique id of the document the note is affiliated with.
    /// </summary>
    [JsonPropertyName("documentId")]
    public string? DocumentId { get; set; }

    /// <summary>
    /// The revision number that the note is affiliated with.
    /// </summary>
    [JsonPropertyName("documentRevisionId")]
    public string? DocumentRevisionId { get; set; }

    /// <summary>
    /// The page the note is on.
    /// </summary>
    [JsonPropertyName("page")]
    public long Page { get; set; }

    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <summary>
    /// The user's privileges for the note.
    /// </summary>
    [JsonPropertyName("privileges")]
    public NotePrivileges Privileges { get; set; } = new();

    /// <summary>
    /// The flag values set for the note.
    /// </summary>
    [JsonPropertyName("displayFlags")]
    public NoteDisplayFlags DisplayFlags { get; set; } = new();

    public UpdateNoteProperties CreateUpdateNoteProperties()
    {
        return new UpdateNoteProperties
        {
            Text = this.Text,
            Position = new UpdateNotePosition
            {
                X = this.X,
                Y = this.Y
            },
            Size = new UpdateNoteSize
            {
                Height = this.Height,
                Width = this.Width
            }
        };
    }

}
public partial class AddNoteProperties : HylandBase
{
    /// <summary>
    /// The id of the note type.
    /// </summary>
    [JsonPropertyName("noteTypeId")]
    public string? NoteTypeId { get; set; }

    /// <summary>
    /// The page the note is on. This defaults to 1 if not present.
    /// </summary>
    [JsonPropertyName("page")]
    public long Page { get; set; }

    /// <summary>
    /// This defaults to 0 if not present.
    /// </summary>
    [JsonPropertyName("x")]
    public int X { get; set; }

    /// <summary>
    /// This defaults to 0 if not present.
    /// </summary>
    [JsonPropertyName("y")]
    public int Y { get; set; }

    /// <summary>
    /// This defaults to 0 if not present.
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }

    /// <summary>
    /// This defaults to 0 if not present.
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <summary>
    /// The text in the note.
    /// <br/>This defaults to the configured note type default text if not present.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

public partial class UpdateNoteProperties : HylandBase
{

    [JsonPropertyName("position")]
    public UpdateNotePosition Position { get; set; } = new();

    [JsonPropertyName("size")]
    public UpdateNoteSize Size { get; set; } = new();

    /// <summary>
    /// The text in the note.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }  
}

/// <summary>
/// Model containing position metadata to update the note with.
/// </summary>
public partial class UpdateNotePosition : HylandBase
{

    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }
}

/// <summary>
/// Model containing size metadata to update the note with.
/// </summary>

public partial class UpdateNoteSize : HylandBase
{

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }
}

public partial class NotePrivileges
{
    /// <summary>
    /// A value indicating if the note can be updated.
    /// </summary>
    [JsonPropertyName("canModify")]
    public bool CanModify { get; set; }

    /// <summary>
    /// A value indicating if the note can be deleted.
    /// </summary>
    [JsonPropertyName("canDelete")]
    public bool CanDelete { get; set; }

    /// <summary>
    /// A value indicating if the user is allowed to update privacy options.
    /// </summary>
    [JsonPropertyName("canUpdatePrivacyOptions")]
    public bool CanUpdatePrivacyOptions { get; set; }
}


///// <summary>
///// Id of the newly created note.
///// </summary>    
//public partial class NotesPostResponse
//{

//    /// <summary>
//    /// Identifier of the note.
//    /// </summary>
//    [JsonPropertyName("noteId")]
//    public string NoteId { get; set; }

//    private IDictionary<string, object> _additionalProperties;

//    [JsonExtensionData]
//    public IDictionary<string, object> AdditionalProperties
//    {
//        get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
//        set { _additionalProperties = value; }
//    }
//}

