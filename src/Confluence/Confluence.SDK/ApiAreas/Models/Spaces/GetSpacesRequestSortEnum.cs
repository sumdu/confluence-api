using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.Spaces;

//[JsonConverter(typeof(StringEnumConverter))]
public enum GetSpacesRequestSortEnum
{
    [EnumMember(Value = "id")]
    Id,
    [EnumMember(Value = "-id")]
    IdDesc,
    [EnumMember(Value = "key")]
    Key,
    [EnumMember(Value = "-key")]
    KeyDesc,
    [EnumMember(Value = "name")]
    Name,
    [EnumMember(Value = "-name")]
    NameDesc,
}
