using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;

public enum ContentStatus
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "draft")]
    Draft,
    [EnumMember(Value = "archived")]
    Archived,
    [EnumMember(Value = "historical")]
    Historical,
    [EnumMember(Value = "trashed")]
    Trashed,
    [EnumMember(Value = "deleted")]
    Deleted,
    [EnumMember(Value = "any")]
    Any
}
