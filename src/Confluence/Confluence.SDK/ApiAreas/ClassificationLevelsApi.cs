using RestSharp;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ClassificationLevels;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas
{
    public class ClassificationLevelsApi
    {
        private readonly ConfluenceClient client;

        public ClassificationLevelsApi(ConfluenceClient client)
        {
            this.client = client;
        }

        public ClassificationLevel[] GetClassificationLevels(GetClassificationLevelsRequest request)
        {
            var res = client.MakeRequest<ClassificationLevel[]>("classification-levels", Method.Get, request);
            return res;
        }

        public ClassificationLevel GetSpaceDefaultClassificationLevel(GetSpaceDefaultClassificationLevelRequest request)
        {
            var res = client.MakeRequest<ClassificationLevel>($"spaces/{request.Id}/classification-level/default", Method.Get, request);
            return res;
        }

        public void UpdateSpaceDefaultClassificationLevel(UpdateSpaceDefaultClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"spaces/{request.Id}/classification-level/default", Method.Put, request);
        }

        public void DeleteSpaceDefaultClassificationLevel(DeleteSpaceDefaultClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"spaces/{request.Id}/classification-level/default", Method.Delete, request);
        }

        public ClassificationLevel GetPageClassificationLevel(GetPageClassificationLevelRequest request)
        {
            var res = client.MakeRequest<ClassificationLevel>($"pages/{request.Id}/classification-level", Method.Get, request);
            return res;
        }

        public void UpdatePageClassificationLevel(UpdatePageClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"pages/{request.Id}/classification-level", Method.Put, request);
        }

        public void ResetPageClassificationLevel(ResetPageClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"pages/{request.Id}/classification-level/reset", Method.Post, request);
        }

        public ClassificationLevel GetBlogPostClassificationLevel(GetBlogPostClassificationLevelRequest request)
        {
            var res = client.MakeRequest<ClassificationLevel>($"blogposts/{request.Id}/classification-level", Method.Get, request);
            return res;
        }

        public void UpdateBlogPostClassificationLevel(UpdateBlogPostClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"blogposts/{request.Id}/classification-level", Method.Put, request);
        }

        public void ResetBlogPostClassificationLevel(ResetBlogPostClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"blogposts/{request.Id}/classification-level/reset", Method.Post, request);
        }

        public ClassificationLevel GetWhiteboardClassificationLevel(GetWhiteboardClassificationLevelRequest request)
        {
            var res = client.MakeRequest<ClassificationLevel>($"whiteboards/{request.Id}/classification-level", Method.Get, request);
            return res;
        }

        public void UpdateWhiteboardClassificationLevel(UpdateWhiteboardClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"whiteboards/{request.Id}/classification-level", Method.Put, request);
        }

        public void ResetWhiteboardClassificationLevel(ResetWhiteboardClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"whiteboards/{request.Id}/classification-level/reset", Method.Post, request);
        }

        public ClassificationLevel GetDatabaseClassificationLevel(GetDatabaseClassificationLevelRequest request)
        {
            var res = client.MakeRequest<ClassificationLevel>($"databases/{request.Id}/classification-level", Method.Get, request);
            return res;
        }

        public void UpdateDatabaseClassificationLevel(UpdateDatabaseClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"databases/{request.Id}/classification-level", Method.Put, request);
        }

        public void ResetDatabaseClassificationLevel(ResetDatabaseClassificationLevelRequest request)
        {
            client.MakeRequest<string>($"databases/{request.Id}/classification-level/reset", Method.Post, request);
        }
    }
}
