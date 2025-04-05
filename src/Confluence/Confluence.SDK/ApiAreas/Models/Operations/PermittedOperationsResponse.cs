using System.Text.Json.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Operations;

public class PermittedOperationsResponse
{
    [JsonPropertyName("operations")]
    public List<Operation> Operations { get; set; }
}
