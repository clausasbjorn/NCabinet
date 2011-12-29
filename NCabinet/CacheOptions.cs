using System;

namespace NCabinet
{
    /// <summary>
    /// Options controlling the behaviour of cache manager objects.
    /// </summary>
    public class CacheOptions
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Expires { get; set; }
        public TimeSpan? KeepAlive { get; set; }
    }
}