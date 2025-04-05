using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public class DeleteBlogPostRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("purge")]
    public bool? Purge { get; set; }

    [QueryParam]
    [JsonProperty("draft")]
    public bool? Draft { get; set; }
}