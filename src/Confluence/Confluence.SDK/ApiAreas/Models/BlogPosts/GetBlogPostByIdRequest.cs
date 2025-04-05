using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public class GetBlogPostByIdRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public PrimaryBodyRepresentationSingle? BodyFormat { get; set; } = null;

    [QueryParam]
    [JsonProperty("get-draft")]
    public bool? GetDraft { get; set; } = null;

    [QueryParam]
    [JsonProperty("status")]
    public GetBlogPostByIdRequestStatusEnum[]? Status { get; set; } = null;

    [QueryParam]
    [JsonProperty("version")]
    public int? Version { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-labels")]
    public bool? IncludeLabels { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-properties")]
    public bool? IncludeProperties { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-operations")]
    public bool? IncludeOperations { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-likes")]
    public bool? IncludeLikes { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-versions")]
    public bool? IncludeVersions { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-version")]
    public bool? IncludeVersion { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-favorited-by-current-user-status")]
    public bool? IncludeFavoritedByCurrentUserStatus { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-webresources")]
    public bool? IncludeWebResources { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-collaborators")]
    public bool? IncludeCollaborators { get; set; } = null;
}
