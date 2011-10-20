using System;
using System.Web;
using System.Web.Caching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NCabinet.Tests
{
    [TestClass]
    public class Getting
    {
        [TestMethod]
        public void Get()
        {
            var httpCache = HttpRuntime.Cache;
            var key = "GetAString" + 10;
            var str = GetAString(10);
            if (httpCache[key] == null)
                httpCache.Add(key, str, null, DateTime.Now.AddDays(1), Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);

            var r2 = CacheManager.Create()
                .Expires(DateTime.Now.AddDays(1))
                .Get(GetAString, 10);

            var cache = new CacheManager();
            var output = cache.Get(GetAString, 10);
            var output1 = cache.Get(GetAString, 10, 20);

            cache.Get(GetAString, 10);
        }

        private static string GetAString(int asInteger)
        {
            return asInteger.ToString();
        }

        public string GetAString(int asInteger, int anotherOne)
        {
            return (asInteger + anotherOne).ToString();
        }
    }
}
