using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public enum GetBlogPostsByLabelRequestSortEnum
{
    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "-id")]
    IdDesc,

    [EnumMember(Value = "created-date")]
    CreatedDate,
    
    [EnumMember(Value = "-created-date")]
    CreatedDateDesc,

    [EnumMember(Value = "modified-date")]
    ModifiedDate,

    [EnumMember(Value = "-modified-date")]
    ModifiedDateDesc,
}
