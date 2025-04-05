using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public enum BlogPostSortOrder
{
    [EnumMember(Value = "id")]
    Id,
    [EnumMember(Value = "-id")]
    IdDesc,
    [EnumMember(Value = "created-date")]
    CreatedDate,
    [EnumMember(Value = "-created-date")]
    CreatedDateDesc,
    [EnumMember(Value = "modified-date")]
    ModifiedDate,
    [EnumMember(Value = "-modified-date")]
    ModifiedDateDesc,
}
