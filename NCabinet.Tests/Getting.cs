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

            var test = CacheManager.Create().Get(Awesomeness, 10, 50, 40);
        }

        public string Awesomeness(int a, int b, int c)
        {
            return (a + b + c).ToString();
        }
    }
}
