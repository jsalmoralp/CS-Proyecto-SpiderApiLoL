using Newtonsoft.Json;
using SpiderAPILoL.RiotAPI_Objects;
using System;
using System.Threading.Tasks;

namespace SpiderAPILoL.RiotAPI_Requests
{
    class LOL_STATUS_V3
    {
        private static string preURL = "/lol/status/v3/";

        // Get League of Legends status for the given shard
        public static ShardStatus GetStatus_ShardData(string region)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "shard-data"+ "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            ShardStatus requestObject = JsonConvert.DeserializeObject<ShardStatus>(t.Result);

            return requestObject;
        }
    }
}
