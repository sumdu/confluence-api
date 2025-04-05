using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.DataPolicies;

public class DataPolicyMetadata
{
    [JsonProperty("anyContentBlocked")]
    public bool AnyContentBlocked { get; set; }
}
