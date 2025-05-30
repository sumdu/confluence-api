﻿using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class DeleteContentPropertyForFolderRequest
{
    [PathParam]
    [JsonProperty("folder-id")]
    public required string FolderId { get; set; }

    [PathParam]
    [JsonProperty("property-id")]
    public required long PropertyId { get; set; }
}
