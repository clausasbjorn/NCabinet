using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCabinet.Tests.Data;

namespace NCabinet.Tests.Basic
{
    [TestClass]
    public class NoCallback : BaseTest
    {
        [TestMethod]
        public void PutAndGet()
        {
            var cache = Cache;
            var user1 = Mock.GetUser(200);
            
            cache.Put(user1, "PutAndGet", "SomeOtherKey", 200);
            var user2 = cache.Get<User>("PutAndGet", "SomeOtherKey", 200);

            Assert.IsNotNull(user1);
            Assert.IsNotNull(user2);
            Assert.AreEqual(user1.Timestamp, user2.Timestamp);
            Assert.AreSame(user1, user2);
        }

        [TestMethod]
        public void Exists()
        {
            var cache = Cache;
            var user1 = Mock.GetUser(201);

            cache.Put(user1, "PutAndGet", "SomeOtherKey", 201);
            var exists = cache.Exists<User>("PutAndGet", "SomeOtherKey", 201);
            var doesNotExist = cache.Exists<User>("PutAndGet", "SomeOtherKey", 202);

            Assert.IsTrue(exists);
            Assert.IsFalse(doesNotExist);
        }

        [TestMethod]
        public void Remove()
        {
            var cache = Cache;
            var user1 = Mock.GetUser(203);

            cache.Put(user1, "PutAndGet", "SomeOtherKey", 203);
            cache.Remove<User>("PutAndGet", "SomeOtherKey", 203);
            var exists = cache.Exists<User>("PutAndGet", "SomeOtherKey", 203);

            Assert.IsFalse(exists);
        }
    }
}
