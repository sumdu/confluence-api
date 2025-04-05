using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.Spaces;

public class GetSpaceByIdRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required int Id { get; set; }

    [QueryParam]
    [JsonProperty("description-format")]
    public SpaceDescriptionBodyRepresentation? DescriptionFormat { get; set; }

    [QueryParam]
    [JsonProperty("include-icon")]
    public bool? IncludeIcon { get; set; }

    [QueryParam]
    [JsonProperty("include-operations")]
    public bool? IncludeOperations { get; set; }

    [QueryParam]
    [JsonProperty("include-properties")]
    public bool? IncludeProperties { get; set; }

    [QueryParam]
    [JsonProperty("include-permissions")]
    public bool? IncludePermissions { get; set; }

    [QueryParam]
    [JsonProperty("include-role-assignments")]
    public bool? IncludeRoleAssignments { get; set; }

    [QueryParam]
    [JsonProperty("include-labels")]
    public bool? IncludeLabels { get; set; }
}

public enum SpaceDescriptionBodyRepresentation
{
    [EnumMember(Value = "plain")]
    Plain,
    [EnumMember(Value = "view")]
    View
}