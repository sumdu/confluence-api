using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class GetContentPropertiesForCommentRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("comment-id")]
    public required string CommentId { get; set; }

    [QueryParam]
    [JsonProperty("key")]
    public string? Key { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public ContentPropertySortOrder? Sort { get; set; }
}
