using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Likes;

public class Like
{
    [JsonProperty("accountId")]
    public string AccountId { get; set; }
}
