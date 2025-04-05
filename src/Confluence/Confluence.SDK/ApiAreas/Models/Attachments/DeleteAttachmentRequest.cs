using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Pages;

public class DeleteAttachmentRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("purge")]
    public bool? Purge { get; set; }
}