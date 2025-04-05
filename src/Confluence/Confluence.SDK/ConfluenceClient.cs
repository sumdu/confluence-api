using RichkaSoft.Confluence.ApiV2.ApiAreas;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models;
using RichkaSoft.Confluence.ApiV2.Exceptions;
using RichkaSoft.Confluence.ApiV2.Serializers;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace RichkaSoft.Confluence.ApiV2
{
    public sealed class ConfluenceClient
    {
        private RestClient Client { get; set; }

        private const string ApiServiceUri = "/wiki/api/v2/";

        public ConfluenceClient(String url, String username, String password)
        {
            var options = new RestClientOptions(url)
            {
                Authenticator = new HttpBasicAuthenticator(username, password)
            };
            Client = new RestClient(options);
        }

        public AttachmentsApi Attachments => new AttachmentsApi(this);
        public AncestorsApi Ancestors => new AncestorsApi(this);
        public BlogPostsApi BlogPosts => new BlogPostsApi(this);
        public ChildrenApi Children => new ChildrenApi(this);
        public ContentApi Content => new ContentApi(this);
        public ContentPropertiesApi ContentProperties => new ContentPropertiesApi(this);
        public DataPoliciesApi DataPolicies => new DataPoliciesApi(this);
        public DescendantsApi Descendants => new DescendantsApi(this);
        public FoldersApi Folders => new FoldersApi(this);
        public LabelsApi Labels => new LabelsApi(this);
        public LikesApi Likes => new LikesApi(this);
        public OperationsApi Operations => new OperationsApi(this);
        public PageApi Pages => new PageApi(this);
        public SmartLinksApi SmartLinks => new SmartLinksApi(this);
        public SpaceApi Spaces => new SpaceApi(this);
        public VersionsApi Versions => new VersionsApi(this);

        public string GetApiServiceUri()
        {
            return ApiServiceUri;
        }

        internal T MakeRequest<T>(string path, Method method, object request)
        {
            var queryString = new QueryParamsSerializer().Serialize(request);
            var requestBody = new BodyParamsSerializer().Serialize(request);

            var json = MakeRequest(path, method, queryString, requestBody);

            if (String.IsNullOrEmpty(json))
                return default(T);

            // if we want to return result as a string (without deserializing it)
            if (typeof(T) == typeof(string))
                return (T)(object)json;

            return JsonConvert.DeserializeObject<T>(json);
        }

        public MultiEntityResult<T> FetchAllPages<T>(MultiEntityResult<T> firstPage)
        {
            var nextLink = firstPage.Links.Next;

            while (nextLink != null)
            {
                var nextJson = this.MakeRequest(nextLink, Method.Get, null, null);
                var nextRes = new CustomJsonSerializer().Deserialize<MultiEntityResult<T>>(nextJson);

                firstPage.Results = firstPage.Results.Concat(nextRes.Results).ToArray();

                nextLink = nextRes.Links.Next;
            }

            firstPage.Links.Next = null; // do not return the next link to the next page if all pages are fetched

            return firstPage;
        }

        private string MakeRequest(string path, Method method, string? queryString, string? requstBody)
        {
            // Fix for cursor requests
            // Next link contains ApiServiceUri = "/wiki/api/v2/" at the beginning
            if (path.StartsWith(ApiServiceUri))
            {
                path = path.Substring(ApiServiceUri.Length);
            }

            var request = new RestRequest(String.Format("{0}{1}{2}", ApiServiceUri, path, queryString), method);
            request.RequestFormat = DataFormat.Json;

            if (requstBody != null && (method == Method.Put || method == Method.Post || method == Method.Delete))
            {
                request.AddJsonBody(requstBody);
            }

            RestResponse response;
            switch (method)
            {
                case Method.Get:
                    response = Client.Get(request);
                    break;
                case Method.Post:
                    response = Client.Post(request);
                    break;
                case Method.Put:
                    response = Client.Put(request);
                    break;
                case Method.Delete:
                    response = Client.Delete(request);
                    break;
                default:
                    response = null;
                    break;
            }

            CheckResponse(response);

            var json = response?.Content;

            return json;
        }

        private static System.Net.HttpStatusCode[] SuccessfulStatusCodes = { 
            System.Net.HttpStatusCode.OK, 
            System.Net.HttpStatusCode.Created, 
            System.Net.HttpStatusCode.NoContent 
        };

        private void CheckResponse(RestResponse response)
        {
            if (response == null)
            {
                throw new ConfluenceSdkException("Response is null");
            }

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new ConfluenceSdkException(response.ErrorMessage ?? "Unknown Error");
            }

            if (!SuccessfulStatusCodes.Contains(response.StatusCode))
            {
                var errMsg = "Something went wrong...";

                if (!string.IsNullOrEmpty(response.Content))
                    errMsg += $"\r\n{response.Content}";

                throw new ConfluenceSdkException(errMsg);
            }
        }
    }
}
