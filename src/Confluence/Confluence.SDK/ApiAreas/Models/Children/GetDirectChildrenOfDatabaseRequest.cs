using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Children;
public class GetDirectChildrenOfDatabaseRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public string? Sort { get; set; } = null;
}
