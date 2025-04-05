using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Content;
public class ConvertContentIdsToContentTypesRequest
{
    [BodyParam]
    [JsonProperty("contentIds")]
    public required object[] ContentIds { get; set; }
}
