using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class SpaceLinks
{
    [JsonProperty("webui")]
    public string Webui { get; set; }
}

public class SpaceLinks_Object : ObjectLinks
{
    [JsonProperty("webui")]
    public string Webui { get; set; }
}