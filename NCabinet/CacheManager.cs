using System;

namespace NCabinet
{
    public class CacheManager : ICacheManager
    {
        private class NoKey { }

        private static NoKey _n;
        private static NoKey N
        {
            get { return _n ?? (_n = new NoKey()); }
        }

        public TOut Get<TIn1, TIn2, TIn3, TOut>(Func<TIn1, TIn2, TIn3, TOut> callback, TIn1 i1, TIn2 i2, TIn3 i3)
        {
            return callback(i1, i2, i3);
        }

        public TOut Get<TIn1, TIn2, TOut>(Func<TIn1, TIn2, TOut> callback, TIn1 i1, TIn2 i2)
        {
            Func<TIn1, TIn2, NoKey, TOut> wrapper = (p1, p2, n2) => callback(p1, p2);
            return Get(wrapper, i1, i2, N);
        }

        public TOut Get<TIn1, TOut>(Func<TIn1, TOut> callback, TIn1 i1)
        {
            Func<TIn1, NoKey, NoKey, TOut> wrapper = (p1, n1, n2) => callback(p1);
            return Get(wrapper, i1, N, N);
        }

        private T Get<T>()
        {
            return default(T);
        }

        public T Get<T>(Callback<T> callback, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(Callback<T> callback, DateTime expires, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(Callback<T> callback, TimeSpan keepAlive, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Put(object value, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Put(object value, DateTime expires, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Put(object value, TimeSpan keepAlive, params object[] parameters)
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