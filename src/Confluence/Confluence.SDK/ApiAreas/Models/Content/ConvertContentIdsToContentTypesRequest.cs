using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Content;
public class ConvertContentIdsToContentTypesRequest
{
    [BodyParam]
    [JsonProperty("contentIds")]
    public required object[] ContentIds { get; set; }
}
