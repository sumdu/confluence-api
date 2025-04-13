using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public class InlineCommentProperties
{
    [JsonProperty("textSelection")]
    public string? TextSelection { get; set; }

    [JsonProperty("textSelectionMatchCount")]
    public long? TextSelectionMatchCount { get; set; }

    [JsonProperty("textSelectionMatchIndex")]
    public long? TextSelectionMatchIndex { get; set; }
}
