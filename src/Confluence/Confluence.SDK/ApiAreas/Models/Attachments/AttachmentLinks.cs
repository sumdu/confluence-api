using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Attachments;

public class AttachmentLinks : ObjectLinks
{
    [JsonProperty("webui")]
    public string Webui { get; set; }

    [JsonProperty("download")]
    public string Download { get; set; }
}
