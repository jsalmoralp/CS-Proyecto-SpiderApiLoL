using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class LeagueListDto
    {
        public string leagueId;
        public string tier;
        public List<LeagueItemDto> entries;
        public string queue;
        public string name;

    }
}
