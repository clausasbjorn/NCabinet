using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;

namespace NCabinet.HttpRuntimeCacheProvider
{
    /// <summary>
    /// A provider based on the HttpRuntimeCache that can be consumed by NCabinet.
    /// </summary>
    public class HttpRuntimeCacheProvider : ICacheProvider
    {
        // Private members
        private static readonly object _lock = new object();
        private readonly Cache _cache;

        // Constructor
        public HttpRuntimeCacheProvider()
        {
            _cache = HttpRuntime.Cache;
        }

        /// <summary>
        /// Get an object from cache.
        /// </summary>
        /// <param name="key">The key identifying the object</param>
        /// <returns>Requested cached object</returns>
        public object Get(string key)
        {
            return _cache.Get(key);
        }

        /// <summary>
        /// Add an item to the cache.
        /// </summary>
        /// <param name="key">The key identifying the object</param>
        /// <param name="value">The object to add to cache</param>
        public void Put(string key, object value)
        {
            _cache.Add(key, value, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }

        /// <summary>
        /// Add an item to the cache.
        /// </summary>
        /// <param name="key">The key identifying the object</param>
        /// <param name="value">The object to add to cache</param>
        /// <param name="expires">The finite expiration time for the cached object</param>
        public void Put(string key, object value, DateTime expires)
        {
            _cache.Add(key, value, null, expires, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }

        /// <summary>
        /// Add an item to the cache.
        /// </summary>
        /// <param name="key">The key identifying the object</param>
        /// <param name="value">The object to add to cache</param>
        /// <param name="keepAlive">The sliding window expiration time for the cached object</param>
        public void Put(string key, object value, TimeSpan keepAlive)
        {
            _cache.Add(key, value, null, Cache.NoAbsoluteExpiration, keepAlive, CacheItemPriority.Normal, null);
        }

        /// <summary>
        /// Remove an item from the cache.
        /// </summary>
        /// <param name="key">The key identifying the object to remove</param>
        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        /// <summary>
        /// Check whether an item exists in cache.
        /// </summary>
        /// <param name="key">The key identifying the object</param>
        /// <returns>True if the item exists</returns>
        public bool Exists(string key)
        {
            return _cache[key] != null;
        }

        /// <summary>
        /// Removes everything from the cache.
        /// </summary>
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