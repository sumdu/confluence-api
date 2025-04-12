using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ClassificationLevels;
public class GetBlogPostClassificationLevelRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("status")]
    public GetClassificationLevelStatusEnum? Status { get; set; }
}
