using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Versions;
public class GetVersionDetailsForBlogPostVersionRequest
{
    [PathParam]
    [JsonProperty("blogpost-id")]
    public required string BlogPostId { get; set; }

    [PathParam]
    [JsonProperty("version-number")]
    public required long VersionNumber { get; set; }

}
