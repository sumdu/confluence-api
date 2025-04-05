using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

//[JsonConverter(typeof(StringEnumConverter))]
public enum UpdateBlogPostRequestStatusEnum
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "draft")]
    Draft
}
