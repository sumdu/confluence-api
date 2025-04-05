using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas
{
    public class PageApi
    {
        private readonly ConfluenceClient client;

        public PageApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public MultiEntityResult<PageBulk> GetPagesByLabel(GetPagesByLabelRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<PageBulk>>($"labels/{request.Id}/pages", Method.Get, request);
            return res;
        }

        public MultiEntityResult<PageBulk> GetPages(GetPagesRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<PageBulk>>($"pages", Method.Get, request);
            return res;
        }

        public PageSingle CreatePage(CreatePageRequest request)
        {
            var res = client.MakeRequest<PageSingle>($"pages", Method.Post, request);
            return res;
        }

        public PageSingle GetPageById(GetPageByIdRequest request)
        {
            var res = client.MakeRequest<PageSingle>($"pages/{request.PageId}", Method.Get, request);
            return res;
        }

        public PageSingle UpdatePage(UpdatePageRequest request)
        {
            var res = client.MakeRequest<PageSingle>($"pages/{request.Id}", Method.Put, request);
            return res;
        }

        public void DeletePage(DeletePageRequest request)
        {
            client.MakeRequest<string>($"pages/{request.Id}", Method.Delete, request);
        }

        public MultiEntityResult<PageBulk> GetPagesInSpace(GetPagesInSpaceRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<PageBulk>>($"spaces/{request.Id}/pages", Method.Get, request);
            return res;
        }
    }
}
