using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public class PageSingle
{
    public string Id { get; set; }
    public ContentStatus Status { get; set; }
    public string Title { get; set; }
    public string SpaceId { get; set; }
    public string ParentId { get; set; }
    public ParentContentType? ParentType { get; set; }
    public int Position { get; set; }
    public string AuthorId { get; set; }
    public string OwnerId { get; set; }
    public string LastOwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public _Common.Version Version { get; set; }
    public BodySingle Body { get; set; }
    public LabelResults Labels { get; set; }
    public ContentPropertyResults Properties { get; set; }
    public OperationResults Operations { get; set; }
    public LikeResults Likes { get; set; }
    public VersionResults Versions { get; set; }
    public bool IsFavoritedByCurrentUser { get; set; }
    [JsonProperty("_links")]
    public AbstractPageLinks_Object Links { get; set; }
}