using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class MatchTimelineDto
    {
        public List<MatchFrameDto> frames;
        public long frameInterval;
    }
}
