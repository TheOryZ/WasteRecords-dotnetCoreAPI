using RestSharp;
using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.RestAccess.Interfaces;
using System.Net;
using Newtonsoft.Json;

namespace WasteRecords.WebUI.RestAccess.Services
{
    public class GenericRestAccess : IAccessRest
    {
        //Sample Uri : var uri = string.Format("http://{0}/{1}?Id={2}&PersonalId={3}", "localhost:5000/api", "v1/GetMethodRouteName", request.Id, request.PersonalId);
        public ResponseState<T> GetMethod<T>(string uri, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };
            var result = GetResult<T>(client, request, null, headers);

            return result;
        }
        //Sample Uri : var uri = string.Format("{0}/{1}", "localhost:5000/api", "v1/PostMethodRouteName"); 
        public ResponseState<T> PostMethod<T>(object obj, string uri, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
            var result = GetResult<T>(client, request, obj, headers);

            return result;
        }
        //Sample Uri : var uri = string.Format("http://{0}/{1}", "localhost:5000/api", "v1/PutMethodRouteName");
        public ResponseState<T> PutMethod<T>(object obj, string uri, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.PUT) { RequestFormat = DataFormat.Json };
            var result = GetResult<T>(client, request, obj, headers);

            return result;
        }
        public ResponseState<T> PutMethod<T>(string uri, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.PUT) { RequestFormat = DataFormat.Json };
            var result = GetResult<T>(client, request, headers);

            return result;
        }
        //Sample Uri :  var uri= string.Format("{0}/{1}?id={2}", "localhost:5000/api", "DeleteMethodRouteName", 3);
        public ResponseState<T> DeleteMethod<T>(string uri, Dictionary<string, string> headers = null)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.DELETE) { RequestFormat = DataFormat.Json };
            var result = GetResult<T>(client, request, null, headers);

            return result;
        }
        private ResponseState<T> GetResult<T>(RestClient client, RestRequest request, object obj = null, Dictionary<string, string> headers = null)
        {
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }
            if (obj != null)
            {
                request.AddJsonBody(obj);
            }
            IRestResponse response = client.Execute(request);
            ResponseState<T> responseState = JsonConvert.DeserializeObject<ResponseState<T>>(response.Content, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore });
            return responseState;
        }
    }
}
