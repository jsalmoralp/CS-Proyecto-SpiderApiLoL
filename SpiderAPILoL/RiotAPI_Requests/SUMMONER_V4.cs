using Newtonsoft.Json;
using SpiderAPILoL.RiotAPI_Objects;
using System;
using System.Threading.Tasks;

namespace SpiderAPILoL.RiotAPI_Requests
{
    class SUMMONER_V4
    {
        private static string preURL = "/lol/summoner/v4/";

        // Get a summoner by account ID
        public static SummonerDto GetSummoner_Summoners_ByAccountId(string region, string encriptedAccountId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "summoners/by-account/" + encriptedAccountId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            SummonerDto requestObject = JsonConvert.DeserializeObject<SummonerDto>(t.Result);

            return requestObject;
        }

        // Get a summoner by summoner name
        public static SummonerDto GetSummoner_Summoners_BySummonerName(string region, string summonerName)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "summoners/by-name/" + summonerName + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            SummonerDto requestObject = JsonConvert.DeserializeObject<SummonerDto>(t.Result);

            return requestObject;
        }

        // Get a summoner by PUUID
        public static SummonerDto GetSummoner_Summoners_ByPUUID(string region, string encriptedPUUID)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "summoners/by-puuid/" + encriptedPUUID + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            SummonerDto requestObject = JsonConvert.DeserializeObject<SummonerDto>(t.Result);

            return requestObject;
        }

        // Get a summoner by summoner ID
        public static SummonerDto GetSummoner_Summoners_BySummonerId(string region, string encriptedSummonerId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "summoners/" + encriptedSummonerId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            SummonerDto requestObject = JsonConvert.DeserializeObject<SummonerDto>(t.Result);

            return requestObject;
        }
    }
}
