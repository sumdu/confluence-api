using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Pages;

public class UpdatePageRequestVersion
{
    [JsonProperty("number")]
    public long Number { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }
}
