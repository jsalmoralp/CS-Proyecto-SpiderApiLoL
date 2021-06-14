using System.Collections.Generic;

namespace SpiderAPILoL.RiotAPI_Objects
{
    class ShardStatus
    {
        public string name;
        public string region_tag;
        public string hostname;
        public List<Service> services;
        public string slug;
        public List<string> locales;
    }
}
