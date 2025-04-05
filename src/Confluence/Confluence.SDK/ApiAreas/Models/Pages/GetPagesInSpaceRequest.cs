using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public class GetPagesInSpaceRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required long Id { get; set; }

    [QueryParam]
    [JsonProperty("depth")]
    public GetPagesInSpaceRequestDepthEnum? Depth { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public GetPagesInSpaceRequestSortEnum? Sort { get; set; }

    [QueryParam]
    [JsonProperty("status")]
    public GetPagesInSpaceRequestStatusEnum[]? Status { get; set; }

    [QueryParam]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [QueryParam]
    [JsonProperty("body-format")]
    public GetPagesInSpaceRequestBodyFormatEnum? BodyFormat { get; set; }
}

public enum GetPagesInSpaceRequestDepthEnum
{
    [EnumMember(Value = "all")]
    All,
    [EnumMember(Value = "root")]
    Root
}

public enum GetPagesInSpaceRequestSortEnum
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
    [EnumMember(Value = "title")]
    Title,
    [EnumMember(Value = "-title")]
    TitleDesc
}

public enum GetPagesInSpaceRequestStatusEnum
{
    [EnumMember(Value = "current")]
    Current,
    [EnumMember(Value = "archived")]
    Archived,
    [EnumMember(Value = "deleted")]
    Deleted,
    [EnumMember(Value = "trashed")]
    Trashed
}

public enum GetPagesInSpaceRequestBodyFormatEnum
{
    [EnumMember(Value = "storage")]
    Storage,
    [EnumMember(Value = "atlas_doc_format")]
    AtlasDocFormat
}

