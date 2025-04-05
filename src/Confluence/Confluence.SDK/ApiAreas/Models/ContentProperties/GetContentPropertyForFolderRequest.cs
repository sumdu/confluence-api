using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class GetContentPropertyForFolderRequest
{
    [PathParam]
    [JsonProperty("folder-id")]
    public required string FolderId { get; set; }

    [PathParam]
    [JsonProperty("property-id")]
    public required long PropertyId { get; set; }
}
