using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public abstract class AbstractComment
{
    public string Id { get; set; }
    public ContentStatus Status { get; set; }
    public string Title { get; set; }
    public _Common.Version Version { get; set; }

    // TODO: all children must define this property. No need to have it in the base class
    [JsonProperty("_links")]
    public CommentLinks Links { get; set; }
}

public class CommentLinks
{
    [JsonProperty("webui")]
    public string Webui { get; set; }
}