using Confluence.ApiV2.ApiAreas.Models;
using Confluence.ApiV2.ApiAreas.Models.Pages;
using Confluence.ApiV2.ApiAreas.Models.SmartLinks;
using Confluence.ApiV2.ApiAreas.Models.Spaces;
using RestSharp;

namespace Confluence.ApiV2.ApiAreas
{
    public class SmartLinksApi
    {
        private readonly ConfluenceClient client;

        public SmartLinksApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public SmartLinkSingle CreateSmartLink(CreateSmartLinkRequest request)
        {
            var res = client.MakeRequest<SmartLinkSingle>($"embeds", Method.Post, request);
            return res;
        }

        public SmartLinkSingle GetSmartLinkById(GetSmartLinkByIdRequest request)
        {
            var res = client.MakeRequest<SmartLinkSingle>($"embeds/{request.Id}", Method.Get, request);
            return res;
        }

        public void DeleteSmartLink(DeleteSmartLinkRequest request)
        {
            client.MakeRequest<string>($"embeds/{request.Id}", Method.Delete, request);
        }
    }
}
