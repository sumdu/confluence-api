using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class FooterCommentModel : AbstractComment
{
    public string BlogPostId { get; set; }
    public string PageId { get; set; }
    public string AttachmentId { get; set; }
    public string CustomContentId { get; set; }
    public string ParentCommentId { get; set; }

    public ContentPropertyResults Properties { get; set; }
}

public class FooterCommentWithViewLink : FooterCommentModel
{
    [JsonProperty("_links")]
    public FooterCommentLinks Links { get; set; }
}

public class FooterCommentLinks : ObjectLinks
{
    [JsonProperty("webui")]
    public string Webui { get; set; }
}
