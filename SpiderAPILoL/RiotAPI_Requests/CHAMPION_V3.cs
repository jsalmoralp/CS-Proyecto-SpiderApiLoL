using Newtonsoft.Json;
using SpiderAPILoL.RiotAPI_Objects;
using System;
using System.Threading.Tasks;

namespace SpiderAPILoL.RiotAPI_Requests
{
    class CHAMPION_V3
    {
        private static string preURL = "/lol/plataform/v3/";

        // Returns champion rotations, including free-to-play and low-level free-to-play rotations (REST)
        public static ChampionInfo GetChampionRotations(string region)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "champion-rotations" + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            ChampionInfo requestObject = JsonConvert.DeserializeObject<ChampionInfo>(t.Result);

            return requestObject;
        }
    }
}
