using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class SmartLinkLinks
{
    [JsonProperty("webui")]
    public string WebUi { get; set; }
}

public class SmartLinkLinks_Object : ObjectLinks
{
    [JsonProperty("webui")]
    public string WebUi { get; set; }
}