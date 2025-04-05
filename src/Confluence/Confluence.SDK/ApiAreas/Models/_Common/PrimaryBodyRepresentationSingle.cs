using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models._Common
{
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum PrimaryBodyRepresentationSingle
    {
        [EnumMember(Value = "storage")]
        Storage,
        [EnumMember(Value = "atlas_doc_format")]
        AtlasDocFormat,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "export_view")]
        ExportView,
        [EnumMember(Value = "anonymous_export_view")]
        AnonymousExportView,
        [EnumMember(Value = "styled_view")]
        StyledView,
        [EnumMember(Value = "editor")]
        Editor
    }
}
