using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Operations;

public class GetPermittedOperationsForWhiteboardRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required int Id { get; set; }
}