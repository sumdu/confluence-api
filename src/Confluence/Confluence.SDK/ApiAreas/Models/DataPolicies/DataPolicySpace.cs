using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.DataPolicies;

public class DataPolicySpace
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public SpaceDescription Description { get; set; }

    [JsonProperty("dataPolicy")]
    public DataPolicyMetadata DataPolicy { get; set; }

    [JsonProperty("icon")]
    public SpaceIcon Icon { get; set; }

    [JsonProperty("_links")]
    public SpaceLinks Links { get; set; }
}

