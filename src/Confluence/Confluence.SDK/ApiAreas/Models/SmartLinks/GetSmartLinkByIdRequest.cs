using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.SmartLinks;

public class GetSmartLinkByIdRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("include-collaborators")]
    public bool? IncludeCollaborators { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-direct-children")]
    public bool? IncludeDirectChildren { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-operations")]
    public bool? IncludeOperations { get; set; } = null;

    [QueryParam]
    [JsonProperty("include-properties")]
    public bool? IncludeProperties { get; set; } = null;
}
