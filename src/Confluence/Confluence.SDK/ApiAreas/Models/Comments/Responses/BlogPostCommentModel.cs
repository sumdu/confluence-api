using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class BlogPostCommentModel : AbstractComment
{
    public string BlogPostId { get; set; }
    public BodyBulk Body { get; set; }
}
