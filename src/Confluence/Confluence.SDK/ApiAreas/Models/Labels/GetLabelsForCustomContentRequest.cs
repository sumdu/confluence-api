using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Labels
{
    public class GetLabelsForCustomContentRequest : PaginatedRequest
    {
        [PathParam]
        [JsonProperty("id")]
        public required int Id { get; set; }

        [QueryParam]
        [JsonProperty("prefix")]
        public LabelPrefixEnum? Prefix { get; set; }

        [QueryParam]
        [JsonProperty("sort")]
        public string? Sort { get; set; }
    }
}