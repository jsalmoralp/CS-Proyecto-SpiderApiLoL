using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class MatchEventDto
    {
        public string eventType;
        public string towerType;
        public int teamId;
        public string ascendedType;
        public int killerId;
        public string levelUpType;
        public string pointCaptured;
        public List<int> assistingParticipantIds;
        public string wardType;
        public string monsterType;
        public string type;
        public int skillSlot;
        public int victimId;
        public long timestamp;
        public int afterId;
        public string monsterSubRype;
        public string laneType;
        public int itemId;
        public int participantId;
        public string buildingType;
        public int creatorId;
        public MatchPositionDto position;
        public int beforeId;
    }
}
