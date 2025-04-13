using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public class UpdateFooterCommentRequest
{
    [PathParam]
    [JsonProperty("comment-id")]
    public required string CommentId { get; set; }

    [BodyParam]
    [JsonProperty("version")]
    public UpdateCommentVersion? Version { get; set; }

    [BodyParam]
    [JsonProperty("body")]
    public CreateCommentRequestBody? Body { get; set; }

    [BodyParam]
    [JsonProperty("_links")]
    public ObjectLinks Links { get; set; }
}
