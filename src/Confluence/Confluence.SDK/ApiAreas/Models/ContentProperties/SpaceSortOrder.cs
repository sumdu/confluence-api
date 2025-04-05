using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public enum ContentPropertySortOrder
{
    [EnumMember(Value = "key")]
    Key,
    [EnumMember(Value = "-key")]
    KeyDesc,
}
