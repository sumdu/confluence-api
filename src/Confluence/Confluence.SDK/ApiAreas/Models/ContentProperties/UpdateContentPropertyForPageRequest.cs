﻿using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class UpdateContentPropertyForPageRequest
{
    [PathParam]
    [JsonProperty("page-id")]
    public required string PageId { get; set; }

    [PathParam]
    [JsonProperty("property-id")]
    public required long PropertyId { get; set; }

    [BodyParam]
    [JsonProperty("key")]
    public string? Key { get; set; }

    [BodyParam]
    [JsonProperty("value")]
    public object? Value { get; set; }

    [BodyParam]
    [JsonProperty("version")]
    public VersionUpdate? Version { get; set; }
}
