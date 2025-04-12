using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ClassificationLevels;
public class ClassificationLevel
{
    public string Id { get; set; }
    public ClassificationLevelStatusEnum Status { get; set; }
    public int Order { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Guideline { get; set; }
    public ClassificationLevelColor Color { get; set; }
}

public enum ClassificationLevelStatusEnum
{
    [EnumMember(Value = "DRAFT")]
    Draft,
    [EnumMember(Value = "PUBLISHED")]
    Published,
    [EnumMember(Value = "ARCHIVED")]
    Archived
}
public enum ClassificationLevelColor
{
    [EnumMember(Value = "RED")]
    RED,
    [EnumMember(Value = "RED_BOLD")]
    RED_BOLD,
    [EnumMember(Value = "ORANGE")]
    ORANGE,
    [EnumMember(Value = "YELLOW")]
    YELLOW,
    [EnumMember(Value = "GREEN")]
    GREEN,
    [EnumMember(Value = "BLUE")]
    BLUE,
    [EnumMember(Value = "NAVY")]
    NAVY,
    [EnumMember(Value = "TEAL")]
    TEAL,
    [EnumMember(Value = "PURPLE")]
    PURPLE,
    [EnumMember(Value = "GREY")]
    GREY,
    [EnumMember(Value = "LIME")]
    LIME
}