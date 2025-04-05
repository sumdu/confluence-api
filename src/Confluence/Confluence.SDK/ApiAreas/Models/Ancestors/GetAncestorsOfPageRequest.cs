using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Ancestors;

public class GetAncestorsOfPageRequest
{
    [PathParam]
    [JsonProperty("Id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("limit")]
    public int? Limit { get; set; } = null;
}
