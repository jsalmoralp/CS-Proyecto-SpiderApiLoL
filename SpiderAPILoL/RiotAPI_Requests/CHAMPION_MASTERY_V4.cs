using Newtonsoft.Json;
using SpiderAPILoL.RiotAPI_Objects;
using System;
using System.Threading.Tasks;

namespace SpiderAPILoL.RiotAPI_Requests
{
    class CHAMPION_MASTERY_V4
    {
        private static string preURL = "/lol/champion-mastery/v4/";

        // Get all champion mastery entries sorted by number of champion points descending
        public static ChampionMasteryDto GetChampionMastery_Masteries_BySummonerId(string region, string encryptedSummonerId)
        {
            string url = "https://" + region + ".api.riotgames.com"+preURL+"champion-masteries/by-summoner/"+ encryptedSummonerId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            ChampionMasteryDto requestObject = JsonConvert.DeserializeObject<ChampionMasteryDto>(t.Result);

            return requestObject;
        }

        // Get a champion mastery by player ID and champion ID
        public static ChampionMasteryDto GetChampionMastery_Masteries_BySummonerIdByChampionId(string region, string encryptedSummonerId, long championId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "champion-masteries/by-summoner/" + encryptedSummonerId +"/by-champion/"+championId+ "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            ChampionMasteryDto requestObject = JsonConvert.DeserializeObject<ChampionMasteryDto>(t.Result);

            return requestObject;
        }

        // Get a player's total champion mastery score, which is the sum of individual champion mastery levels
        public static ChampionMasteryDto GetChampionMastery_Scores_BySummonerId(string region, string encryptedSummonerId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "scores/by-summoner/" + encryptedSummonerId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            ChampionMasteryDto requestObject = JsonConvert.DeserializeObject<ChampionMasteryDto>(t.Result);

            return requestObject;
        }
    }
}
