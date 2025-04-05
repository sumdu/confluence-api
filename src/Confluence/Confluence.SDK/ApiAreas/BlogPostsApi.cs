using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.BlogPosts;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas
{
    public class BlogPostsApi
    {
        private readonly ConfluenceClient client;

        public BlogPostsApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public MultiEntityResult<BlogPostBulk> GetBlogPosts(GetBlogPostsRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<BlogPostBulk>>($"blogposts", Method.Get, request);
            return res;
        }

        public BlogPostSingle CreateBlogPost(CreateBlogPostRequest request)
        {
            var res = client.MakeRequest<BlogPostSingle>($"blogposts", Method.Post, request);
            return res;
        }

        public BlogPostSingle GetBlogPostById(GetBlogPostByIdRequest request)
        {
            var res = client.MakeRequest<BlogPostSingle>($"blogposts/{request.Id}", Method.Get, request);
            return res;
        }

        public BlogPostSingle UpdateBlogPost(UpdateBlogPostRequest request)
        {
            var res = client.MakeRequest<BlogPostSingle>($"blogposts/{request.Id}", Method.Put, request);
            return res;
        }

        public void DeleteBlogPost(DeleteBlogPostRequest request)
        {
            client.MakeRequest<string>($"blogposts/{request.Id}", Method.Delete, request);
        }

        public MultiEntityResult<BlogPostBulk> GetBlogPostsByLabel(GetBlogPostsByLabelRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<BlogPostBulk>>($"labels/{request.Id}/blogposts", Method.Get, request);
            return res;
        }

        public MultiEntityResult<BlogPostBulk> GetBlogPostsInSpace(GetBlogPostsInSpaceRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<BlogPostBulk>>($"spaces/{request.Id}/blogposts", Method.Get, request);
            return res;
        }
    }
}
