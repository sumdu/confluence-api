using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Folders;
public class DeleteFolderRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required long Id { get; set; }
}
