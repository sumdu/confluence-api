using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.Versions;

public enum VersionSortOrder
{
    [EnumMember(Value = "modified-date")]
    ModifiedDate,
    [EnumMember(Value = "-modified-date")]
    ModifiedDateDesc,
}
