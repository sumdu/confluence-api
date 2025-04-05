using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Descendants;

public class GetDescendandsOfWhiteboardRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("limit")]
    public int? Limit { get; set; } = null;

    [QueryParam]
    [JsonProperty("depth")]
    public int? Depth { get; set; } = null;

    [QueryParam]
    [JsonProperty("cursor")]
    public string? Cursor { get; set; } = null;
}
