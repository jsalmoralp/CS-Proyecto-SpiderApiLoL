using SpiderAPILoL.RiotAPI_Objects;
using SpiderAPILoL.RiotAPI_Requests;
using System;

namespace SpiderAPILoL
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args!=null)
            {
                SummonerDto summoner1 = SUMMONER_V4.GetSummoner_Summoners_BySummonerName("euw1", "IiI%20raskan%20IiI");
                MatchlistDto summoner1matchlist = MATCH_V4.GetMatch_MatchLists_ByAccountId("euw1", summoner1.accountId);
                MatchDto summoner1match = MATCH_V4.GetMatch_Matches_ByMatchId("euw1", summoner1matchlist.matches[0].gameId);
                Console.WriteLine(summoner1match);
                Console.ReadKey();
            }
            
        }
    }
}
