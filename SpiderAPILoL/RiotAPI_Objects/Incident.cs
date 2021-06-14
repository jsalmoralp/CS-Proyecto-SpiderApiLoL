using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class Incident
    {
        public bool active;
        public string created_at;
        public long id;
        public List<Message> updates;
    }
}
