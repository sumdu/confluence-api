using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class OptionalFieldLinks
{
    [JsonProperty("self")]
    public string Self { get; set; }

    //[JsonProperty("base")]
    //public string Base { get; set; }
}
