using Confluence.ApiV2.ApiAreas.Models;
using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.ApiAreas.Models.Versions;
using RestSharp;

namespace Confluence.ApiV2.ApiAreas
{
    public class VersionsApi
    {
        private readonly ConfluenceClient client;

        public VersionsApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public MultiEntityResult<AttachmentVersion> GetAttachmentVersions(GetAttachmentVersionsRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<AttachmentVersion>>($"attachments/{request.Id}/versions", Method.Get, request);
            return res;
        }

        public DetailedVersion GetVersionDetailsForAttachmentVersion(GetVersionDetailsForAttachmentVersionRequest request)
        {
            var res = client.MakeRequest<DetailedVersion>($"attachments/{request.AttachmentId}/versions/{request.VersionNumber}", Method.Get, request);
            return res;
        }

        public MultiEntityResult<BlogPostVersion> GetBlogPostVersions(GetBlogPostVersionsRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<BlogPostVersion>>($"blogposts/{request.Id}/versions", Method.Get, request);
            return res;
        }

        public DetailedVersion GetVersionDetailsForBlogPostVersion(GetVersionDetailsForBlogPostVersionRequest request)
        {
            var res = client.MakeRequest<DetailedVersion>($"blogposts/{request.BlogPostId}/versions/{request.VersionNumber}", Method.Get, request);
            return res;
        }

        public MultiEntityResult<PageVersion> GetPageVersions(GetPageVersionsRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<PageVersion>>($"pages/{request.Id}/versions", Method.Get, request);
            return res;
        }

        public DetailedVersion GetVersionDetailsForPageVersion(GetVersionDetailsForPageVersionRequest request)
        {
            var res = client.MakeRequest<DetailedVersion>($"pages/{request.PageId}/versions/{request.VersionNumber}", Method.Get, request);
            return res;
        }

        public MultiEntityResult<CustomContentVersion> GetCustomContentVersions(GetCustomContentVersionsRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<CustomContentVersion>>($"custom-content/{request.CustomContentId}/versions", Method.Get, request);
            return res;
        }

        public DetailedVersion GetVersionDetailsForCustomContentVersion(GetVersionDetailsForCustomContentVersionRequest request)
        {
            var res = client.MakeRequest<DetailedVersion>($"custom-content/{request.CustomContentId}/versions/{request.VersionNumber}", Method.Get, request);
            return res;
        }

        public MultiEntityResult<CommentVersion> GetFooterCommentVersions(GetFooterCommentVersionsRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<CommentVersion>>($"footer-comments/{request.Id}/versions", Method.Get, request);
            return res;
        }

        public DetailedVersion GetVersionDetailsForFooterCommentVersion(GetVersionDetailsForFooterCommentVersionRequest request)
        {
            var res = client.MakeRequest<DetailedVersion>($"footer-comments/{request.Id}/versions/{request.VersionNumber}", Method.Get, request);
            return res;
        }

        public MultiEntityResult<CommentVersion> GetInlineCommentVersions(GetInlineCommentVersionsRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<CommentVersion>>($"inline-comments/{request.Id}/versions", Method.Get, request);
            return res;
        }

        public DetailedVersion GetVersionDetailsForInlineCommentVersion(GetVersionDetailsForInlineCommentVersionRequest request)
        {
            var res = client.MakeRequest<DetailedVersion>($"inline-comments/{request.Id}/versions/{request.VersionNumber}", Method.Get, request);
            return res;
        }
    }
}
