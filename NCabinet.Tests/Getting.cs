using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NCabinet.Tests
{
    [TestClass]
    public class Getting
    {
        [TestMethod]
        public void Get()
        {
            CacheManager.Initialize(setting =>
            {
                setting.UseProvider<ICacheProvider>();
            });

            
        }
    }
}
