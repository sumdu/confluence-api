using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models;

public class PaginatedRequest
{
    [QueryParam]
    [JsonProperty("cursor")]
    public string? Cursor { get; set; }

    [QueryParam]
    [JsonProperty("limit")]
    public int? Limit { get; set; }
}
