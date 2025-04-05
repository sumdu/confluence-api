using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.DataPolicies;
public class GetSpacesWithDataPoliciesRequest : PaginatedRequest
{
    [QueryParam]
    [JsonProperty("ids")]
    public long[]? Ids { get; set; }

    [QueryParam]
    [JsonProperty("keys")]
    public string[]? Keys { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public SpaceSortOrder? Sort { get; set; }
}
