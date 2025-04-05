using Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;
public class CustomContentVersion : _Common.Version
{
    [JsonProperty("custom")]
    public VersionedEntity CustomContent { get; set; }
}
