using Confluence.ApiV2.ApiAreas.Models;
using Confluence.ApiV2.ApiAreas.Models.Children;
using Confluence.ApiV2.ApiAreas.Models.DataPolicies;
using RestSharp;

namespace Confluence.ApiV2.ApiAreas;

public class DataPoliciesApi
{
    private readonly ConfluenceClient client;

    public DataPoliciesApi(ConfluenceClient client)
    {
        this.client = client;
    }

    public DataPolicyMetadata GetDataPolicyMetadataForWorkspace(GetDataPolicyMetadataForWorkspaceRequest request)
    {
        var res = client.MakeRequest<DataPolicyMetadata>($"data-policies/metadata", Method.Get, request);
        return res;
    }

    public MultiEntityResult<DataPolicySpace> GetSpacesWithDataPolicies(GetSpacesWithDataPoliciesRequest request)
    {
        var res = client.MakeRequest<MultiEntityResult<DataPolicySpace>>($"data-policies/spaces", Method.Get, request);
        return res;
    }
}
