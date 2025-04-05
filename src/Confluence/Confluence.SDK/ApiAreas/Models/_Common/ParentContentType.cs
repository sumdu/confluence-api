using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public enum SpaceSortOrder
{
    [EnumMember(Value = "id")]
    Id,
    [EnumMember(Value = "-id")]
    IdDesc,
    [EnumMember(Value = "key")]
    Key,
    [EnumMember(Value = "-key")]
    KeyDesc,
    [EnumMember(Value = "name")]
    Name,
    [EnumMember(Value = "-name")]
    NameDesc
}
