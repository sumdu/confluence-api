using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public class PageBulk
{
    public string Id { get; set; }
    public ContentStatus Status { get; set; }
    public string Title { get; set; }
    public string SpaceId { get; set; }
    public string ParentId { get; set; }
    public ParentContentType? ParentType { get; set; }
    public long? Position { get; set; }
    public string AuthorId { get; set; }
    public string OwnerId { get; set; }
    public string? LastOwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public _Common.Version Version { get; set; }
    public BodySingle Body { get; set; }
   
    [JsonProperty("_links")]
    public AbstractPageLinks Links { get; set; }
}
