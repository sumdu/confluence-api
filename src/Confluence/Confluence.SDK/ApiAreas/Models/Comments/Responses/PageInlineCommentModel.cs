using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class PageInlineCommentModel : AbstractComment
{
    public string PageId { get; set; }
    public BodyBulk Body { get; set; }
    public InlineCommentResolutionStatusEnum ResolutionStatus { get; set; }
    public InlineCommentPropertiesModel Properties { get; set; }
}
