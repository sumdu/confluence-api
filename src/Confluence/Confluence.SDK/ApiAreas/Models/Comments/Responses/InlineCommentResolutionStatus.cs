using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

public enum InlineCommentResolutionStatus
{
    [EnumMember(Value = "open")]
    Open,
    [EnumMember(Value = "reopened")]
    Reopened,
    [EnumMember(Value = "resolved")]
    Resolved,
    [EnumMember(Value = "dangling")]
    Dangling,
}
