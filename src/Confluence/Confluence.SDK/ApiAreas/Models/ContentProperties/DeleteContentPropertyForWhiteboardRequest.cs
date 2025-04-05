using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class DeleteContentPropertyForWhiteboardRequest
{
    [PathParam]
    [JsonProperty("whiteboard-id")]
    public required string WhiteboardId { get; set; }

    [PathParam]
    [JsonProperty("property-id")]
    public required long PropertyId { get; set; }
}
