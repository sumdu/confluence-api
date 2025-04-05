using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Ancestors;

public enum AncestorType
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
