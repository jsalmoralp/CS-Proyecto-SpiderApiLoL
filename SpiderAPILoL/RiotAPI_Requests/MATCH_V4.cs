using Newtonsoft.Json;
using SpiderAPILoL.RiotAPI_Objects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpiderAPILoL.RiotAPI_Requests
{
    class MATCH_V4
    {
        private static string preURL = "/lol/match/v4/";

        // Get match by match ID
        public static MatchDto GetMatch_Matches_ByMatchId(string region, long matchId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "matches/"+matchId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            MatchDto requestObject = JsonConvert.DeserializeObject<MatchDto>(t.Result);

            return requestObject;
        }

        // Get matchlist for games played on given account ID and platform ID and filtered using given filter parameters, if any
        public static MatchlistDto GetMatch_MatchLists_ByAccountId(string region, string encriptedAccountId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "matchlists/by-account/" + encriptedAccountId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            MatchlistDto requestObject = JsonConvert.DeserializeObject<MatchlistDto>(t.Result);

            return requestObject;
        }
        /* Falta pasar posibles parametros: 
         * https://euw1.api.riotgames.com/lol/match/v4/matchlists/by-account/11111?champion=1&queue=1&season=1&endTime=11&beginTime=11&endIndex=11&beginIndex=1&api_key=RGA
         * int champion
         * int queue
         * int season
         * long endTime
         * long beginTime
         * int endIndex
         * int beginIndex
         */

        // Get match timeline by match ID
        public static MatchTimelineDto GetMatch_Timelines_ByMatchId(string region, long matchId)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "timelines/by-match/" + matchId + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            MatchTimelineDto requestObject = JsonConvert.DeserializeObject<MatchTimelineDto>(t.Result);

            return requestObject;
        }

        // Get match IDs by tournament code
        public static List<long> GetMatch_Matches_ByTournamentCode(string region, string tournamentCode)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "matches/by-tournament-code/" + tournamentCode + "/ids?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            List<long> requestObject = JsonConvert.DeserializeObject<List<long>>(t.Result);

            return requestObject;
        }

        // Get match by match ID and tournament code
        public static MatchDto GetMatch_Matches_ByMatchIdByTournamentCode(string region, long matchId, string tournamentCode)
        {
            string url = "https://" + region + ".api.riotgames.com" + preURL + "matches/"+matchId+"/by-tournament-code/" + tournamentCode + "?api_key=" + Config.keyAPI;
            var t = Task.Run(() => HTTPClient.GetInfoOfApi(new Uri(url)));
            t.Wait();
            MatchDto requestObject = JsonConvert.DeserializeObject<MatchDto>(t.Result);

            return requestObject;
        }
    }
}
