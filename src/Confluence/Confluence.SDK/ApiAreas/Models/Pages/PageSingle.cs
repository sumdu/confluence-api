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
    public ParentContentType ParentType { get; set; }
    public int Position { get; set; }
    public string AuthorId { get; set; }
    public string OwnerId { get; set; }
    public string LastOwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public _Common.Version Version { get; set; }
    public BodySingle Body { get; set; }
    public PageSingleLabels Labels { get; set; }
    public PageSingleProperties Properties { get; set; }
    public PageSingleOperations Operations { get; set; }
    public PageSingleLikes Likes { get; set; }
    public PageSingleVersions Versions { get; set; }
    public bool IsFavoritedByCurrentUser { get; set; }
    [JsonProperty("_links")]
    public AbstractPageLinks_Object Links { get; set; }
}

public class PageSingleLabels
{
    public List<Label> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}

public class PageSingleProperties
{
    public List<ContentProperty> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}

public class PageSingleOperations
{
    public List<Operation> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}

public class PageSingleLikes
{
    public List<Like> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}

public class PageSingleVersions
{
    public List<_Common.Version> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}
