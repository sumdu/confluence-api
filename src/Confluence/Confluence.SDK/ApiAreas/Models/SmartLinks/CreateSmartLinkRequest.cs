using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.SmartLinks;

public class CreateSmartLinkRequest
{
    [BodyParam]
    [JsonProperty("spaceId")]
    public required string SpaceId { get; set; }

    [BodyParam]
    [JsonProperty("title")]
    public string? Title { get; set; } = null;

    [BodyParam]
    [JsonProperty("parentId")]
    public string? ParentId { get; set; } = null;

    [BodyParam]
    [JsonProperty("embedUrl")]
    public string? EmbedUrl { get; set; } = null;
}
