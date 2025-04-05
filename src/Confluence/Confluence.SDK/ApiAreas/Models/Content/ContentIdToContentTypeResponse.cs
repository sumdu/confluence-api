using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Content;
public class ContentIdToContentTypeResponse
{
    [JsonProperty("results")]
    public Dictionary<string, string> Results { get; set; }
}
