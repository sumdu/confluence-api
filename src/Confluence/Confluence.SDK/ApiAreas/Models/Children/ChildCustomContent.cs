using Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Children;
public class ChildCustomContent
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("status")]
    public OnlyArchivedAndCurrentContentStatus Status { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("spaceId")]
    public string SpaceId { get; set; }
}
