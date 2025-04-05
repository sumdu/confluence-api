using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class GetContentPropertiesForWhiteboardRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string WhiteboardId { get; set; }

    [QueryParam]
    [JsonProperty("key")]
    public string? Key { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public ContentPropertySortOrder? Sort { get; set; }
}
