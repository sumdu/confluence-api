using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class InlineCommentChildrenModel : AbstractComment
{
    public string ParentCommentId { get; set; }
    public BodyBulk Body { get; set; }
    public InlineCommentResolutionStatusEnum ResolutionStatus { get; set; }
    public InlineCommentPropertiesModel Properties { get; set; }
}

public class InlineCommentChildrenLinks
{
    [JsonProperty("webui")]
    public string Webui { get; set; }
}

public class InlineCommentChildrenModelWithViewLink : InlineCommentChildrenModel
{
    [JsonProperty("_links")]
    public InlineCommentChildrenLinks Links { get; set; }
}
