using System;

namespace NCabinet
{
    public delegate TOut KeyWrapper<TIn1, TIn2, TOut>(TIn1 i1, TIn2 i2);

    public class CacheManager : ICacheManager
    {

        public TOut Get<TIn1, TIn2, TOut>(Func<TIn1, TIn2, TOut> a, TIn1 i1, TIn2 i2)
        {
            return a(i1, i2);
        }

        public TOut Get<TIn1, TOut>(Func<TIn1, TOut> a, TIn1 i1)
        {
            return Get()
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