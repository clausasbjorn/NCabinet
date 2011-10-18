using System;

namespace NCabinet
{
    public interface ICacheManager
    {
        T Get<T>(Callback<T> callback, params object[] parameters);
        T Get<T>(Callback<T> callback, DateTime expires, params object[] parameters);
        T Get<T>(Callback<T> callback, TimeSpan keepAlive, params object[] parameters);
        void Put(object value, params object[] parameters);
        void Put(object value, DateTime expires, params object[] parameters);
        void Put(object value, TimeSpan keepAlive, params object[] parameters);
        void Remove<T>(params object[] parameters);
        bool Exists<T>(params object[] parameters);
        void Flush();
    }
}