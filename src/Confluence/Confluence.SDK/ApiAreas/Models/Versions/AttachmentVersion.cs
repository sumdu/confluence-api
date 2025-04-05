using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Versions;
public class AttachmentVersion : _Common.Version
{
    [JsonProperty("attachment")]
    public VersionedEntity Attachment { get; set; }
}
