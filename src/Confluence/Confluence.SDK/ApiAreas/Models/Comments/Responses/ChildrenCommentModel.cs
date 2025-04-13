using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class ChildrenCommentModel : AbstractComment
{
    public string ParentCommentId { get; set; }
    public BodyBulk Body { get; set; }
}
