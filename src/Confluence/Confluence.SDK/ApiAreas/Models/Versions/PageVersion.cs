using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Versions;
public class PageVersion : _Common.Version
{
    [JsonProperty("page")]
    public VersionedEntity Page { get; set; }
}
