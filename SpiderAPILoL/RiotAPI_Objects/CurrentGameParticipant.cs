using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class CurrentGameParticipant
    {
        public long profileIconId;
        public long championId;
        public string summonerName;
        public List<GameCustomizationObject> gameCustomizationObjects;
        public bool bot;
        public Perks perks;
        public long spell2Id;
        public long teamId;
        public long spell1Id;
        public string summonerId;
    }
}
