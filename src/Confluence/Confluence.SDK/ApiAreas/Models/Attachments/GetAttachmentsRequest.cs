﻿using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Attachments;

public class GetAttachmentsRequest : PaginatedRequest
{
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
