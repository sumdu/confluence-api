using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.ContentProperties;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Versions;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas
{
    public class ContentPropertiesApi
    {
        private readonly ConfluenceClient client;

        public ContentPropertiesApi(ConfluenceClient client)
        {
            this.client = client;
        }

        // Attachment

        public MultiEntityResult<ContentProperty> GetContentPropertiesForAttachment(GetContentPropertiesForAttachmentRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"attachments/{request.AttachmentId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForAttachment(CreateContentPropertyForAttachmentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"attachments/{request.AttachmentId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForAttachment(GetContentPropertyForAttachmentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"attachments/{request.AttachmentId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForAttachment(UpdateContentPropertyForAttachmentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"attachments/{request.AttachmentId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForAttachment(DeleteContentPropertyForAttachmentRequest request)
        {
            client.MakeRequest<string>($"attachments/{request.AttachmentId}/properties/{request.PropertyId}", Method.Delete, request);
        }

        // BlogPost

        public MultiEntityResult<ContentProperty> GetContentPropertiesForBlogPost(GetContentPropertiesForBlogPostRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"blogposts/{request.BlogPostId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForBlogPost(CreateContentPropertyForBlogPostRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"blogposts/{request.BlogPostId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForBlogPost(GetContentPropertyForBlogPostRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"blogposts/{request.BlogPostId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForBlogPost(UpdateContentPropertyForBlogPostRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"blogposts/{request.BlogPostId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForBlogPost(DeleteContentPropertyForBlogPostRequest request)
        {
            client.MakeRequest<string>($"blogposts/{request.BlogPostId}/properties/{request.PropertyId}", Method.Delete, request);
        }

        // CustomContent

        public MultiEntityResult<ContentProperty> GetContentPropertiesForCustomContent(GetContentPropertiesForCustomContentRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"custom-content/{request.CustomContentId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForCustomContent(CreateContentPropertyForCustomContentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"custom-content/{request.CustomContentId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForCustomContent(GetContentPropertyForCustomContentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"custom-content/{request.CustomContentId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForCustomContent(UpdateContentPropertyForCustomContentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"custom-content/{request.CustomContentId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForCustomContent(DeleteContentPropertyForCustomContentRequest request)
        {
            client.MakeRequest<string>($"custom-content/{request.CustomContentId}/properties/{request.PropertyId}", Method.Delete, request);
        }

        // Page

        public MultiEntityResult<ContentProperty> GetContentPropertiesForPage(GetContentPropertiesForPageRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"pages/{request.PageId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForPage(CreateContentPropertyForPageRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"pages/{request.PageId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForPage(GetContentPropertyForPageRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"pages/{request.PageId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForPage(UpdateContentPropertyForPageRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"pages/{request.PageId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForPage(DeleteContentPropertyForPageRequest request)
        {
            client.MakeRequest<string>($"pages/{request.PageId}/properties/{request.PropertyId}", Method.Delete, request);
        }

        // Whiteboard

        public MultiEntityResult<ContentProperty> GetContentPropertiesForWhiteboard(GetContentPropertiesForWhiteboardRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"whiteboards/{request.WhiteboardId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForWhiteboard(CreateContentPropertyForWhiteboardRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"whiteboards/{request.WhiteboardId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForWhiteboard(GetContentPropertyForWhiteboardRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"whiteboards/{request.WhiteboardId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForWhiteboard(UpdateContentPropertyForWhiteboardRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"whiteboards/{request.WhiteboardId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForWhiteboard(DeleteContentPropertyForWhiteboardRequest request)
        {
            client.MakeRequest<string>($"whiteboards/{request.WhiteboardId}/properties/{request.PropertyId}", Method.Delete, request);
        }

        // Database

        public MultiEntityResult<ContentProperty> GetContentPropertiesForDatabase(GetContentPropertiesForDatabaseRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"databases/{request.DatabaseId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForDatabase(CreateContentPropertyForDatabaseRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"databases/{request.DatabaseId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForDatabase(GetContentPropertyForDatabaseRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"databases/{request.DatabaseId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForDatabase(UpdateContentPropertyForDatabaseRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"databases/{request.DatabaseId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForDatabase(DeleteContentPropertyForDatabaseRequest request)
        {
            client.MakeRequest<string>($"databases/{request.DatabaseId}/properties/{request.PropertyId}", Method.Delete, request);
        }

        // SmartLink

        public MultiEntityResult<ContentProperty> GetContentPropertiesForSmartLink(GetContentPropertiesForSmartLinkRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"embeds/{request.SmartLinkId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForSmartLink(CreateContentPropertyForSmartLinkRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"embeds/{request.SmartLinkId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForSmartLink(GetContentPropertyForSmartLinkRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"embeds/{request.SmartLinkId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForSmartLink(UpdateContentPropertyForSmartLinkRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"embeds/{request.SmartLinkId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForSmartLink(DeleteContentPropertyForSmartLinkRequest request)
        {
            client.MakeRequest<string>($"embeds/{request.SmartLinkId}/properties/{request.PropertyId}", Method.Delete, request);
        }

        // Folder

        public MultiEntityResult<ContentProperty> GetContentPropertiesForFolder(GetContentPropertiesForFolderRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"folders/{request.FolderId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForFolder(CreateContentPropertyForFolderRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"folders/{request.FolderId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForFolder(GetContentPropertyForFolderRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"folders/{request.FolderId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForFolder(UpdateContentPropertyForFolderRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"folders/{request.FolderId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForFolder(DeleteContentPropertyForFolderRequest request)
        {
            client.MakeRequest<string>($"folders/{request.FolderId}/properties/{request.PropertyId}", Method.Delete, request);
        }

        // Comment
        public MultiEntityResult<ContentProperty> GetContentPropertiesForComment(GetContentPropertiesForCommentRequest request)
        {
            var res = client.MakeRequest<MultiEntityResult<ContentProperty>>($"comments/{request.CommentId}/properties", Method.Get, request);
            return res;
        }

        public ContentProperty CreateContentPropertyForComment(CreateContentPropertyForCommentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"comments/{request.CommentId}/properties", Method.Post, request);
            return res;
        }

        public ContentProperty GetContentPropertyForComment(GetContentPropertyForCommentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"comments/{request.CommentId}/properties/{request.PropertyId}", Method.Get, request);
            return res;
        }

        public ContentProperty UpdateContentPropertyForComment(UpdateContentPropertyForCommentRequest request)
        {
            var res = client.MakeRequest<ContentProperty>($"comments/{request.CommentId}/properties/{request.PropertyId}", Method.Put, request);
            return res;
        }

        public void DeleteContentPropertyForComment(DeleteContentPropertyForCommentRequest request)
        {
            client.MakeRequest<string>($"comments/{request.CommentId}/properties/{request.PropertyId}", Method.Delete, request);
        }
    }
}
