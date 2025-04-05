using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Attachments;

public class GetAttachmentByIdRequest
{
    [PathParam]
    [JsonProperty("id")]
    public string Id { get; set; }

    [QueryParam]
    [JsonProperty("version")]
    public int? Version { get; set; }

    [QueryParam]
    [JsonProperty("include-labels")]
    public bool? IncludeLabels { get; set; }

    [QueryParam]
    [JsonProperty("include-properties")]
    public bool? IncludeProperties { get; set; }

    [QueryParam]
    [JsonProperty("include-operations")]
    public bool? IncludeOperations { get; set; }

    [QueryParam]
    [JsonProperty("include-versions")]
    public bool? IncludeVersions { get; set; }

    [QueryParam]
    [JsonProperty("include-version")]
    public bool? IncludeVersion { get; set; }

    [QueryParam]
    [JsonProperty("include-collaborators")]
    public bool? IncludeCollaborators { get; set; }
}
