using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public class GetPagesRequest : PaginatedRequest
{
    [QueryParam]
    [JsonProperty("id")]
    public long[]? Ids { get; set; }

    [QueryParam]
    [JsonProperty("space-id")]
    public long[]? SpaceIds { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public GetPagesRequestSortEnum? Sort { get; set; }

    [QueryParam]
    [JsonProperty("status")]
    public PageStatus[]? Status { get; set; }

    [QueryParam]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public GetPagesRequestBodyFormatEnum? BodyFormat { get; set; }
}
