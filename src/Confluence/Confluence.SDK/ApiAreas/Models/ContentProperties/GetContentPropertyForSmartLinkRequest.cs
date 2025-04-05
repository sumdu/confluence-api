using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class GetContentPropertyForSmartLinkRequest
{
    [PathParam]
    [JsonProperty("embed-id")]
    public required string SmartLinkId { get; set; }

    [PathParam]
    [JsonProperty("property-id")]
    public required long PropertyId { get; set; }
}
