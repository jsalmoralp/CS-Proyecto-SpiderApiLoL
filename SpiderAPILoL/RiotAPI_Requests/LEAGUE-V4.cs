using Newtonsoft.Json;
using SpiderAPILoL.RiotAPI_Objects;
using System;
using System.Threading.Tasks;

namespace SpiderAPILoL.RiotAPI_Requests
{
    class LEAGUE_V4
    {
        private static string preURL = "/lol/league/v4/";
        /* Division can be:
         * -> I     -> III
         * -> II    -> IV
         * 
         * Tier can be:
         * -> DIAMOND       -> SILVER
         * -> PLATINUM      -> BRONZE
         * -> GOLD          -> IRON
         * 
         * Queue can be:
         * -> RANKED_SOLO_5x5
         * -> RANKED_FLEX_SR
         * -> RANKED_FLEX_TT
         */

        // Get the challenger league for given queue
        public static LeagueListDto GetLeague_ChallengerLeagues_ByQueue(string region, string queue)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "challengerleagues/by-queue/"+queue + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            LeagueListDto requestObject = JsonConvert.DeserializeObject<LeagueListDto>(t.Result);

            return requestObject;
        }

        // Get league entries in all queues for a given summoner ID
        public static LeagueEntryDto GetLeague_Entries_BySummoner(string region, string encriptedSummonerId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "entries/by-summoner/" + encriptedSummonerId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            LeagueEntryDto requestObject = JsonConvert.DeserializeObject<LeagueEntryDto>(t.Result);

            return requestObject;
        }

        // Get all the league entries
        public static LeagueEntryDto GetLeague_Entries_ByQueueByTierByDivision(string region, string queue, string tier, string division)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "entries/" + queue+"/"+tier+"/"+division + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            LeagueEntryDto requestObject = JsonConvert.DeserializeObject<LeagueEntryDto>(t.Result);

            return requestObject;
        }
        //// With page (its optional)
        public static LeagueEntryDto GetLeague_Entries_ByQueueByTierByDivision(string region, string queue, string tier, string division, int page)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "entries/" + queue + "/" + tier + "/" + division + "?page="+page+"&api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            LeagueEntryDto requestObject = JsonConvert.DeserializeObject<LeagueEntryDto>(t.Result);

            return requestObject;
        }

        // Get the grandmaster league of a specific queue
        public static LeagueListDto GetLeague_GrandMasterLeagues_ByQueue(string region, string queue)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "grandmasterleagues/by-queue/" + queue + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            LeagueListDto requestObject = JsonConvert.DeserializeObject<LeagueListDto>(t.Result);

            return requestObject;
        }

        // Get league with given ID, including inactive entries
        public static LeagueListDto GetLeague_Leagues_ByLeagueId(string region, string leagueId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "leagues/" + leagueId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            LeagueListDto requestObject = JsonConvert.DeserializeObject<LeagueListDto>(t.Result);

            return requestObject;
        }

        // Get the master league for given queue
        public static LeagueListDto GetLeague_MasterLeagues_ByQueue(string region, string queue)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "masterleagues/by-queue/" + queue + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            LeagueListDto requestObject = JsonConvert.DeserializeObject<LeagueListDto>(t.Result);

            return requestObject;
        }
    }
}
