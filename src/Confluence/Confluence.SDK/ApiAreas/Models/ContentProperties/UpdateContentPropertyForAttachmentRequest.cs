using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class UpdateContentPropertyForAttachmentRequest
{
    [PathParam]
    [JsonProperty("attachment-id")]
    public required string AttachmentId { get; set; }

    [PathParam]
    [JsonProperty("property-id")]
    public required long PropertyId { get; set; }

    [BodyParam]
    [JsonProperty("key")]
    public string? Key { get; set; }

    [BodyParam]
    [JsonProperty("value")]
    public object? Value { get; set; }

    [BodyParam]
    [JsonProperty("version")]
    public VersionUpdate? Version { get; set; }
}
