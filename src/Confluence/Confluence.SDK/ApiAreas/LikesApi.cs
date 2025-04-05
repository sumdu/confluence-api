using Confluence.ApiV2.ApiAreas.Models.Likes;
using RestSharp;

namespace Confluence.ApiV2.ApiAreas
{
    public class LikesApi
    {
        private readonly ConfluenceClient client;

        public LikesApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public GetLikesCountByBlogPostIdResponse GetLikeCountByBlogPostId(GetLikesCountByBlogPostIdRequest request)
        {
            var res = client.MakeRequest<GetLikesCountByBlogPostIdResponse>($"blogposts/{request.Id}/likes/count", Method.Get, request);
            return res;
        }

        public GetAccountIdsOfLikesByBlogPostIdResponse GetLikeCountByBlogPostId(GetAccountIdsOfLikesByBlogPostIdRequest request)
        {
            var res = client.MakeRequest<GetAccountIdsOfLikesByBlogPostIdResponse>($"blogposts/{request.Id}/likes/users", Method.Get, request);
            return res;
        }

        public GetLikesCountByPageIdResponse GetLikesCountByPageId(GetLikesCountByPageIdRequest request)
        {
            var res = client.MakeRequest<GetLikesCountByPageIdResponse>($"pages/{request.Id}/likes/count", Method.Get, request);
            return res;
        }

        public GetAccountIdsOfLikesByPageIdResponse GetLikeCountByPageId(GetAccountIdsOfLikesByPageIdRequest request)
        {
            var res = client.MakeRequest<GetAccountIdsOfLikesByPageIdResponse>($"pages/{request.Id}/likes/users", Method.Get, request);
            return res;
        }

        public GetLikesCountByFooterCommentIdResponse GetLikesCountByFooterCommentId(GetLikesCountByFooterCommentIdRequest request)
        {
            var res = client.MakeRequest<GetLikesCountByFooterCommentIdResponse>($"footer-comments/{request.Id}/likes/count", Method.Get, request);
            return res;
        }

        public GetAccountIdsOfLikesByFooterCommentIdResponse GetLikeCountByFooterCommentId(GetAccountIdsOfLikesByFooterCommentIdRequest request)
        {
            var res = client.MakeRequest<GetAccountIdsOfLikesByFooterCommentIdResponse>($"footer-comments/{request.Id}/likes/users", Method.Get, request);
            return res;
        }

        public GetLikesCountByInlineCommentIdResponse GetLikesCountByInlineCommentId(GetLikesCountByInlineCommentIdRequest request)
        {
            var res = client.MakeRequest<GetLikesCountByInlineCommentIdResponse>($"inline-comments/{request.Id}/likes/count", Method.Get, request);
            return res;
        }

        public GetAccountIdsOfLikesByInlineCommentIdResponse GetLikeCountByInlineCommentId(GetAccountIdsOfLikesByInlineCommentIdRequest request)
        {
            var res = client.MakeRequest<GetAccountIdsOfLikesByInlineCommentIdResponse>($"inline-comments/{request.Id}/likes/users", Method.Get, request);
            return res;
        }
    }
}
