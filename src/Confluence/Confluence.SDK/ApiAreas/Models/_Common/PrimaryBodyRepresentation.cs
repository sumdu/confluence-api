using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public enum PrimaryBodyRepresentation
{
    [EnumMember(Value = "storage")]
    Storage,
    [EnumMember(Value = "atlas_doc_format")]
    AtlasDocFormat,
}
