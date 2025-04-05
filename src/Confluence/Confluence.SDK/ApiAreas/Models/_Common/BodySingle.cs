using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

public class BodySingle
{
    [JsonProperty("storage")]
    public BodyType? Storage { get; set; }

    [JsonProperty("atlas_doc_format")]
    public BodyType? AtlasDocFormat { get; set; }

    [JsonProperty("view")]
    public BodyType? View { get; set; }
}