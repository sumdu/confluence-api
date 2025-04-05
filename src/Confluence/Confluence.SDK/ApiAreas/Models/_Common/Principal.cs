using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class Principal
{
    [JsonProperty("principalType")]
    public PrincipalType PrincipalType { get; set; }

    [JsonProperty("principalId")]
    public string PrincipalId { get; set; }
}

public enum PrincipalType
{
    [JsonProperty("USER")]
    User,

    [JsonProperty("GROUP")]
    Group,

    [JsonProperty("ACCESS_CLASS")]
    AccessClass
}