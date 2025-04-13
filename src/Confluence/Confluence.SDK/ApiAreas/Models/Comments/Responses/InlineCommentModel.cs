using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class InlineCommentModel : AbstractComment
{
    public string BlogPostId { get; set; }
    public string PageId { get; set; }
    public string? ParentCommentId { get; set; }
    public BodySingle Body { get; set; }
    public string? ResolutionLastModifierId { get; set; }
    public DateTime? ResolutionLastModifiedAt { get; set; }
    public InlineCommentResolutionStatus ResolutionStatus { get; set; }
    public InlineCommentPropertiesFullModel Properties { get; set; }
    public OperationResults Operations { get; set; }
    public LikeResults Likes { get; set; }
    public VersionResults Versions { get; set; }
}

public class InlineCommentModelWithLinks : InlineCommentModel
{
    [JsonProperty("_links")]
    public InlineCommentModelLinks Links { get; set; }
}

public class InlineCommentModelLinks : ObjectLinks
{
    [JsonProperty("webui")]
    public string Webui { get; set; }
}

public class InlineCommentPropertiesFullModel
{
    public List<ContentProperty> Results { get; set; }
    public OptionalFieldMeta? Meta { get; set; }

    [JsonProperty("_links")]
    public OptionalFieldLinks? Links { get; set; }

    public string InlineMarkerRef { get; set; }
    public string InlineOriginalSelection { get; set; }

    [JsonProperty("inline-marker-ref")]
    public string InlineMarkerRefDeprecated { get; set; }

    [JsonProperty("inline-original-selection")]
    public string InlineOriginalSelectionDeprecated { get; set; }
}