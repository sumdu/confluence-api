using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class BodyType
{
    [JsonProperty("representation")]
    public string Representation { get; set; }
    
    [JsonProperty("value")]
    public string Value { get; set; }
}

