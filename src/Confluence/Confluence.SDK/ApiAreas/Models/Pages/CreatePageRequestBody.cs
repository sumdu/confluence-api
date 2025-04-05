using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.Pages;

public /* abstract */ class CreatePageRequestBody // used for Create and Update
{
}


public class CreatePageRequestBodyWrite : CreatePageRequestBody
{
    [JsonProperty("representation")]
    public CreatePageRequestBodyFormat Representation { get; set; }
    [JsonProperty("value")]
    public string Value { get; set; }
}

public class CreatePageRequestNestedBodyWrite : CreatePageRequestBody
{
    [JsonProperty("storage")]
    public CreatePageRequestBodyWrite Storage { get; set; }
    [JsonProperty("atlas_doc_format")]
    public CreatePageRequestBodyWrite AtlasDocFormat { get; set; }
    [JsonProperty("wiki")]
    public CreatePageRequestBodyWrite Wiki { get; set; }
}

public enum CreatePageRequestBodyFormat
{
    [EnumMember(Value = "storage")]
    Storage,
    [EnumMember(Value = "atlas_doc_format")]
    AtlasDocFormat,
    [EnumMember(Value = "wiki")]
    Wiki,
}