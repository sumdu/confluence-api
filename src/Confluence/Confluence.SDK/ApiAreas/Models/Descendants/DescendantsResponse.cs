﻿using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Descendants;

public class DescendantsResponse
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("status")]
    public OnlyArchivedAndCurrentContentStatus Status { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("childPosition")]
    public long ChildPosition { get; set; }
}
