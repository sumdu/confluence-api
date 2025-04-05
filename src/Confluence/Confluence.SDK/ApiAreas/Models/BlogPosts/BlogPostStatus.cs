using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public enum BlogPostStatus
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "deleted")]
    Deleted,
    [EnumMember(Value = "trashed")]
    Trashed
}
