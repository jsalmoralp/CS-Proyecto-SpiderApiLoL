using System;
using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class ParticipantTimelineDto
    {
        public string lane;
        public int participantId;
        public Dictionary<string, double> csDiffPerMinDeltas;
        public Dictionary<string, double> goldPerMinDeltas;
        public Dictionary<string, double> xpDiffPerMinDeltas;
        public Dictionary<string, double> creepsPerMinDeltas;
        public Dictionary<string, double> xpPerMinDeltas;
        public string role;
        public Dictionary<string, double> damageTakenDiffPerMinDeltas;
        public Dictionary<string, double> damageTakenPerMinDeltas;
    }
}
