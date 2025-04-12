using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ClassificationLevels;
public class GetDatabaseClassificationLevelRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }
}
