using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.ContentProperties;
public class ContentProperty
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }

    [JsonProperty("version")]
    public _Common.Version Version { get; set; }
}
