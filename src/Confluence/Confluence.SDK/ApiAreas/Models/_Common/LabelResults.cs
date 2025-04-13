using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

// TODO: refactor this to be a generic model e.g. Result<T>
public class LabelResults
{
    [JsonProperty("results")]
    public List<Label> Results { get; set; }

    [JsonProperty("meta")]
    public OptionalFieldMeta Meta { get; set; }

    [JsonProperty("_links")]
    public OptionalFieldLinks Links { get; set; }
}
