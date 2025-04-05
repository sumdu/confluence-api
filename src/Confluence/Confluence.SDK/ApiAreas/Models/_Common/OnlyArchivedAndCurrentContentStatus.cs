using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models._Common;

public enum OnlyArchivedAndCurrentContentStatus
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "archived")]
    Archived,
}
