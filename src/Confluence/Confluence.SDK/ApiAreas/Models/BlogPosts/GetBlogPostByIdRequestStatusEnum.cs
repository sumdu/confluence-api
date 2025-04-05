using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public enum GetBlogPostByIdRequestStatusEnum
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "archived")]
    Archived,
    [EnumMember(Value = "trashed")]
    Trashed,
    [EnumMember(Value = "deleted")]
    Deleted,
    [EnumMember(Value = "historical")]
    Historical,
    [EnumMember(Value = "draft")]
    Draft
}
