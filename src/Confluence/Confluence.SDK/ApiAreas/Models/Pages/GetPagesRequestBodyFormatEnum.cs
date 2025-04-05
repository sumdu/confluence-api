using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public enum GetPagesRequestBodyFormatEnum
{
    [EnumMember(Value = "storage")]
    Storage,

    [EnumMember(Value = "atlas_doc_format")]
    AtlasDocFormat,
}
