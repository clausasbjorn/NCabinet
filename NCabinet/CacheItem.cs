using System;
using System.Collections.Generic;

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

        public List<string> Keywords
        {
            get
            {
                var keywords = new List<string>();
                if (!String.IsNullOrEmpty(Namespace))
                    keywords.Add(Namespace.ToLower());
                if (!String.IsNullOrEmpty(Method))
                    keywords.Add(Method.ToLower());
                if (!String.IsNullOrEmpty(Namespace) && !String.IsNullOrEmpty(Method))
                    keywords.Add(String.Format("{0}.{1}", Namespace.ToLower(), Method.ToLower()));
                if (!String.IsNullOrEmpty(Name))
                    keywords.Add(Name.ToLower());
                return keywords;
            }
        }

    }
}