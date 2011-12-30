namespace NCabinet.Tests
{
    public class BaseTest
    {
        internal static CacheManager Cache
        {
            get
            {
                if (!CacheManager.IsReady)
                    CacheManager.Initialize(setting =>
                    {
                        setting.UseProvider<ICacheProvider>(new HttpRuntimeCacheProvider.HttpRuntimeCacheProvider());
                        setting.EnableMonitoring();
                    });

                return CacheManager.Create();
            }
        }
    }
}