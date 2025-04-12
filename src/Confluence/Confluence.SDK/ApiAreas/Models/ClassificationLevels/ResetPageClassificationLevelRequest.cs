﻿using Newtonsoft.Json;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ClassificationLevels;
public class ResetPageClassificationLevelRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required string Id { get; set; }

    [BodyParam]
    [JsonProperty("status")]
    public required UpdateClassificationLevelEnum Status { get; set; }
}
