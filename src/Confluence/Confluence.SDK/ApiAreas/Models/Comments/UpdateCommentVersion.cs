using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public class UpdateCommentVersion
{
    [JsonProperty("number")]
    public long Number { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }
}
