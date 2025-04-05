using Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;
public class BlogPostVersion : _Common.Version
{
    [JsonProperty("blogpost")]
    public VersionedEntity BlogPost { get; set; }
}
