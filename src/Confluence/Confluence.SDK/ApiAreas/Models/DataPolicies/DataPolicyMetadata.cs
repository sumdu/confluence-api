using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.DataPolicies;

public class DataPolicyMetadata
{
    [JsonProperty("anyContentBlocked")]
    public bool AnyContentBlocked { get; set; }
}
