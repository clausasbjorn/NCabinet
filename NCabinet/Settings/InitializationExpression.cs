namespace NCabinet.Settings
{
    /// <summary>
    /// Performs set up for the cache manager. Providing an elegant way to 
    /// initialize the cache manager.
    /// </summary>
    public class InitializationExpression : IInitializationExpression
    {
        public void UseProvider<T>(T provider) where T : ICacheProvider
        {
            CacheManager.SetProvider(provider);
        }
    }
}