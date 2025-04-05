using Confluence.ApiV2.ApiAreas.Models;
using Confluence.ApiV2.ApiAreas.Models.Ancestors;
using RestSharp;

namespace Confluence.ApiV2.ApiAreas;

public class AncestorsApi
{
    private readonly ConfluenceClient client;

    public AncestorsApi(ConfluenceClient client)
    {
        this.client = client;
    }

    public MultiEntityResult<AncestorsResponse> GetAncestorsOfWhiteboard(GetAncestorsOfWhiteboardRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<AncestorsResponse>>($"whiteboards/{request.Id}/ancestors", Method.Get, request);
        return res;
    }

    public MultiEntityResult<AncestorsResponse> GetAncestorsOfDatabase(GetAncestorsOfDatabaseRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<AncestorsResponse>>($"databases/{request.Id}/ancestors", Method.Get, request);
        return res;
    }

    public MultiEntityResult<AncestorsResponse> GetAncestorsOfSmartLink(GetAncestorsOfSmartLinkRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<AncestorsResponse>>($"embeds/{request.Id}/ancestors", Method.Get, request);
        return res;
    }

    public MultiEntityResult<AncestorsResponse> GetAncestorsOfFolder(GetAncestorsOfFolderRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<AncestorsResponse>>($"folders/{request.Id}/ancestors", Method.Get, request);
        return res;
    }

    public MultiEntityResult<AncestorsResponse> GetAncestorsOfPage(GetAncestorsOfPageRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<AncestorsResponse>>($"pages/{request.Id}/ancestors", Method.Get, request);
        return res;
    }
}
