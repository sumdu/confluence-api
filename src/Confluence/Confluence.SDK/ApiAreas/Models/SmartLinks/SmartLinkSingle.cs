using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.ApiAreas.Models.Pages;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.SmartLinks;

public class SmartLinkSingle
{
    public string Id { get; set; }
    public string Type { get; set; }
    public ContentStatus Status { get; set; }
    public string Title { get; set; }
    public string ParentId { get; set; }
    public ParentContentType ParentType { get; set; }
    public long Position { get; set; }
    public string AuthorId { get; set; }
    public string OwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public string EmbedUrl { get; set; }
    public _Common.Version Version { get; set; }

    [JsonProperty("_links")]
    public SmartLinkLinks_Object Links { get; set; }
}
