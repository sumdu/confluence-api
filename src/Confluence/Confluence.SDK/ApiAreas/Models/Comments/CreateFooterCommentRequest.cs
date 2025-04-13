using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public class CreateFooterCommentRequest 
{
    [BodyParam]
    [JsonProperty("blogPostId")]
    public string? BlogPostId { get; set; }

    [BodyParam]
    [JsonProperty("pageId")]
    public string? PageId { get; set; }

    [BodyParam]
    [JsonProperty("parentCommentId")]
    public string? ParentCommentId { get; set; }

    [BodyParam]
    [JsonProperty("attachmentId")]
    public string? AttachmentId { get; set; }

    [BodyParam]
    [JsonProperty("customContentId")]
    public string? CustomContentId { get; set; }

    [BodyParam]
    [JsonProperty("body")]
    public CreateCommentRequestBody? Body { get; set; }
}
