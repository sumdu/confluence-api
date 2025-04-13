using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public class GetInlineCommentChildrenRequest : PaginatedRequest 
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public PrimaryBodyRepresentation? BodyFormat { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public CommentSortOrderEnum? Sort { get; set; }
}
