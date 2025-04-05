using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Likes
{
    public class GetLikesCountByFooterCommentIdRequest
    {
        [PathParam]
        [JsonProperty("id")]
        public required int Id { get; set; }
    }
}