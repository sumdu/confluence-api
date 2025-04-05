using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Versions;
public class CommentVersion : _Common.Version
{
    [JsonProperty("comment")]
    public VersionedEntity Comment { get; set; }
}
