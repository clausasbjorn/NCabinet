using System;

namespace NCabinet
{
    /// <summary>
    /// A wrapper used for storing objects in the cache in a uniform way.
    /// Provides additional information used for monitoring the cache.
    /// </summary>
    public class CacheItem
    {
        public object Value { get; set; }
        public string Key { get; set; }
        public string Namespace { get; set; }
        public string Method { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Loaded { get; set; }
    }
}