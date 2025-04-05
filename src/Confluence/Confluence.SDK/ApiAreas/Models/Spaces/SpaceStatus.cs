using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.Spaces;

//[JsonConverter(typeof(StringEnumConverter))]
public enum SpaceStatus
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "archived")]
    Archived,
}
