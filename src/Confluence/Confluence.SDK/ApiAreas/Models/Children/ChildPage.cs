using Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Children;

public class ChildPage
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("status")]
    public OnlyArchivedAndCurrentContentStatus Status { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("spaceId")]
    public string SpaceId { get; set; }

    [JsonProperty("childPosition")]
    public long ChildPosition { get; set; }
}
