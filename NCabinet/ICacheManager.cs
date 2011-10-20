namespace NCabinet
{
    public interface ICacheManager
    {
        T Get<T>(Callback<T> callback, params object[] parameters);
        void Put(object value, params object[] parameters);
        void Remove<T>(params object[] parameters);
        bool Exists<T>(params object[] parameters);
        void Flush();
    }
}