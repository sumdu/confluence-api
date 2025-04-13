using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class PageCommentModel : AbstractComment
{
    public string PageId { get; set; }
    public BodyBulk Body { get; set; }
}
