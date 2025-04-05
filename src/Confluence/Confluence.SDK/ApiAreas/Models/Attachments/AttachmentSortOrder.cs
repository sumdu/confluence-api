using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Attachments;

public enum AttachmentSortOrder
{
    [EnumMember(Value = "created-date")]
    CreatedDate,
    [EnumMember(Value = "-created-date")]
    CreatedDateDesc,
    [EnumMember(Value = "modified-date")]
    ModifiedDate,
    [EnumMember(Value = "-modified-date")]
    ModifiedDateDesc
}
