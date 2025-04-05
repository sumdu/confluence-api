using Confluence.ApiV2.ApiAreas.Models;
using Confluence.ApiV2.ApiAreas.Models.Descendants;
using RestSharp;

namespace Confluence.ApiV2.ApiAreas;

public class DescendantsApi
{
    private readonly ConfluenceClient client;

    public DescendantsApi(ConfluenceClient client)
    {
        this.client = client;
    }

    public MultiEntityResult<DescendantsResponse> GetDescendandsOfWhiteboard(GetDescendandsOfWhiteboardRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<DescendantsResponse>>($"whiteboards/{request.Id}/descendants", Method.Get, request);
        return res;
    }

    public MultiEntityResult<DescendantsResponse> GetDescendandsOfDatabase(GetDescendandsOfDatabaseRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<DescendantsResponse>>($"databases/{request.Id}/descendants", Method.Get, request);
        return res;
    }

    public MultiEntityResult<DescendantsResponse> GetDescendandsOfSmartLink(GetDescendandsOfSmartLinkRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<DescendantsResponse>>($"embeds/{request.Id}/descendants", Method.Get, request);
        return res;
    }

    public MultiEntityResult<DescendantsResponse> GetDescendandsOfFolder(GetDescendandsOfFolderRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<DescendantsResponse>>($"folders/{request.Id}/descendants", Method.Get, request);
        return res;
    }

    public MultiEntityResult<DescendantsResponse> GetDescendandsOfPage(GetDescendandsOfPageRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<DescendantsResponse>>($"pages/{request.Id}/descendants", Method.Get, request);
        return res;
    }
}
