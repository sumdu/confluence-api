using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Ancestors;

public class AncestorsResponse
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("type")]
    public AncestorType Type { get; set; }
}
