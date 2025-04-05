using Confluence.ApiV2.ApiAreas.Models.Spaces;
using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Pages;

public class GetPagesByLabelRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required long Id { get; set; }

    [QueryParam]
    [JsonProperty("space-id")]
    public long[]? SpaceIds { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public GetPagesByLabelRequestBodyFormatEnum? BodyFormat { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public GetPagesByLabelRequestSortEnum? Sort { get; set; }
}
