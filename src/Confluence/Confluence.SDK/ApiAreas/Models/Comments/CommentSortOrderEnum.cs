using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;
public enum CommentSortOrderEnum
{
    [EnumMember(Value = "created-date")]
    CreatedDate,
    
    [EnumMember(Value = "-created-date")]
    CreatedDateDesc,

    [EnumMember(Value = "modified-date")]
    ModifiedDate,

    [EnumMember(Value = "-modified-date")]
    ModifiedDateDesc,
}
