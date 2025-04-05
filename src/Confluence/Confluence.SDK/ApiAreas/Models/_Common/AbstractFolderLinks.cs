using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class AbstractFolderLinks
{
    [JsonProperty("webui")]
    public string WebUi { get; set; }
}

public class AbstractFolderLinks_Object : ObjectLinks
{
    [JsonProperty("webui")]
    public string WebUi { get; set; }
}