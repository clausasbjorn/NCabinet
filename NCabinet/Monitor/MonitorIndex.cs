using System;
using System.Collections.Generic;

namespace NCabinet.Monitor
{
    /// <summary>
    /// Keeps track of the current state of the cache, rather than the 
    /// actual cached values themselves. Used when monitoring is enabled.
    /// </summary>
    public class MonitorIndex
    {
        // Lock used for single access to index
        private readonly object _lock = new object();

        // Root element of the search index
        private MonitorIndexItem _root;

        // Key index for removing keys from search index
        private Dictionary<string, List<string>> _keyIndex;

        /// <summary>
        /// </summary>
        public MonitorIndex()
        {
            _root = new MonitorIndexItem();
            _keyIndex = new Dictionary<string, List<string>>();
        }

        /// <summary>
        /// Adds an 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        public void Add(string key, CacheItem item)
        {
            if (String.IsNullOrEmpty(key) || item == null)
                return;

            var keywords = item.Keywords;
            lock (_lock)
            {
                foreach (var keyword in keywords)
                    _root.Add(keyword, key);

                _keyIndex.Add(key, keywords);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            if (String.IsNullOrEmpty(key) || !_keyIndex.ContainsKey(key))
                return;

            var keywords = _keyIndex[key];
            lock (_lock)
            {
                foreach (var keyword in keywords)
                    _root.Remove(keyword, key);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<string> Search(string keyword)
        {
            return String.IsNullOrEmpty(keyword) ? new List<string>() : _root.Search(keyword);
        }

        public void Flush()
        {
            _root = new MonitorIndexItem();
            _keyIndex = new Dictionary<string, List<string>>();
        }
    }
}