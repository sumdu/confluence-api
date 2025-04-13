using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public enum GetCommentResolutionStatusEnum
{
    [EnumMember(Value = "resolved")]
    Resolved,
    [EnumMember(Value = "open")]
    Open,
    [EnumMember(Value = "dangling")]
    Dangling,
    [EnumMember(Value = "reopened")]
    Reopened
}
