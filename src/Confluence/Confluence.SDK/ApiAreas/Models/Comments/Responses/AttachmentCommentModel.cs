using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class AttachmentCommentModel : AbstractComment
{
    public string AttachmentId { get; set; }
    public BodySingle Body { get; set; }
}
