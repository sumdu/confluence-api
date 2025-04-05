﻿using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.ContentProperties;

public class GetContentPropertyForBlogPostRequest
{
    [PathParam]
    [JsonProperty("blogpost-id")]
    public required string BlogPostId { get; set; }

    [PathParam]
    [JsonProperty("property-id")]
    public required long PropertyId { get; set; }
}
