using System;
using System.Collections.Generic;
using System.Reflection;
using NCabinet.Exceptions;
using NCabinet.Inspection;
using NCabinet.Settings;
using NCabinet.Tools;

namespace NCabinet
{
    /// <summary>
    /// The core cache manager
    /// </summary>
    public partial class CacheManager : ICacheManager
    {
        // Private members
        private static readonly object _groupLock = new object();
        private static ICacheProvider _cache;

        private string Name { get; set; }
        private string Description { get; set; }
        private string Group { get; set;  }
        private DateTime? Expiration { get; set; }
        private TimeSpan? SlidingExpiration { get; set; }
        
        // Constructors
        public CacheManager() { }
        public CacheManager(CacheOptions options)
        {
            if (options == null)
                return;

            Name = options.Name;
            Description = options.Description;
            Expiration = options.Expires;
            SlidingExpiration = options.KeepAlive;
        }

        /// <summary>
        /// Sets the cache provider for all cache manager instances
        /// </summary>
        /// <param name="provider">The cache provider to use</param>
        internal static void SetProvider(ICacheProvider provider)
        {
            if (_cache != null)
                throw new ExistingProviderException();

            _cache = provider;
        }

        /// <summary>
        /// Apply settings for all cache manager objects
        /// </summary>
        /// <param name="action">An action containing the desired setup expressions</param>
        public static void Initialize(Action<IInitializationExpression> action)
        {
            lock (typeof(CacheManager))
            {
                var expression = new InitializationExpression();
                action(expression);
            }
        }

        /// <summary>
        /// Returns true if a valid cache provider has been set
        /// </summary>
        public static bool IsReady
        {
            get { return _cache != null; }
        }

        /// <summary>
        /// Shorthand for creating a new cache manager object
        /// </summary>
        /// <param name="options">Cache settings</param>
        /// <returns>A new cache manager object</returns>
        public static CacheManager Create(CacheOptions options = null)
        {
            return new CacheManager(options);
        }

        /// <summary>
        /// Sets optional information that will be stored alongside any values returned
        /// by the cache manager. This can be used for monitoring.
        /// </summary>
        /// <param name="name">An optional name of the cache call</param>
        /// <param name="description">An optional description of the cache call</param>
        /// <returns>A new cache manager with the desired information appended</returns>
        public CacheManager Info(string name = null, string description = null)
        {
            var clone = Clone();
            clone.Name = name;
            clone.Description = description;
            return clone;
        }

        /// <summary>
        /// Tells the cache manager to group any objects that are returned within a
        /// named group. This can be used for removing multiple elements in one operation.
        /// </summary>
        /// <param name="keys">The group identifier</param>
        /// <returns>A new cache manager object that will group returned objects</returns>
        public CacheManager GroupBy(params string[] keys)
        {
            var clone = Clone();
            clone.Group = KeyBuilder.Build(keys);
            return clone;
        }

        /// <summary>
        /// Sets a finite expiration time for the objects returned by the cache manager.
        /// </summary>
        /// <param name="expiration">The time returned objects will expire</param>
        /// <returns>A new cache manager holding the expiration settings</returns>
        public CacheManager Expires(DateTime expiration)
        {
            var clone = Clone();
            clone.Expiration = expiration;
            return clone;
        }

        /// <summary>
        /// Sets a finite expiration time for the objects returned by the cache manager.
        /// </summary>
        /// <param name="count">The number of time elements until the object expires</param>
        /// <param name="interval">The type of time element used</param>
        /// <returns>A new cache manager holding the expiration settings</returns>
        public CacheManager Expires(int count, ExpirationInterval interval)
        {
            DateTime expiration;
            switch (interval)
            {
                case ExpirationInterval.Milliseconds: expiration = DateTime.Now.AddMilliseconds(count); break;
                case ExpirationInterval.Seconds: expiration = DateTime.Now.AddSeconds(count); break;
                case ExpirationInterval.Minutes: expiration = DateTime.Now.AddMinutes(count); break;
                case ExpirationInterval.Hours: expiration = DateTime.Now.AddHours(count); break;
                case ExpirationInterval.Days: expiration = DateTime.Now.AddDays(count); break;
                default: throw new InvalidExpirationIntervalException();
            }

            var clone = Clone();
            clone.Expiration = expiration;
            return clone;
        }

        /// <summary>
        /// Sets a sliding window expiration period. The object will be kept in the cache
        /// for as long as it is retrieved again within the timespan provided.
        /// </summary>
        /// <param name="sliding">The timespan to keep the cached object alive for</param>
        /// <returns>A new cache manager holding the keep alive settings</returns>
        public CacheManager KeepAlive(TimeSpan sliding)
        {
            var clone = Clone();
            clone.SlidingExpiration = sliding;
            return clone;
        }

        /// <summary>
        /// Sets a sliding window expiration period. The object will be kept in the cache
        /// for as long as it is retrieved again within the timespan provided.
        /// </summary>
        /// <param name="count">The number of time elements the object will be kept in cache for</param>
        /// <param name="interval">The type of time element used</param>
        /// <returns>A new cache manager holding the keep alive settings</returns>
        public CacheManager KeepAlive(int count, ExpirationInterval interval)
        {
            TimeSpan sliding;
            switch (interval)
            {
                case ExpirationInterval.Milliseconds: sliding = new TimeSpan(0, 0, 0, 0, count); break;
                case ExpirationInterval.Seconds: sliding = new TimeSpan(0, 0, 0, count, 0); break;
                case ExpirationInterval.Minutes: sliding = new TimeSpan(0, 0, count, 0, 0); break;
                case ExpirationInterval.Hours: sliding = new TimeSpan(0, count, 0, 0, 0); break;
                case ExpirationInterval.Days: sliding = new TimeSpan(count, 0, 0, 0, 0); break;
                default: throw new InvalidExpirationIntervalException();
            }

            var clone = Clone();
            clone.SlidingExpiration = sliding;
            return clone;
        }

        /// <summary>
        /// Creates a new cache manager object with exactly the same 
        /// properties as the current one.
        /// </summary>
        /// <returns></returns>
        public CacheManager Clone()
        {
            return new CacheManager() { Name = Name, Description = Description, Group = Group, Expiration = Expiration, SlidingExpiration = SlidingExpiration };
        }
        
        // Wrappers for this with 1-15 arguments are located in the CacheManagerExtensions.cs file
        /// <summary>
        /// Returns a value from the cache based on the provided arguments and information about the calling method.
        /// If the item is not found in the cache it is loaded from the callback provided and added to the cache before
        /// being returned to the caller.
        /// </summary>
        private TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15, TIn16 i16, MethodInfo callerInfo)
        {
            var n = typeof (NoKey);
            var keys = new List<object>();
            if (typeof(TIn1) != n) keys.Add(i1);
            if (typeof(TIn2) != n) keys.Add(i2);
            if (typeof(TIn3) != n) keys.Add(i3);
            if (typeof(TIn4) != n) keys.Add(i4);
            if (typeof(TIn5) != n) keys.Add(i5);
            if (typeof(TIn6) != n) keys.Add(i6);
            if (typeof(TIn7) != n) keys.Add(i7);
            if (typeof(TIn8) != n) keys.Add(i8);
            if (typeof(TIn9) != n) keys.Add(i9);
            if (typeof(TIn10) != n) keys.Add(i10);
            if (typeof(TIn11) != n) keys.Add(i11);
            if (typeof(TIn12) != n) keys.Add(i12);
            if (typeof(TIn13) != n) keys.Add(i13);
            if (typeof(TIn14) != n) keys.Add(i14);
            if (typeof(TIn15) != n) keys.Add(i15);
            if (typeof(TIn16) != n) keys.Add(i16);

            var type = typeof(TOut);
            var caller = CallAnalyzer.GetCallbackInfo(callerInfo);
            var key = KeyBuilder.Build(type, caller, keys.ToArray());

            var value = _cache.Get(key);
            if (value == null)
            {
                value = callback(i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16);
                if (value == null)
                    return default(TOut);

                var cacheItem = new CacheItem();
                cacheItem.Value = value;
                cacheItem.Key = key;
                cacheItem.Namespace = caller.Namespace;
                cacheItem.Method = cacheItem.Method;
                cacheItem.Name = Name;
                cacheItem.Description = Description;
                cacheItem.Loaded = DateTime.Now;

                _cache.Put(key, cacheItem);
                AddToGroup(key);

                return (TOut)value;
            }

            var output = value as CacheItem;
            if (output == null)
                throw new IllegalCacheItemException();

            return output.Value is TOut ? (TOut)output.Value : default(TOut);
        }

        /// <summary>
        /// Returns a value from the cache based on the provided arguments and information about the calling method.
        /// If the item is not found in the cache it is loaded from the callback provided and added to the cache before
        /// being returned to the caller.
        /// </summary>
        public T Get<T>(Callback<T> callback, params object[] parameters)
        {
            var type = typeof(T);
            var caller = CallAnalyzer.GetCallerInfo();
            var key = KeyBuilder.Build(type, caller, parameters);

            var value = _cache.Get(key);
            if (value == null)
            {
                value = callback(parameters);
                if (value == null)
                    return default(T);
                
                var cacheItem = new CacheItem();
                cacheItem.Value = value;
                cacheItem.Key = key;
                cacheItem.Namespace = caller.Namespace;
                cacheItem.Method = cacheItem.Method;
                cacheItem.Name = Name;
                cacheItem.Description = Description;
                cacheItem.Loaded = DateTime.Now;

                _cache.Put(key, cacheItem);
                AddToGroup(key);

                return (T)value;
            }

            var output = value as CacheItem;
            if (output == null)
                throw new IllegalCacheItemException();

            return output.Value is T ? (T)output.Value : default(T);
        }

        /// <summary>
        /// Loads an element from the cache based on the provided arguments
        /// </summary>
        public T Get<T>(params object[] parameters)
        {
            var type = typeof(T);
            var key = KeyBuilder.Build(type, null, parameters);

            var value = _cache.Get(key);
            if (value == null)
                return default(T);

            var output = value as CacheItem;
            if (output == null)
                throw new IllegalCacheItemException();

            return output.Value is T ? (T)output.Value : default(T);
        }

        /// <summary>
        /// Adds an object to the cache. The cache key is generated from the 
        /// provided key paremeters.
        /// </summary>
        /// <param name="value">The object to add to cache</param>
        /// <param name="parameters">Elements for building the cache key</param>
        public void Put(object value, params object[] parameters)
        {
            if (value == null)
                return;
            
            var type = value.GetType();
            var caller = CallAnalyzer.GetCallerInfo();
            var key = KeyBuilder.Build(type, null, parameters);

            var cacheItem = new CacheItem();
            cacheItem.Value = value;
            cacheItem.Key = key;
            cacheItem.Namespace = caller.Namespace;
            cacheItem.Method = cacheItem.Method;
            cacheItem.Name = Name;
            cacheItem.Description = Description;
            cacheItem.Loaded = DateTime.Now;
            _cache.Put(key, cacheItem);

            AddToGroup(key);
        }

        /// <summary>
        /// Adds a cache key to the cache managers group.
        /// </summary>
        /// <param name="key">The key to group</param>
        private void AddToGroup(string key)
        {
            if (String.IsNullOrEmpty(Group))
                return;

            lock (_groupLock)
            {
                var keys = _cache.Get(Group) as List<string> ?? new List<string>();
                if (!keys.Contains(key))
                    keys.Add(key);

                _cache.Put(Group, keys);
            }
        }

        /// <summary>
        /// Removes an element from the cache based on the provided key elements.
        /// </summary>
        /// <param name="parameters">The elements used to build the key.</param>
        public void Remove<T>(params object[] parameters)
        {
            var type = typeof(T);
            var key = KeyBuilder.Build(type, null, parameters);

            _cache.Remove(key);
        }

        public void Remove<T>(Callback<T> callback, params object[] parameters)
        {
            var type = typeof(T);
            var caller = CallAnalyzer.GetCallerInfo();
            var key = KeyBuilder.Build(type, caller, parameters);

            _cache.Remove(key);
        }

        // Wrappers for this with 1-15 arguments are located in the CacheManagerExtensions.cs file
        /// <summary>
        /// 
        /// </summary>
        private void Remove<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15, TIn16 i16, MethodInfo callerInfo)
        {
            var n = typeof(NoKey);
            var keys = new List<object>();
            if (typeof(TIn1) != n) keys.Add(i1);
            if (typeof(TIn2) != n) keys.Add(i2);
            if (typeof(TIn3) != n) keys.Add(i3);
            if (typeof(TIn4) != n) keys.Add(i4);
            if (typeof(TIn5) != n) keys.Add(i5);
            if (typeof(TIn6) != n) keys.Add(i6);
            if (typeof(TIn7) != n) keys.Add(i7);
            if (typeof(TIn8) != n) keys.Add(i8);
            if (typeof(TIn9) != n) keys.Add(i9);
            if (typeof(TIn10) != n) keys.Add(i10);
            if (typeof(TIn11) != n) keys.Add(i11);
            if (typeof(TIn12) != n) keys.Add(i12);
            if (typeof(TIn13) != n) keys.Add(i13);
            if (typeof(TIn14) != n) keys.Add(i14);
            if (typeof(TIn15) != n) keys.Add(i15);
            if (typeof(TIn16) != n) keys.Add(i16);

            var type = typeof (TOut);
            var caller = CallAnalyzer.GetCallbackInfo(callerInfo);
            var key = KeyBuilder.Build(type, caller, keys.ToArray());

            _cache.Remove(key);
        }

        public void RemoveGroup(params string[] keys)
        {
            var key = KeyBuilder.Build(keys);
            lock (_groupLock)
            {
                var removable = _cache.Get(key) as List<string>;
                if (removable == null)
                    return;

                foreach (var remove in removable)
                    _cache.Remove(remove);
            }
        }

        public bool Exists<T>(params object[] parameters)
        {
            var type = typeof(T);
            var key = KeyBuilder.Build(type, null, parameters);

            return _cache.Exists(key);
        }

        public bool Exists<T>(Callback<T> callback, params object[] parameters)
        {
            var type = typeof(T);
            var caller = CallAnalyzer.GetCallerInfo();
            var key = KeyBuilder.Build(type, caller, parameters);

            return _cache.Exists(key);
        }

        private bool Exists<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15, TIn16 i16, MethodInfo callerInfo)
        {
            var n = typeof(NoKey);
            var keys = new List<object>();
            if (typeof(TIn1) != n) keys.Add(i1);
            if (typeof(TIn2) != n) keys.Add(i2);
            if (typeof(TIn3) != n) keys.Add(i3);
            if (typeof(TIn4) != n) keys.Add(i4);
            if (typeof(TIn5) != n) keys.Add(i5);
            if (typeof(TIn6) != n) keys.Add(i6);
            if (typeof(TIn7) != n) keys.Add(i7);
            if (typeof(TIn8) != n) keys.Add(i8);
            if (typeof(TIn9) != n) keys.Add(i9);
            if (typeof(TIn10) != n) keys.Add(i10);
            if (typeof(TIn11) != n) keys.Add(i11);
            if (typeof(TIn12) != n) keys.Add(i12);
            if (typeof(TIn13) != n) keys.Add(i13);
            if (typeof(TIn14) != n) keys.Add(i14);
            if (typeof(TIn15) != n) keys.Add(i15);
            if (typeof(TIn16) != n) keys.Add(i16);

            var type = typeof(TOut);
            var caller = CallAnalyzer.GetCallbackInfo(callerInfo);
            var key = KeyBuilder.Build(type, caller, keys.ToArray());

            return _cache.Exists(key);
        }

        public void Flush()
        {
            _cache.Flush();
        }
    }
}