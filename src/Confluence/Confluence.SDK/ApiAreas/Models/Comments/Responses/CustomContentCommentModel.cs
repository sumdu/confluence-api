using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class CustomContentCommentModel : AbstractComment
{
    public string CustomContentId { get; set; }
    public BodySingle Body { get; set; }
}
