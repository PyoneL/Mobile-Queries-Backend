using System.Net;

namespace DataAccess.Utilities.Helper
{
    public static class GetRequestHelper
    {
        public static string GetRequest(string urlLink)
        {
            var client = new WebClient();
            var downloadString = client.DownloadString(urlLink);
            return downloadString;
        }
    }
}