using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class MatchDto
    {
        public int seasonId;
        public int queueId;
        public long gameId;
        public List<ParticipantIdentityDto> participantIdentities;
        public string gameVersion;
        public string plataformId;
        public string gameMode;
        public int mapId;
        public string gameType;
        public List<TeamStatsDto> teams;
        public List<ParticipantDto> participants;
        public long gameDuration;
        public long gameCreation;
    }
}
