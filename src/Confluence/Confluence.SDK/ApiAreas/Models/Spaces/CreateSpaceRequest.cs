using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Spaces;

public class CreateSpaceRequest
{
    [BodyParam]
    [JsonProperty("name")]
    public required string Name { get; set; }

    [BodyParam]
    [JsonProperty("key")]
    public string? Key { get; set; }

    [BodyParam]
    [JsonProperty("alias")]
    public string? Alias { get; set; }

    [BodyParam]
    [JsonProperty("description")]
    public CreateSpaceRequestDescription? Description { get; set; }

    [BodyParam]
    [JsonProperty("roleAssignments")]
    public CreateSpaceRequestRoleAssignments? RoleAssignments { get; set; }

}
public class CreateSpaceRequestDescription
{
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("representation")]
    public string Representation { get; set; }
}

public class CreateSpaceRequestRoleAssignments
{
    [JsonProperty("principal")]
    public Principal Principal { get; set; }

    [JsonProperty("roleId")]
    public string RoleId { get; set; }
}

