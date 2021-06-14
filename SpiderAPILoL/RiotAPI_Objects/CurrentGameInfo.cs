using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class CurrentGameInfo
    {
        public long gameId;
        public long gameStartTime;
        public string plataformId;
        public string gameMode;
        public long mapId;
        public string gameType;
        public List<BannedChampion> bannedChampions;
        public Observer observers;
        public List<CurrentGameParticipant> participants;
        public long gameLength;
        public long gameQueueConfigId;
    }
}
