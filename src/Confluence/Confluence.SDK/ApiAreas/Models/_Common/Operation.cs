using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class Operation
{
    [JsonProperty("operation")]
    public string OperationName { get; set; }

    [JsonProperty("targetType")]
    public string TargetType { get; set; }
}
