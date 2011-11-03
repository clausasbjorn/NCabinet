using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NCabinet.Tests
{
    [TestClass]
    public class Setup
    {
        [TestMethod]
        public void SetProvider()
        {
            CacheManager.Initialize(setting =>
            {
                setting.UseProvider<ICacheProvider>(new HttpRuntimeCacheProvider.HttpRuntimeCacheProvider());
            });

            var cache = CacheManager.Create();
            Assert.IsTrue(CacheManager.IsReady);
        }
    }
}
