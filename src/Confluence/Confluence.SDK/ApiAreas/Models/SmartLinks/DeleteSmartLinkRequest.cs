using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.SmartLinks;

public class DeleteSmartLinkRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }
}
