using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Labels;

public enum LabelPrefixEnum
{
    [JsonProperty("my")]
    My,
    [JsonProperty("team")]
    Team,
    [JsonProperty("global")]
    Global,
    [JsonProperty("system")]
    System
}
