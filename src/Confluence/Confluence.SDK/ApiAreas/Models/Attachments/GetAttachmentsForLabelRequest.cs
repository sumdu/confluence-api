using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Attachments;

public class GetAttachmentsForLabelRequest : PaginatedRequest
{
    [PathParam]
    [JsonProperty("id")]
    public required int Id { get; set; }

    [QueryParam]
    [JsonProperty("sort")]
    public AttachmentSortOrder? Sort { get; set; }
}
