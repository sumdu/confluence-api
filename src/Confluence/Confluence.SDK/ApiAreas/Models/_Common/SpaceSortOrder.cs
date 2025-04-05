using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public enum ParentContentType
{
    [EnumMember(Value = "page")]
    Page,
    [EnumMember(Value = "whiteboard")]
    Whiteboard,
    [EnumMember(Value = "database")]
    Database,
    [EnumMember(Value = "embed")]
    Embed,
    [EnumMember(Value = "folder")]
    Folder
}
