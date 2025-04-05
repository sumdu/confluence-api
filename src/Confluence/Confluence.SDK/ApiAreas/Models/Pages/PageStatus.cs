using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public enum PageStatus
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "archived")]
    Archived,
    [EnumMember(Value = "deleted")]
    Deleted,
    [EnumMember(Value = "trashed")]
    Trashed
}
