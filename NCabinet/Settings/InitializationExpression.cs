namespace NCabinet.Settings
{
    public class InitializationExpression : IInitializationExpression
    {
        public void UseProvider<T>(T provider) where T : ICacheProvider
        {
            CacheManager.SetProvider(provider);
        }
    }
}