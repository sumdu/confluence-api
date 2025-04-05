using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class VersionUpdate
{
    [JsonProperty("message")]
    public string Message { get; set; }
    
    [JsonProperty("number")]
    public long Number { get; set; }
}
