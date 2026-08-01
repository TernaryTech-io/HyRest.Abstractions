
using System.Text.Json.Serialization;

namespace HyRest.API.Models;

public partial class NoteTypeCollectionModel : OnBaseItemTypeCollection<NoteTypeModel>
{
    
}

/// <summary>
/// Note type metadata.
/// </summary>
public partial class NoteTypeModel : OnBaseItemType
{
    [JsonPropertyName("color")]
    public NoteColor? Color { get; set; }

    /// <summary>
    /// Note type display metadata.
    /// </summary>
    [JsonPropertyName("displayFlags")]
    public NoteTypeDisplayFlags? DisplayFlags { get; set; }

    /// <summary>
    /// The style of the note type.
    /// </summary>
    [JsonPropertyName("flavor")]
    public NoteTypeModelFlavor Flavor { get; set; }

    /// <summary>
    /// The id of the font used with the note type.
    /// </summary>
    [JsonPropertyName("fontId")]
    public string? FontId { get; set; }

    /// <summary>
    /// The id of the icon used with the note type.
    /// </summary>
    [JsonPropertyName("iconId")]
    public string? IconId { get; set; }

    /// <summary>
    /// User privileges for the note type.
    /// </summary>
    [JsonPropertyName("userPrivileges")]
    public NoteTypeUserPrivileges? UserPrivileges { get; set; }
}

/// <summary>
/// The color of the note type.
/// </summary>
public partial class NoteColor : HylandBase
{
    /// <summary>
    /// The red(R) component of a color.
    /// </summary>
    [JsonPropertyName("r")]
    public int R { get; set; }

    /// <summary>
    /// The green(G) component of a color.
    /// </summary>
    [JsonPropertyName("g")]
    public int G { get; set; }

    /// <summary>
    /// The blue(B) component of a color.
    /// </summary>
    [JsonPropertyName("b")]
    public int B { get; set; }

    /// <summary>
    /// The alpha(A) component of a color.
    /// </summary>
    [JsonPropertyName("a")]
    public int A { get; set; }
}

/// <summary>
/// Note type display metadata.
/// </summary>
public partial class NoteTypeDisplayFlags : HylandBase
{

    /// <summary>
    /// A value indicating whether the note type should be repeated on all pages.
    /// </summary>
    [JsonPropertyName("allPages")]
    public bool AllPages { get; set; }

    /// <summary>
    /// A value indicating whether the note type should appear on all revisions.
    /// </summary>
    [JsonPropertyName("allRevisions")]
    public bool AllRevisions { get; set; }

    /// <summary>
    /// A value indicating whether a note created from this note type should display open when creation is completed.
    /// </summary>
    [JsonPropertyName("createOpenNoteWindow")]
    public bool CreateOpenNoteWindow { get; set; }

    /// <summary>
    /// A value indicating whether a note associated with this note type should be deleted when the page the note is on is deleted.
    /// </summary>
    [JsonPropertyName("deleteWithPage")]
    public bool DeleteWithPage { get; set; }

    /// <summary>
    /// A value indicating that notes associated with this note type should not be bound to the document.
    /// </summary>
    [JsonPropertyName("floatOnWindow")]
    public bool FloatOnWindow { get; set; }

    /// <summary>
    /// A value indicating whether a note created from this note type should be hidden.
    /// </summary>
    [JsonPropertyName("hideNoteWindow")]
    public bool HideNoteWindow { get; set; }

    /// <summary>
    /// A value indicating the note associated with this note type should be movable.
    /// </summary>
    [JsonPropertyName("moveable")]
    public bool Moveable { get; set; }

    /// <summary>
    /// A value indicating the note type should not allow privacy options to be set on a note.
    /// </summary>
    [JsonPropertyName("noPrivacyOptions")]
    public bool NoPrivacyOptions { get; set; }

    /// <summary>
    /// A value indicating the note associated with this note type should be displayed open.
    /// </summary>
    [JsonPropertyName("open")]
    public bool Open { get; set; }

    /// <summary>
    /// A value indicating that only the creator of a note from this note type can delete the note.
    /// </summary>
    [JsonPropertyName("privacyNoDelete")]
    public bool PrivacyNoDelete { get; set; }

    /// <summary>
    /// A value indicating that only the creator of a note from this note type can modify the note.
    /// </summary>
    [JsonPropertyName("privacyNoModify")]
    public bool PrivacyNoModify { get; set; }

    /// <summary>
    /// A value indicating that only the creator of a note from this note type can view the note.
    /// </summary>
    [JsonPropertyName("privacyNoView")]
    public bool PrivacyNoView { get; set; }

    /// <summary>
    /// A value indicating that Icon Stamps cannot have their icons resized.
    /// </summary>
    [JsonPropertyName("stampKeepOriginalSize")]
    public bool StampKeepOriginalSize { get; set; }

    /// <summary>
    /// A value indicating that Icon Stamps are transparent.
    /// </summary>
    [JsonPropertyName("stampTransparent")]
    public bool StampTransparent { get; set; }
}


public partial class NoteTypeUserPrivileges : HylandBase
{

    /// <summary>
    /// A value indicating whether the user can create a note of the note type.
    /// </summary>
    [JsonPropertyName("create")]
    public bool Create { get; set; }

    /// <summary>
    /// A value indicating whether the user can view a note of the note type.
    /// </summary>
    [JsonPropertyName("view")]
    public bool View { get; set; }
}

/// <summary>
/// Note display metadata.
/// </summary>
public partial class NoteDisplayFlags : HylandBase
{
    /// <summary>
    /// A value indicating whether an user other than the creator of the note can view the note.
    /// </summary>
    [JsonPropertyName("allowView")]
    public bool AllowView { get; set; }

    /// <summary>
    /// A value indicating whether an user other than the creator of the note can modify the note.
    /// </summary>
    [JsonPropertyName("allowModify")]
    public bool AllowModify { get; set; }

    /// <summary>
    /// A value indicating whether an user other than the creator of the note can delete the note.
    /// </summary>
    [JsonPropertyName("allowDelete")]
    public bool AllowDelete { get; set; }
}