using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Attachments;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas
{
    public class AttachmentsApi
    {
        private readonly ConfluenceClient client;

        public AttachmentsApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public MultiEntityResult<AttachmentBulk> GetSpaces(GetAttachmentsRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<AttachmentBulk>>($"attachments", Method.Get, request);
            return res;
        }

        public AttachmentSingle GetAttachmentById(GetAttachmentByIdRequest request)
        {
            var res = client.MakeRequest<AttachmentSingle>($"attachments/{request.Id}", Method.Get, request);
            return res;
        }

        public void DeleteAttachment(DeleteAttachmentRequest request)
        {
            client.MakeRequest<string>($"attachments/{request.Id}", Method.Delete, request);
        }

        public MultiEntityResult<AttachmentBulk> GetAttachmentsForBlogPost(GetAttachmentsForBlogPostRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<AttachmentBulk>>($"blogposts/{request.Id}/attachments", Method.Get, request);
            return res;
        }

        public MultiEntityResult<AttachmentBulk> GetAttachmentsForCustomContent(GetAttachmentsForCustomContentRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<AttachmentBulk>>($"custom-content/{request.Id}/attachments", Method.Get, request);
            return res;
        }

        public MultiEntityResult<AttachmentBulk> GetAttachmentsForLabel(GetAttachmentsForLabelRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<AttachmentBulk>>($"labels/{request.Id}/attachments", Method.Get, request);
            return res;
        }

        public MultiEntityResult<AttachmentBulk> GetAttachmentsForPage(GetAttachmentsForPageRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<AttachmentBulk>>($"pages/{request.Id}/attachments", Method.Get, request);
            return res;
        }
    }
}
