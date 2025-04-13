using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public class DeleteFooterCommentRequest 
{
    [PathParam]
    [JsonProperty("comment-id")]
    public required string CommentId { get; set; }
}
