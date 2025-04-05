using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public class GetBlogPostsInSpaceRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required long Id { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public BlogPostSortOrder? Sort { get; set; }

    [QueryParam]
    [JsonProperty("status")]
    public BlogPostStatus[]? Status { get; set; }

    [QueryParam]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public PrimaryBodyRepresentation? BodyFormat { get; set; }
}
