using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class SpaceIcon
{
    [JsonProperty("path")]
    public string Path { get; set; }

    [JsonProperty("apiDownloadLink")]
    public string ApiDownloadLink { get; set; }

}
