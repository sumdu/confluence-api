using Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public class BlogPostBulk
{
    public string Id { get; set; }
    public ContentStatus Status { get; set; }
    public string Title { get; set; }
    public string SpaceId { get; set; }
    public string AuthorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public _Common.Version Version { get; set; }
    public BodySingle Body { get; set; }
   
    [JsonProperty("_links")]
    public AbstractPageLinks Links { get; set; }
}
