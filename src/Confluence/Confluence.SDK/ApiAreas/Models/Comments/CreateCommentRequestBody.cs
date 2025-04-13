using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;

public /* abstract */ class CreateCommentRequestBody // used for Create and Update
{
}


public class CreateCommentRequestBodyWrite : CreateCommentRequestBody
{
    [JsonProperty("representation")]
    public CreateCommentRequestBodyFormat Representation { get; set; }
    [JsonProperty("value")]
    public string Value { get; set; }
}

public class CreateCommentRequestNestedBodyWrite : CreateCommentRequestBody
{
    [JsonProperty("storage")]
    public CreateCommentRequestBodyWrite Storage { get; set; }
    [JsonProperty("atlas_doc_format")]
    public CreateCommentRequestBodyWrite AtlasDocFormat { get; set; }
    [JsonProperty("wiki")]
    public CreateCommentRequestBodyWrite Wiki { get; set; }
}

public enum CreateCommentRequestBodyFormat
{
    [EnumMember(Value = "storage")]
    Storage,
    [EnumMember(Value = "atlas_doc_format")]
    AtlasDocFormat,
    [EnumMember(Value = "wiki")]
    Wiki,
}