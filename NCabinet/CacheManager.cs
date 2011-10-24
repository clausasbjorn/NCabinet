using System;
using System.Collections.Generic;
using NCabinet.Exceptions;
using NCabinet.Inspection;
using NCabinet.Settings;
using NCabinet.Tools;

namespace NCabinet
{
    public partial class CacheManager : ICacheManager
    {
        private static ICacheProvider _cache;

        private string Name { get; set; }
        private string Description { get; set; }
        private DateTime? Expiration { get; set; }
        private TimeSpan? SlidingExpiration { get; set; }
        
        public CacheManager()
        {
        }

        public CacheManager(CacheOptions options)
        {
            if (options == null)
                return;

            Name = options.Name;
            Description = options.Description;
            Expiration = options.Expires;
            SlidingExpiration = options.KeepAlive;
        }

        internal static void SetProvider(ICacheProvider provider)
        {
            if (_cache != null)
                throw new ExistingProviderException();

            _cache = provider;
        }

        public static void Initialize(Action<IInitializationExpression> action)
        {
            lock (typeof(CacheManager))
            {
                var expression = new InitializationExpression();
                action(expression);
            }
        }

        public static CacheManager Create(CacheOptions options = null)
        {
            return new CacheManager(options);
        }

        public CacheManager Info(string name = null, string description = null)
        {
            var clone = Clone();
            clone.Name = name;
            clone.Description = description;
            return clone;
        }

        public CacheManager Expires(DateTime expiration)
        {
            var clone = Clone();
            clone.Expiration = expiration;
            return clone;
        }

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

        public CacheManager KeepAlive(TimeSpan sliding)
        {
            var clone = Clone();
            clone.SlidingExpiration = sliding;
            return clone;
        }

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

        public CacheManager Clone()
        {
            return new CacheManager() { Name = Name, Description = Description, Expiration = Expiration, SlidingExpiration = SlidingExpiration };
        }
        
        // Wrappers for this with 1-15 arguments are located in the CacheManagerExtensions.cs file
        /// <summary>
        /// 
        /// </summary>
        public TOut Get<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>(Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3, TIn4 i4, TIn5 i5, TIn6 i6, TIn7 i7, TIn8 i8, TIn9 i9, TIn10 i10, TIn11 i11, TIn12 i12, TIn13 i13, TIn14 i14, TIn15 i15, TIn16 i16)
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
            var caller = CallAnalyzer.GetCallbackInfo<TOut>(callback);

            var key = KeyBuilder.Build(type, caller, keys.ToArray());

            var value = _cache.Get(key);
            if (value == null)
            {
                value = callback(i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16); ;
                if (value != null)
                    _cache.Put(key, value);
            }

            return value is TOut ? (TOut)value : default(TOut);
        }

        private T Get<T>()
        {
            return default(T);
        }

        public T Get<T>(Callback<T> callback, params object[] parameters)
        {
            var type = typeof(T);
            var caller = CallAnalyzer.GetCallerInfo();
            var key = KeyBuilder.Build(type, caller, parameters);

            var value = _cache.Get(key);
            if (value == null)
            {
                value = callback(parameters);
                if (value != null)
                    _cache.Put(key, value);
            }

            return value is T ? (T)value : default(T);
        }

        public void Put(object value, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public bool Exists<T>(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Flush()
        {
            throw new NotImplementedException();
        }
    }
}