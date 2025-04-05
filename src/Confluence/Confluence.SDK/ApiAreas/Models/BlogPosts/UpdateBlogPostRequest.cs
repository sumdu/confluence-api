using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public class UpdateBlogPostRequest
{
    [BodyParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [BodyParam]
    [JsonProperty("status")]
    public required UpdateBlogPostRequestStatusEnum Status { get; set; }

    [BodyParam]
    [JsonProperty("title")]
    public required string Title { get; set; }

    [BodyParam]
    [JsonProperty("spaceId")]
    public string? SpaceId { get; set; }

    [BodyParam]
    [JsonProperty("body")]
    public required CreateBlogPostRequestBody Body { get; set; }

    [BodyParam]
    [JsonProperty("version")]
    public required UpdateBlogPostRequestVersion Version { get; set; }

    [BodyParam]
    [JsonProperty("createdAt")]
    public DateTime? CreatedAt { get; set; }
}
