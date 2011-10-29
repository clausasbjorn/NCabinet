using System;

namespace NCabinet
{
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