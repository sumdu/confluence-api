using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public class UpdatePageRequest
{
    [BodyParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [BodyParam]
    [JsonProperty("status")]
    public required UpdatePageRequestStatusEnum Status { get; set; }

    [BodyParam]
    [JsonProperty("title")]
    public required string Title { get; set; }

    [BodyParam]
    [JsonProperty("spaceId")]
    public string? SpaceId { get; set; }

    [BodyParam]
    [JsonProperty("parentId")]
    public string? ParentId { get; set; }

    [BodyParam]
    [JsonProperty("ownerId")]
    public string? OwnerId { get; set; }

    [BodyParam]
    [JsonProperty("body")]
    public required CreatePageRequestBody Body { get; set; }

    [BodyParam]
    [JsonProperty("version")]
    public required UpdatePageRequestVersion Version { get; set; }
}
