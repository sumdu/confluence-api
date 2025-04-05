using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

public class AbstractPageLinks
{
    [JsonProperty("webui")]
    public string WebUi { get; set; }
    [JsonProperty("editui")]
    public string EditUi { get; set; }
    [JsonProperty("tinyui")]
    public string TinyUi { get; set; }
}

public class AbstractPageLinks_Object : ObjectLinks
{
    [JsonProperty("webui")]
    public string WebUi { get; set; }
    [JsonProperty("editui")]
    public string EditUi { get; set; }
    //[JsonProperty("edituiv2")]
    //public string EditUiV2 { get; set; }
    [JsonProperty("tinyui")]
    public string TinyUi { get; set; }
}