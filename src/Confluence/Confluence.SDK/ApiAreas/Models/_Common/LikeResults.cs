using System.Text.Json.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

// TODO: refactor this to be a generic model e.g. Result<T>
public class LikeResults
{
    public List<Like> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    
    [JsonPropertyName("_links")]
    public OptionalFieldLinks Links { get; set; }
}
