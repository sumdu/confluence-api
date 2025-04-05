using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Spaces;

//[JsonConverter(typeof(StringEnumConverter))]
public enum GetSpacesRequestDescriptionEnum
{
    [EnumMember(Value = "plain")]
    Plain,

    [EnumMember(Value = "view")]
    View,
}
