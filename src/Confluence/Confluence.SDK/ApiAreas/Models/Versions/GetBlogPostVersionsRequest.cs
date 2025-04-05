using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Versions;
public class GetBlogPostVersionsRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required long Id { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public 
        PrimaryBodyRepresentation? BodyFormat { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public VersionSortOrder? Sort { get; set; }
}
