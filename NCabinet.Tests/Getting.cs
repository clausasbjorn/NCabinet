using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NCabinet.Tests
{
    [TestClass]
    public class Getting
    {
        [TestMethod]
        public void Get()
        {
            var cache = new CacheManager();
            cache.Get(GetAString, 10);
            cache.Get(GetAString, 10, 20);
        }

        public string GetAString(int asInteger)
        {
            return asInteger.ToString();
        }

        public string GetAString(int asInteger, int anotherOne)
        {
            return (asInteger + anotherOne).ToString();
        }
    }
}
