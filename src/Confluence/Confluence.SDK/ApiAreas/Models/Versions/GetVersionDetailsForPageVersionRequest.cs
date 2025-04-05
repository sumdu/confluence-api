using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Versions;
public class GetVersionDetailsForPageVersionRequest
{
    [PathParam]
    [JsonProperty("page-id")]
    public required string PageId { get; set; }

    [PathParam]
    [JsonProperty("version-number")]
    public required long VersionNumber { get; set; }

}
