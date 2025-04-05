using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Children;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas;

public class ChildrenApi
{
    private readonly ConfluenceClient client;

    public ChildrenApi(ConfluenceClient client)
    {
        this.client = client;
    }

    public MultiEntityResult<ChildrenResponse> GetDirectChildrenOfWhiteboard(GetDirectChildrenOfWhiteboardRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<ChildrenResponse>>($"whiteboards/{request.Id}/direct-children", Method.Get, request);
        return res;
    }

    public MultiEntityResult<ChildrenResponse> GetDirectChildrenOfDatabase(GetDirectChildrenOfDatabaseRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<ChildrenResponse>>($"databases/{request.Id}/direct-children", Method.Get, request);
        return res;
    }

    public MultiEntityResult<ChildrenResponse> GetDirectChildrenOfSmartLink(GetDirectChildrenOfSmartLinkRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<ChildrenResponse>>($"embeds/{request.Id}/direct-children", Method.Get, request);
        return res;
    }

    public MultiEntityResult<ChildrenResponse> GetDirectChildrenOfFolder(GetDirectChildrenOfFolderRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<ChildrenResponse>>($"folders/{request.Id}/direct-children", Method.Get, request);
        return res;
    }

    public MultiEntityResult<ChildPage> GetChildPages(GetChildPages request)
    {
        var res = client.MakeRequest<MultiEntityResult<ChildPage>>($"pages/{request.Id}/children", Method.Get, request);
        return res;
    }

    public MultiEntityResult<ChildCustomContent> GetChildCustomContent(GetChildCustomContentRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<ChildCustomContent>>($"custom-content/{request.Id}/children", Method.Get, request);
        return res;
    }

    public MultiEntityResult<ChildrenResponse> GetDirectChildrenOfPage(GetDirectChildrenOfPageRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<ChildrenResponse>>($"pages/{request.Id}/direct-children", Method.Get, request);
        return res;
    }
}
