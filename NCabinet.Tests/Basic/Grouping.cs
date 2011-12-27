using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCabinet.Tests.Data;

namespace NCabinet.Tests.Basic
{
    [TestClass]
    public class Grouping : BaseTest
    {
        [TestMethod]
        public void SingleThreaded()
        {
            var cache = Cache;
            cache.GroupBy("Key").Get(Mock.GetUser, 1);
            cache.GroupBy("Key").Get(Mock.GetUser, 2);
            cache.GroupBy("Key").Get(Mock.GetUser, 3);
            cache.GroupBy("Key").Get(Mock.GetUser, 4);
            cache.GroupBy("Key").Get(Mock.GetUser, 5);

            Assert.IsTrue(cache.Exists(Mock.GetUser, 1));
            Assert.IsTrue(cache.Exists(Mock.GetUser, 2));
            Assert.IsTrue(cache.Exists(Mock.GetUser, 3));
            Assert.IsTrue(cache.Exists(Mock.GetUser, 4));
            Assert.IsTrue(cache.Exists(Mock.GetUser, 5));

            cache.RemoveGroup("Key");

            Assert.IsFalse(cache.Exists(Mock.GetUser, 1));
            Assert.IsFalse(cache.Exists(Mock.GetUser, 2));
            Assert.IsFalse(cache.Exists(Mock.GetUser, 3));
            Assert.IsFalse(cache.Exists(Mock.GetUser, 4));
            Assert.IsFalse(cache.Exists(Mock.GetUser, 5));
        }

        [TestMethod]
        public void MultiThreaded()
        {
        }
    }
}