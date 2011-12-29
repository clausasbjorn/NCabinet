using System;

namespace NCabinet
{
    /// <summary>
    /// The interface any cache provider must adhere to.
    /// </summary>
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