
using System.Text.Json.Serialization;

namespace HyRest.DocumentManagement;

/*
 * These are used directly in the Document Service class. 
 */
public partial class DocumentHistory : OnBaseItemCollection<HistoryItem>
{

}

public partial class HistoryItem : OnBaseItem
{
    [JsonIgnore]
    private new string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <summary>
    /// The action taken on the document
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// The date/time this document action was logged.
    /// <br/> ;a href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO-8601 Date and
    /// <br/>    time with milliseconds and without time zone.
    /// </summary>
    [JsonPropertyName("logDate")]
    public string? LogDate { get; set; }

    /// <summary>
    /// The logged message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// The user under which action was taken.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}