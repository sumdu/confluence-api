using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Spaces;

public class SpaceBulk
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public SpaceType Type { get; set; }

    [JsonProperty("status")]
    public SpaceStatus Status { get; set; }

    [JsonProperty("authorId")]
    public string AuthorId { get; set; }

    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("homepageId")]
    public string HomepageId { get; set; }

    [JsonProperty("description")]
    public SpaceDescription Description { get; set; }

    [JsonProperty("icon")]
    public SpaceIcon Icon { get; set; }

    [JsonProperty("_links")]
    public SpaceLinks_Object Links { get; set; }

}
