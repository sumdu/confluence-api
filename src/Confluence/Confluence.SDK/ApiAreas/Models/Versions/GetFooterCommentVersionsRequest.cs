using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.ApiAreas.Models.Pages;
using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;
public class GetFooterCommentVersionsRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required long Id { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public PrimaryBodyRepresentation? BodyFormat { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public VersionSortOrder? Sort { get; set; }
}
