using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;

namespace NCabinet.HttpRuntimeCacheProvider
{
    public class HttpRuntimeCacheProvider : ICacheProvider
    {
        private object _lock = new object();
        private readonly Cache _cache;

        public HttpRuntimeCacheProvider()
        {
            _cache = HttpRuntime.Cache;
        }

        public object Get(string key)
        {
            return _cache.Get(key);
        }

        public void Put(string key, object value)
        {
            _cache.Add(key, value, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }

        public void Put(string key, object value, DateTime expires)
        {
            _cache.Add(key, value, null, expires, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }

        public void Put(string key, object value, TimeSpan keepAlive)
        {
            _cache.Add(key, value, null, Cache.NoAbsoluteExpiration, keepAlive, CacheItemPriority.Normal, null);
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public bool Exists(string key)
        {
            return _cache[key] != null;
        }

        public void Flush()
        {
            lock (_lock)
            {
                var keys = new List<string>();
                var elements = _cache.GetEnumerator();
                while (elements.MoveNext())
                    keys.Add(elements.Key.ToString());

                foreach (var key in keys)
                    _cache.Remove(key);
            }
        }
    }
}