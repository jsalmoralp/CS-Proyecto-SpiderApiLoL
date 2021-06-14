using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class MatchlistDto
    {
        public List<MatchReferenceDto> matches;
        public int totalGames;
        public int startIndex;
        public int endIndex;
    }
}
