using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.Attachments;

public enum AttachmentsStatus
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "archived")]
    Archived,
    [EnumMember(Value = "trashed")]
    Trashed
}
