using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public enum InlineCommentResolutionStatusEnum
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
