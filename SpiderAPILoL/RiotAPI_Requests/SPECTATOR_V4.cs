using Newtonsoft.Json;
using SpiderAPILoL.RiotAPI_Objects;
using System;
using System.Threading.Tasks;

namespace SpiderAPILoL.RiotAPI_Requests
{
    class SPECTATOR_V4
    {
        private static string preURL = "/lol/spectator/v4/";

        // Get match by match ID
        public static CurrentGameInfo GetSpectator_ActiveGames_BySumonnerId(string region, long encriptedSummonerId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "active-games/by-summoner/" + encriptedSummonerId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            CurrentGameInfo requestObject = JsonConvert.DeserializeObject<CurrentGameInfo>(t.Result);

            return requestObject;
        }

        // Get list of featured games
        public static FeaturedGames GetSpectator_FeaturedGames(string region)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "featured-games?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            FeaturedGames requestObject = JsonConvert.DeserializeObject<FeaturedGames>(t.Result);

            return requestObject;
        }
    }
}
