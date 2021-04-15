using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DataAccess.Utilities.Helper
{
    public static class GetRequestHelper
    {

        public static string GetRequest(string urlLink)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString(urlLink);
            return downloadString;
        }
    }
}
