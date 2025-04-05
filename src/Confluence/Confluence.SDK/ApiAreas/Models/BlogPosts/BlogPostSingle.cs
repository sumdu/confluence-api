using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public class BlogPostSingle
{
    public string Id { get; set; }
    public ContentStatus Status { get; set; }
    public string Title { get; set; }
    public string SpaceId { get; set; }
    public string AuthorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public _Common.Version Version { get; set; }
    public BodySingle Body { get; set; }
    public BlogPostSingleLabels Labels { get; set; }
    public BlogPostSingleProperties Properties { get; set; }
    public BlogPostSingleOperations Operations { get; set; }
    public BlogPostSingleLikes Likes { get; set; }
    public BlogPostSingleVersions Versions { get; set; }
    public bool IsFavoritedByCurrentUser { get; set; }
    [JsonProperty("_links")]
    public AbstractPageLinks_Object Links { get; set; }
}

public class BlogPostSingleLabels
{
    public List<Label> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}

public class BlogPostSingleProperties
{
    public List<ContentProperty> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}

public class BlogPostSingleOperations
{
    public List<Operation> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}

public class BlogPostSingleLikes
{
    public List<Like> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}

public class BlogPostSingleVersions
{
    public List<_Common.Version> Results { get; set; }
    public OptionalFieldMeta Meta { get; set; }
    public OptionalFieldLinks Links { get; set; }
}
