using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class Message
    {
        public string severity;
        public string author;
        public string created_at;
        public List<Translation> translations;
        public string updated_at;
        public string content;
        public string id;

    }
}
