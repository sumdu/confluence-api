using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Ancestors;

public class GetAncestorsOfWhiteboardRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("limit")]
    public int? Limit { get; set; } = null;
}
