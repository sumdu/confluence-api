using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public class GetFooterCommentByIdRequest 
{
    [PathParam]
    [JsonProperty("comment-id")]
    public required string CommentId { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public PrimaryBodyRepresentationSingle? BodyFormat { get; set; }

    [QueryParam]
    [JsonProperty("version")]
    public int? Version { get; set; }

    [QueryParam]
    [JsonProperty("include-properties")]
    public bool? IncludeProperties { get; set; }

    [QueryParam]
    [JsonProperty("include-operations")]
    public bool? IncludeOperations { get; set; }

    [QueryParam]
    [JsonProperty("include-likes")]
    public bool? IncludeLikes { get; set; }

    [QueryParam]
    [JsonProperty("include-versions")]
    public bool? IncludeVersions { get; set; }

    [QueryParam]
    [JsonProperty("include-version")]
    public bool? IncludeVersion { get; set; }
}
