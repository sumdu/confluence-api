using Confluence.ApiV2.ApiAreas.Models.Pages;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class SpaceDescription
{
    [JsonProperty("plain")]
    public BodyType Plain { get; set; }

    [JsonProperty("view")]
    public BodyType View { get; set; }
}
