using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Folders;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas
{
    public class FoldersApi
    {
        private readonly ConfluenceClient client;

        public FoldersApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public FolderSingle CreateFolder(CreateFolderRequest request)
        {
            var res = client.MakeRequest<FolderSingle>($"folders", Method.Post, request);
            return res;
        }

        public FolderSingle GetFolderById(GetFolderByIdRequest request)
        {
            var res = client.MakeRequest<FolderSingle>($"folders/{request.Id}", Method.Get, request);
            return res;
        }

        public void DeleteFolder(DeleteFolderRequest request)
        {
            client.MakeRequest<string>($"folders/{request.Id}", Method.Delete, request);
        }
    }
}
