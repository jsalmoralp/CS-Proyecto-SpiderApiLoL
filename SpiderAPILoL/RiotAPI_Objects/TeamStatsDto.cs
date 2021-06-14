using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class TeamStatsDto
    {
        public bool firstDragon;
        public bool firstInhibitor;
        public List<TeamBansDto> bans;
        public int baronKills;
        public bool firstRiftHerald;
        public bool firstBaron;
        public int riftHeraldKills;
        public bool firstBlood;
        public int teamId;
        public bool firstTower;
        public int vilemawKills;
        public int inhibitorKills;
        public int towerKills;
        public int dominionVictoryScore;
        public string win;
        public int dragonKills;
    }
}
