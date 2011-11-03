using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCabinet.Tests.Data;

namespace NCabinet.Tests.Basic
{
    [TestClass]
    public class MethodCallback : BaseTest
    {
        [TestMethod]
        public void GetWithoutParameters()
        {
            var cache = Cache;

            var user1 = cache.Get(Mock.GetDefaultUser);
            Thread.Sleep(1000);
            var user2 = cache.Get(Mock.GetDefaultUser);

            Assert.IsNotNull(user1);
            Assert.IsNotNull(user2);
            Assert.AreEqual(user1.Timestamp, user2.Timestamp);
            Assert.AreSame(user1, user2);
        }

        [TestMethod]
        public void Get()
        {
            var cache = Cache;
            
            var user1 = cache.Get(Mock.GetUser, 1);
            Thread.Sleep(1000);
            var user2 = cache.Get(Mock.GetUser, 1);

            Assert.IsNotNull(user1);
            Assert.IsNotNull(user2);
            Assert.AreEqual(user1.Timestamp, user2.Timestamp);
            Assert.AreSame(user1, user2);
        }

        [TestMethod]
        public void Remove()
        {
            var cache = Cache;

            var user1 = cache.Get(Mock.GetUser, 2);
            Thread.Sleep(1000);
            cache.Remove(Mock.GetUser, 2);
            Thread.Sleep(1000);
            var user2 = cache.Get(Mock.GetUser, 2);

            Assert.IsNotNull(user1);
            Assert.IsNotNull(user2);
            Assert.AreNotEqual(user1.Timestamp, user2.Timestamp);
            Assert.AreNotSame(user1, user2);
        }

        [TestMethod]
        public void Exists()
        {
            var cache = Cache;

            var user1 = cache.Get(Mock.GetUser, 3);
            var exists = cache.Exists(Mock.GetUser, 3);
            var doesNotExist = cache.Exists(Mock.GetUser, 30000);

            Assert.IsNotNull(user1);
            Assert.IsTrue(exists);
            Assert.IsFalse(doesNotExist);
        }
       
    }
}
