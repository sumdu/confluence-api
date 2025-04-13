using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public enum GetCommentStatusEnum
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "archived")]
    Archived,
    [EnumMember(Value = "trashed")]
    Trashed,
    [EnumMember(Value = "deleted")]
    Deleted,
    [EnumMember(Value = "historical")]
    Historical,
    [EnumMember(Value = "draft")]
    Draft
}
