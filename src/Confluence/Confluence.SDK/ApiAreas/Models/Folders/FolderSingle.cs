using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public class FolderSingle
{
    public string Id { get; set; }
    public string Type { get; set; }
    public ContentStatus Status { get; set; }
    public string Title { get; set; }
    public string ParentId { get; set; }
    public ParentContentType ParentType { get; set; }
    public int Position { get; set; }
    public string AuthorId { get; set; }
    public string OwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public _Common.Version Version { get; set; }
    [JsonProperty("_links")]
    public AbstractFolderLinks_Object Links { get; set; }
}
