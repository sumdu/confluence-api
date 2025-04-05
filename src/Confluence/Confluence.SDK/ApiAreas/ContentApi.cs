using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Content;
using RichkaSoft.Confluence.ApiV2.Exceptions;
using RestSharp;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas;

public class ContentApi
{
    private readonly ConfluenceClient client;

    public ContentApi(ConfluenceClient client)
    {
        this.client = client;
    }

    public ContentIdToContentTypeResponse ConvertContentIdsToContentTypes(ConvertContentIdsToContentTypesRequest request)
    {
        if (request.ContentIds.Any(item => !(item is string || item is long)))
        {
            throw new ConfluenceSdkException("ContentIds must be strings or longs");
        }

        var res = client.MakeRequest<ContentIdToContentTypeResponse>($"content/convert-ids-to-types", Method.Post, request);
        return res;
    }
}
