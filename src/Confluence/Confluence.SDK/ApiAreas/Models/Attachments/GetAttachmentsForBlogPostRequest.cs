using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Attachments;

public class GetAttachmentsForBlogPostRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required int Id { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public AttachmentSortOrder? Sort { get; set; }

    [QueryParam]
    [JsonProperty("status")]
    public AttachmentsStatus[]? Status { get; set; }

    [QueryParam]
    [JsonProperty("mediaType")]
    public string? MediaType { get; set; }

    [QueryParam]
    [JsonProperty("filename")]
    public string? Filename { get; set; }
}

//public enum GetAttachmentsRequestSortEnum
//{
//    [EnumMember(Value = "created-date")]
//    CreatedDate,
//    [EnumMember(Value = "-created-date")]
//    CreatedDateDesc,
//    [EnumMember(Value = "modified-date")]
//    ModifiedDate,
//    [EnumMember(Value = "-modified-date")]
//    ModifiedDateDesc
//}

//public enum GetAttachmentsRequestStatusEnum
//{
//    [EnumMember(Value = "current")]
//    Current,
//    [EnumMember(Value = "archived")]
//    Archived,
//    [EnumMember(Value = "trashed")]
//    Trashed
//}
