using System.Text.Json.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Operations;

public class Operation
{
    [JsonPropertyName("operation")]
    public string OperationName { get; set; }

    [JsonPropertyName("targetType")]
    public string TargetType { get; set; }
}
