using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;
public class VersionedEntity
{
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("body")]
    public BodyBulk Body { get; set; }
}
