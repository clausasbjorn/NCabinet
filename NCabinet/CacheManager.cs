using System;
using NCabinet.Exceptions;

namespace NCabinet
{
    public partial class CacheManager : ICacheManager
    {
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
            return callback(i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16);
        }

        private T Get<T>()
        {
            return default(T);
        }

        public T Get<T>(Callback<T> callback, params object[] parameters)
        {
            throw new NotImplementedException();
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