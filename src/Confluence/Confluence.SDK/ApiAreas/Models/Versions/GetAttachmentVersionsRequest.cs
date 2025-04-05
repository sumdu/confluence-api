using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;
public class GetAttachmentVersionsRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required long Id { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public VersionSortOrder? Sort { get; set; }
}
