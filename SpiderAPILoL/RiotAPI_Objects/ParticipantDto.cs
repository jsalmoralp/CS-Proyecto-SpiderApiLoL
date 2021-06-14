using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class ParticipantDto
    {
        public ParticipantStatsDto stats;
        public int ParticipantId;
        public List<RuneDto> runes;
        public ParticipantTimelineDto timeline;
        public int teamId;
        public int spell2Id;
        public List<MasteryDto> masteries;
        public string highestAchievedSeasonTier;
        public int spell1Id;
        public int championId;
    }
}
