using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// A collection of Classes.
/// </summary>
public partial class ClassCollectionModel : OnBaseItemTypeCollection<ClassModel>
{
    
}

/// <summary>
/// Information about a Class.
/// </summary>
public partial class ClassModel : OnBaseItemType
{

    /// <summary>
    /// The base most Class Id of the current class.
    /// </summary>
    [JsonPropertyName("rootClassId")]
    public string RootClassId { get; set; }

}

/// <summary>
/// Information about the user's Class Access Rights.
/// </summary>    
public partial class ClassAccessRights : HylandBase
{

    [JsonPropertyName("accessRights")]
    [System.ComponentModel.DataAnnotations.Required]
    public ClassAccessRightsFlags AccessRights { get; set; } = new ClassAccessRightsFlags();
}

/// <summary>
/// The Access Rights for a Class.
/// </summary>
public partial class ClassAccessRightsFlags : HylandBase
{

    [JsonPropertyName("canView")]
    public bool CanView { get; set; }

    [JsonPropertyName("canCreate")]
    public bool CanCreate { get; set; }

    [JsonPropertyName("canModify")]
    public bool CanModify { get; set; }

    [JsonPropertyName("canDelete")]
    public bool CanDelete { get; set; }
}