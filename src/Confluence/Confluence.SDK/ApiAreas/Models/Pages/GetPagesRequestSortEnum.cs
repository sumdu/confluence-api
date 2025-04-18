﻿using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public enum GetPagesRequestSortEnum
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
    TitleDesc,
}
