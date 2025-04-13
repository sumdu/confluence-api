using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public class InlineCommentPropertiesModel
{
    public string InlineMarkerRef { get; set; }
    public string InlineOriginalSelection { get; set; }

    [JsonProperty("inline-marker-ref")]
    public string InlineMarkerRefDeprecated { get; set; }

    [JsonProperty("inline-original-selection")]
    public string InlineOriginalSelectionDeprecated { get; set; }
}
