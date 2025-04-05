using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class GetContentPropertiesForPageRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("page-id")]
    public required string PageId { get; set; }

    [QueryParam]
    [JsonProperty("key")]
    public string? Key { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public ContentPropertySortOrder? Sort { get; set; }
}
