using System;

namespace NCabinet
{
    public interface ICacheProvider
    {
        object Get(string key);
        void Put(string key, object value);
        void Put(string key, object value, DateTime expires);
        void Put(string key, object value, TimeSpan keepAlive);
        void Remove(string key);
        bool Exists(string key);
        void Flush();
    }
}