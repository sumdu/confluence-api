using RestSharp;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Comments.Responses;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas;

public class CommentsApi
{
    private readonly ConfluenceClient client;

    public CommentsApi(ConfluenceClient client)
    {
        this.client = client;
    }

    public MultiEntityResult<AttachmentCommentModel> GetAttachmentComments(GetAttachmentCommentsRequest request)
    {
        return client.MakeRequest<MultiEntityResult<AttachmentCommentModel>>($"attachments/{request.Id}/footer-comments", Method.Get, request);
    }

    public MultiEntityResult<CustomContentCommentModel> GetCustomContentComments(GetCustomContentCommentsRequest request)
    {
        return client.MakeRequest<MultiEntityResult<CustomContentCommentModel>>($"custom-content/{request.Id}/footer-comments", Method.Get, request);
    }

    public MultiEntityResult<PageCommentModel> GetPageFooterComments(GetPageFooterCommentsRequest request)
    {
        return client.MakeRequest<MultiEntityResult<PageCommentModel>>($"pages/{request.Id}/footer-comments", Method.Get, request);
    }

    public MultiEntityResult<PageInlineCommentModel> GetPageInlineComments(GetPageInlineCommentsRequest request)
    {
        return client.MakeRequest<MultiEntityResult<PageInlineCommentModel>>($"pages/{request.Id}/inline-comments", Method.Get, request);
    }

    public MultiEntityResult<BlogPostCommentModel> GetBlogPostFooterComments(GetBlogPostFooterCommentsRequest request)
    {
        return client.MakeRequest<MultiEntityResult<BlogPostCommentModel>>($"blogposts/{request.Id}/footer-comments", Method.Get, request);
    }

    public MultiEntityResult<BlogPostInlineCommentModel> GetBlogPostInlineComments(GetBlogPostInlineCommentsRequest request)
    {
        return client.MakeRequest<MultiEntityResult<BlogPostInlineCommentModel>>($"blogposts/{request.Id}/inline-comments", Method.Get, request);
    }

    public MultiEntityResult<FooterCommentModel> GetFooterComments(GetFooterCommentsRequest request)
    {
        return client.MakeRequest<MultiEntityResult<FooterCommentModel>>("footer-comments", Method.Get, request);
    }

    public void CreateFooterComment(CreateFooterCommentRequest request)
    {
        client.MakeRequest<string>("footer-comments", Method.Post, request);
    }

    public FooterCommentWithViewLink GetFooterCommentById(GetFooterCommentByIdRequest request)
    {
        return client.MakeRequest<FooterCommentWithViewLink>($"footer-comments/{request.CommentId}", Method.Get, request);
    }

    public FooterCommentModel UpdateFooterComment(UpdateFooterCommentRequest request)
    {
        return client.MakeRequest<FooterCommentModel>($"footer-comments/{request.CommentId}", Method.Put, request);
    }

    public void DeleteFooterComment(DeleteFooterCommentRequest request)
    {
        client.MakeRequest<string>($"footer-comments/{request.CommentId}", Method.Delete, request);
    }

    public MultiEntityResult<ChildrenCommentModel> GetFooterCommentChildren(GetFooterCommentChildrenRequest request)
    {
        return client.MakeRequest<MultiEntityResult<ChildrenCommentModel>>($"footer-comments/{request.Id}/children", Method.Get, request);
    }

    public MultiEntityResult<InlineCommentModel> GetInlineComments(GetInlineCommentsRequest request)
    {
        return client.MakeRequest<MultiEntityResult<InlineCommentModel>>("inline-comments", Method.Get, request);
    }

    public InlineCommentModelWithLinks CreateInlineComment(CreateInlineCommentRequest request)
    {
        return client.MakeRequest<InlineCommentModelWithLinks>("inline-comments", Method.Post, request);
    }

    public InlineCommentModelWithLinks GetInlineCommentById(GetInlineCommentByIdRequest request)
    {
        return client.MakeRequest<InlineCommentModelWithLinks>($"inline-comments/{request.CommentId}", Method.Get, request);
    }

    public InlineCommentModelWithLinks UpdateInlineComment(UpdateInlineCommentRequest request)
    {
        return client.MakeRequest<InlineCommentModelWithLinks>($"inline-comments/{request.CommentId}", Method.Put, request);
    }

    public void DeleteInlineComment(DeleteInlineCommentRequest request)
    {
        client.MakeRequest<string>($"inline-comments/{request.CommentId}", Method.Delete, request);
    }

    public MultiEntityResult<InlineCommentChildrenModel> GetInlineCommentChildren(GetInlineCommentChildrenRequest request)
    {
        return client.MakeRequest<MultiEntityResult<InlineCommentChildrenModel>>($"inline-comments/{request.Id}/children", Method.Get, request);
    }
}
