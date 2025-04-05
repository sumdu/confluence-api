using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Labels;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas;

public class LabelsApi
{
    private readonly ConfluenceClient client;

    public LabelsApi(ConfluenceClient client)
    {
        this.client = client;
    }

    public MultiEntityResult<Label> GetLabelsForAttachment(GetLabelsForAttachmentRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<Label>>($"spaces/{request.Id}/content/labels", Method.Get, request);
        return res;
    }

    public MultiEntityResult<Label> GetLabelsForBlogPost(GetLabelsForBlogPostRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<Label>>($"blogposts/{request.Id}/labels", Method.Get, request);
        return res;
    }

    public MultiEntityResult<Label> GetLabelsForCustomContent(GetLabelsForCustomContentRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<Label>>($"custom-content/{request.Id}/labels", Method.Get, request);
        return res;
    }

    public MultiEntityResult<Label> GetLabels(GetLabelsRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<Label>>($"labels", Method.Get, request);
        return res;
    }

    public MultiEntityResult<Label> GetLabelsForPage(GetLabelsForPageRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<Label>>($"pages/{request.Id}/labels", Method.Get, request);
        return res;
    }

    public MultiEntityResult<Label> GetLabelsForSpace(GetLabelsForSpaceRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<Label>>($"spaces/{request.Id}/labels", Method.Get, request);
        return res;
    }

    public MultiEntityResult<Label> GetLabelsForSpaceContent(GetLabelsForSpaceContentRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<Label>>($"spaces/{request.Id}/content/labels", Method.Get, request);
        return res;
    }
}
