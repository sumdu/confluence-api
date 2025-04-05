using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Confluence.ApiV2.ApiAreas.Models.BlogPosts;

public /* abstract */ class CreateBlogPostRequestBody // used for Create and Update
{
}


public class CreateBlogPostRequestBodyWrite : CreateBlogPostRequestBody
{
    [JsonProperty("representation")]
    public CreateBlogPostRequestBodyFormat Representation { get; set; }
    [JsonProperty("value")]
    public string Value { get; set; }
}

public class CreateBlogPostRequestNestedBodyWrite : CreateBlogPostRequestBody
{
    [JsonProperty("storage")]
    public CreateBlogPostRequestBodyWrite Storage { get; set; }
    [JsonProperty("atlas_doc_format")]
    public CreateBlogPostRequestBodyWrite AtlasDocFormat { get; set; }
    [JsonProperty("wiki")]
    public CreateBlogPostRequestBodyWrite Wiki { get; set; }
}

public enum CreateBlogPostRequestBodyFormat
{
    [EnumMember(Value = "storage")]
    Storage,
    [EnumMember(Value = "atlas_doc_format")]
    AtlasDocFormat,
    [EnumMember(Value = "wiki")]
    Wiki,
}