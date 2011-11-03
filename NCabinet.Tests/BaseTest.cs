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
                    });

                return CacheManager.Create();
            }
        }
    }
}