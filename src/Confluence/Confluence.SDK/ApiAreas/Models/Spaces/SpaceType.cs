using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Spaces;

//[JsonConverter(typeof(StringEnumConverter))]
public enum SpaceType
{
    [EnumMember(Value = "global")]
    Global,
    [EnumMember(Value = "personal")]
    Personal,
    [EnumMember(Value = "collaboration")]
    Collaboration,
    [EnumMember(Value = "knowledge_base")]
    KnowledgeBase,
}
