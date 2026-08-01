using System.Text.Json.Serialization;

namespace HyRest.API.Models;

/// <summary>
/// List of change events
/// </summary>    
public partial class ChangeEventCollection : HylandBase
{

    /// <summary>
    /// An array of change events
    /// </summary>
    [JsonPropertyName("items")]
    public ICollection<ChangeEventModel> Items { get; set; } = [];
}

/// <summary>
/// Change tracking change event.
/// </summary>
public partial class ChangeEventModel : HylandBase
{
    /// <summary>
    /// The unique identifier for the event.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The date the event took place.
    /// </summary>
    [JsonPropertyName("dateChanged")]
    public string? DateChanged { get; set; }

    /// <summary>
    /// The id of the user who made the change.
    /// </summary>
    [JsonPropertyName("changeAuthor")]
    public string? ChangeAuthor { get; set; }

    /// <summary>
    /// The username of the user who made the change.
    /// </summary>
    [JsonPropertyName("changeAuthorUserName")]
    public string? ChangeAuthorUserName { get; set; }

    /// <summary>
    /// The application that initiated the change.
    /// </summary>
    [JsonPropertyName("changeSource")]
    public string? ChangeSource { get; set; }

    /// <summary>
    /// The description of the change.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The item that was changed.
    /// </summary>
    [JsonPropertyName("changeItem")]
    public ChangeItem? ChangeItem { get; set; }
}
public partial class ChangeItem : HylandBase
{
    /// <summary>
    /// Changed item id
    /// </summary>
    [JsonPropertyName("itemId")]
    public string? ItemId { get; set; }

    /// <summary>
    /// Changed item name
    /// </summary>
    [JsonPropertyName("itemName")]
    public string? ItemName { get; set; }

    /// <summary>
    /// Changed item type. Enum values can be found in Hyland.Common.Core.ChangeControl.MigrationItemType
    /// </summary>
    [JsonPropertyName("itemType")]
    public string? ItemType { get; set; }

    /// <summary>
    /// Change type (create, update, etc...)
    /// </summary>
    [JsonPropertyName("changeType")]
    public string? ChangeType { get; set; }

    /// <summary>
    /// Information about what properties were changed
    /// </summary>
    [JsonPropertyName("changeDetail")]
    public string? ChangeDetail { get; set; }
}

/// <summary>
/// List of all valid values on a given property
/// </summary>    
public partial class PropertyDescription : HylandBase
{

    /// <summary>
    /// The name of given property
    /// </summary>
    [JsonPropertyName("propertyName")]
    public string? PropertyName { get; set; }

    /// <summary>
    /// A list of all valid values on this property
    /// </summary>
    [JsonPropertyName("DescriptionOptions")]
    public ICollection<DescriptionOption> DescriptionOptions { get; set; } = [];
}

/// <summary>
/// a valid values on a given property
/// </summary>

public partial class DescriptionOption : HylandBase
{

    /// <summary>
    /// The name of an enum option
    /// </summary>
    [JsonPropertyName("enumName")]
    public string? EnumName { get; set; }

    /// <summary>
    /// The value of an enum option
    /// </summary>
    [JsonPropertyName("enumValue")]
    public string? EnumValue { get; set; }
}