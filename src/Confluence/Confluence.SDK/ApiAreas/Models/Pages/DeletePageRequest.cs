using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Pages;

public class DeletePageRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("purge")]
    public bool? Purge { get; set; }

    [QueryParam]
    [JsonProperty("draft")]
    public bool? Draft { get; set; }
}