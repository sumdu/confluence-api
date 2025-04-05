using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class DetailedVersion
{
    [JsonProperty("number")]
    public long Number { get; set; }

    [JsonProperty("authorId")]
    public string AuthorId { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("minorEdit")]
    public bool MinorEdit { get; set; }

    [JsonProperty("contentTypeModified")]
    public bool ContentTypeModified { get; set; }

    [JsonProperty("collaborators")]
    public List<string> Collaborators { get; set; }

    [JsonProperty("prevVersion")]
    public int? PrevVersion { get; set; }

    [JsonProperty("nextVersion")]
    public int? NextVersion { get; set; }
}
