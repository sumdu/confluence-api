using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.ApiAreas.Models.Pages;
using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public class GetBlogPostsRequest : PaginatedRequest
{
    [QueryParam]
    [JsonProperty("id")]
    public long[]? Ids { get; set; }

    [QueryParam]
    [JsonProperty("space-id")]
    public long[]? SpaceIds { get; set; }

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
