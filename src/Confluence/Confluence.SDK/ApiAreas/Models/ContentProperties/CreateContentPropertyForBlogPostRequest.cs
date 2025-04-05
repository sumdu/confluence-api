using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class CreateContentPropertyForBlogPostRequest
{
    [PathParam]
    [JsonProperty("blogpost-id")]
    public required string BlogPostId { get; set; }

    [BodyParam]
    [JsonProperty("key")]
    public string? Key { get; set; }

    [BodyParam]
    [JsonProperty("value")]
    public object? Value { get; set; }
}
