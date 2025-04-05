using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Folders;
public class GetFolderByIdRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required long Id { get; set; }

    [QueryParam]
    [JsonProperty("include-collaborators")]
    public bool? IncludeCollaborators { get; set; }

    [QueryParam]
    [JsonProperty("include-direct-children")]
    public bool? IncludeDirectChildren { get; set; }

    [QueryParam]
    [JsonProperty("include-operations")]
    public bool? IncludeOperations { get; set; }

    [QueryParam]
    [JsonProperty("include-properties")]
    public bool? IncludeProperties { get; set; }
}
