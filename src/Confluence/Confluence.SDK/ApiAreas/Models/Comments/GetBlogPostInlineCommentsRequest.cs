using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public class GetBlogPostInlineCommentsRequest : PaginatedRequest 
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public PrimaryBodyRepresentation? BodyFormat { get; set; }

    [QueryParam]
    [JsonProperty("status")]
    public GetCommentStatusEnum[]? Statuses { get; set; }

    [QueryParam]
    [JsonProperty("resolution-status")]
    public GetCommentResolutionStatusEnum[]? ResolutionStatuses { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public CommentSortOrderEnum? Sort { get; set; }
}
