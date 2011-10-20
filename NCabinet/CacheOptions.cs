using System;

namespace NCabinet
{
    public class CacheOptions
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Expires { get; set; }
        public TimeSpan? KeepAlive { get; set; }
    }
}