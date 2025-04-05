using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;
public class GetVersionDetailsForInlineCommentVersionRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [PathParam]
    [JsonProperty("version-number")]
    public required long VersionNumber { get; set; }

}
