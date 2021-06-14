using System;
using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class MatchFrameDto
    {
        public long timestamp;
        public Dictionary<String, MatchParticipantFrameDto> participantFrames;
        public List<MatchEventDto> events;
    }
}
