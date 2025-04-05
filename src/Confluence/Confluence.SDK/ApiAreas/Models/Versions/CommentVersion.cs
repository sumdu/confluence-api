using Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;
public class CommentVersion : _Common.Version
{
    [JsonProperty("comment")]
    public VersionedEntity Comment { get; set; }
}
