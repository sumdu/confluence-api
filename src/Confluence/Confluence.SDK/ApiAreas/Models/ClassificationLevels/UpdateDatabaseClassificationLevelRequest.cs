using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ClassificationLevels;
public class UpdateDatabaseClassificationLevelRequest
{
    [BodyParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [BodyParam]
    [JsonProperty("status")]
    public required WhiteboardClassificationLevelEnum Status { get; set; }
}
