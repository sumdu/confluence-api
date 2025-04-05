using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Pages;

public class CreatePageRequest
{
    [QueryParam]
    [JsonProperty("embedded")]
    public bool? Embedded { get; set; }

    [QueryParam]
    [JsonProperty("private")]
    public bool? IsPrivate { get; set; }

    [QueryParam]
    [JsonProperty("root-level")]
    public bool? RootLevel { get; set; }

    [BodyParam]
    [JsonProperty("spaceId")]
    public required string SpaceId { get; set; }

    [BodyParam]
    [JsonProperty("status")]
    public string? Status { get; set; }

    [BodyParam]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [BodyParam]
    [JsonProperty("parentId")]
    public string? ParentId { get; set; }

    [BodyParam]
    [JsonProperty("body")]
    public CreatePageRequestBody? Body { get; set; }
}
