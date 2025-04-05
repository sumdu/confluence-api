using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.ApiAreas.Models.Pages;
using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;
public class GetCustomContentVersionsRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("custom-content-id")]
    public required long CustomContentId { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public PrimaryBodyRepresentation? BodyFormat { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public VersionSortOrder? Sort { get; set; }
}
