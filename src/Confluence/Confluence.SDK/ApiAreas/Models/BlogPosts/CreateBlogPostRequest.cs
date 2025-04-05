using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public class CreateBlogPostRequest
{
    [QueryParam]
    [JsonProperty("private")]
    public bool? IsPrivate { get; set; }

    [BodyParam]
    [JsonProperty("spaceId")]
    public required string SpaceId { get; set; }

    [BodyParam]
    [JsonProperty("status")]
    public BlogPostCreateStatus? Status { get; set; }

    [BodyParam]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [BodyParam]
    [JsonProperty("body")]
    public CreateBlogPostRequestBody? Body { get; set; }

    [BodyParam]
    [JsonProperty("createdAt")]
    public DateTime? CreatedAt { get; set; }
}
