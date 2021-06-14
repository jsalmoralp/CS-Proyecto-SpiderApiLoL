using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SpiderAPILoL.RiotAPI_Requests
{
    class HTTPClient
    {
        public static async Task<string> GetInfoOfApi(Uri u)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }
    }
}
