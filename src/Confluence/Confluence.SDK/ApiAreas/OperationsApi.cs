using Confluence.ApiV2.ApiAreas.Models.Operations;
using Confluence.ApiV2.ApiAreas.Models.Labels;
using RestSharp;
using Confluence.ApiV2.ApiAreas.Models;
using Confluence.ApiV2.ApiAreas.Models._Common;

namespace Confluence.ApiV2.ApiAreas
{
    public class OperationsApi
    {
        private readonly ConfluenceClient client;

        public OperationsApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public PermittedOperationsResponse GetPermittedOperationsForAttachment(GetPermittedOperationsForAttachmentRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"attachments/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForBlogPost(GetPermittedOperationsForBlogPostRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"blogposts/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForCustomContent(GetPermittedOperationsForCustomContentRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"custom-content/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForPage(GetPermittedOperationsForPageRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"pages/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForWhiteboard(GetPermittedOperationsForWhiteboardRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"whiteboards/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForDatabase(GetPermittedOperationsForDatabaseRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"databases/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForSmartLink(GetPermittedOperationsForSmartLinkRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"embeds/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForFolder(GetPermittedOperationsForFolderRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"folders/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForSpace(GetPermittedOperationsForSpaceRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"spaces/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForFooterComment(GetPermittedOperationsForFooterCommentRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"footer-comments/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public PermittedOperationsResponse GetPermittedOperationsForInlineComment(GetPermittedOperationsForInlineCommentRequest request)
        {
            var res = client.MakeRequest<PermittedOperationsResponse>($"inline-comments/{request.Id}/operations", Method.Get, request);
            return res;
        }

        public MultiEntityResult<Label> GetLabelsForAttachment(GetLabelsForAttachmentRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<Label>>($"attachments/{request.Id}/labels", Method.Get, request);
            return res;
        }
    }
}
