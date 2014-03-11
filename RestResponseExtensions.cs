using RestSharp;

namespace AnotherJiraRestClient
{
    internal static class RestResponseExtensions
    {
        public static bool IsSuccessStatusCode(this IRestResponse response)
        {
            var statusCode = (int)response.StatusCode;
            return statusCode >= 200 && statusCode < 300;
        }
    }
}