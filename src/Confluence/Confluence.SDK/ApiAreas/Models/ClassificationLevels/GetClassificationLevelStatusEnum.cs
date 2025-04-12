using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ClassificationLevels;

public enum GetClassificationLevelStatusEnum
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "draft")]
    Draft,
    [EnumMember(Value = "archived")]
    Archived,
}
