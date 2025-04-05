using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;
public class GetVersionDetailsForCustomContentVersionRequest
{
    [PathParam]
    [JsonProperty("custom-content-id")]
    public required string CustomContentId { get; set; }

    [PathParam]
    [JsonProperty("version-number")]
    public required long VersionNumber { get; set; }

}
