using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.ApiAreas.Models.Pages;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Spaces;

public class SpaceSingleLabels
{
    [JsonProperty("results")]
    public List<Label> Results { get; set; }

    [JsonProperty("meta")]
    public OptionalFieldMeta Meta { get; set; }

    [JsonProperty("_links")]
    public OptionalFieldLinks Links { get; set; }
}