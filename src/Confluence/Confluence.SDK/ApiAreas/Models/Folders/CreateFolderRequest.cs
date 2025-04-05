using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Folders;
public class CreateFolderRequest
{
    [BodyParam]
    [JsonProperty("spaceId")]
    public required string SpaceId { get; set; }

    [BodyParam]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [BodyParam]
    [JsonProperty("parentId")]
    public string? ParentId { get; set; }
}
