namespace NCabinet.Settings
{
    public class InitializationExpression : IInitializationExpression
    {
        public void UseProvider<T>() where T : ICacheProvider
        {
            CacheManager.SetProvider(default(T));
        }
    }
}