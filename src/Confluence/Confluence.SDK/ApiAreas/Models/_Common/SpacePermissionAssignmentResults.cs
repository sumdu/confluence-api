using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Spaces;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

// TODO: refactor this to be a generic model e.g. Result<T>
public class SpacePermissionAssignmentResults
{
    [JsonProperty("results")]
    public List<SpacePermissionAssignment> Results { get; set; }

    [JsonProperty("meta")]
    public OptionalFieldMeta Meta { get; set; }

    [JsonProperty("_links")]
    public OptionalFieldLinks Links { get; set; }
}
