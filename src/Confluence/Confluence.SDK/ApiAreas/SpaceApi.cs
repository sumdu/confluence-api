using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Spaces;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas
{
    public class SpaceApi
    {
        private readonly ConfluenceClient client;

        public SpaceApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public MultiEntityResult<SpaceBulk> GetSpaces(GetSpacesRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<SpaceBulk>>($"spaces", Method.Get, request);
            return res;
        }

        public SpaceBulk CreateSpace(CreateSpaceRequest request)
        {
            var res = client.MakeRequest<SpaceBulk>($"spaces", Method.Post, request);
            return res;
        }

        public SpaceSingle GetSpaceById(GetSpaceByIdRequest request)
        {
            var res = client.MakeRequest<SpaceSingle>($"spaces/{request.Id}", Method.Get, request);
            return res;
        }
    }
}
