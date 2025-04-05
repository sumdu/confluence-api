using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public enum BlogPostCreateStatus
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "draft")]
    Draft,
}
