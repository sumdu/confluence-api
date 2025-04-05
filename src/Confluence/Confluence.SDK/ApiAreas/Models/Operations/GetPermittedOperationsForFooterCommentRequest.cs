using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Operations;

public class GetPermittedOperationsForFooterCommentRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required int Id { get; set; }
}