using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class BodyBulk
{
    [JsonProperty("storage")]
    public BodyType Storage { get; set; }

    [JsonProperty("atlas_doc_format")]
    public BodyType AtlasDocFormat { get; set; }
}


