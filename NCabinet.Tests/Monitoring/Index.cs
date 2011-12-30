using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCabinet.Tests.Data;

namespace NCabinet.Tests.Monitoring
{
    [TestClass]
    public class Index : BaseTest
    {
        [TestMethod]
        public void Add()
        {
            var cache = Cache;
            var monitor = CacheManager.Monitor;

            cache.Info("test").Get(Mock.GetUser, 500);

            var result = monitor.Search("test");
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void Remove()
        {
            var cache = Cache;
            var monitor = CacheManager.Monitor;

            cache.Info("test").Get(Mock.GetUser, 500);

            var result = monitor.Search("test");
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            cache.Remove(Mock.GetUser, 500);

            result = monitor.Search("test");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Repeat()
        {
            var cache = Cache;
            var monitor = CacheManager.Monitor;

            cache.Info("test").Get(Mock.GetUser, 500);

            var result = monitor.Search("test");
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            cache.Remove(Mock.GetUser, 500);

            result = monitor.Search("test");
            Assert.AreEqual(0, result.Count);

            cache.Info("test").Get(Mock.GetUser, 500);

            result = monitor.Search("test");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CaseInsensitive()
        {
            var cache = Cache;
            var monitor = CacheManager.Monitor;

            cache.Info("TeSt").Get(Mock.GetUser, 500);

            var result = monitor.Search("tEsT");
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }
    }
}
