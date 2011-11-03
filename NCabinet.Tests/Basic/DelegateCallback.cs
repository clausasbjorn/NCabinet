using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCabinet.Tests.Data;

namespace NCabinet.Tests.Basic
{
    [TestClass]
    public class DelegateCallback : BaseTest
    {
        private readonly Callback<User> _getUser = keys =>
        {
            var userID = (int)keys[0];
            return new User() { UserID = userID };
        };

        private readonly Callback<User> _getUserExpression = keys => new User() { UserID = (int)keys[0] };

        [TestMethod]
        public void Get()
        {
            var cache = Cache;

            var user1 = cache.Get(_getUser, 101);
            Thread.Sleep(1000);
            var user2 = cache.Get(_getUser, 101);

            var user3 = cache.Get(_getUserExpression, 102);
            Thread.Sleep(1000);
            var user4 = cache.Get(_getUserExpression, 102);

            Assert.IsNotNull(user1);
            Assert.IsNotNull(user2);
            Assert.AreEqual(user1.Timestamp, user2.Timestamp);
            Assert.AreSame(user1, user2);

            Assert.IsNotNull(user3);
            Assert.IsNotNull(user4);
            Assert.AreEqual(user3.Timestamp, user4.Timestamp);
            Assert.AreSame(user3, user4);
        }
        
        [TestMethod]
        public void Remove()
        {
            var cache = Cache;

            var user1 = cache.Get(_getUser, 103);
            Thread.Sleep(1000);
            cache.Remove(_getUser, 103);
            Thread.Sleep(1000);
            var user2 = cache.Get(_getUser, 103);

            Assert.IsNotNull(user1);
            Assert.IsNotNull(user2);
            Assert.AreNotEqual(user1.Timestamp, user2.Timestamp);
            Assert.AreNotSame(user1, user2);
        }

        [TestMethod]
        public void Exists()
        {
            var cache = Cache;

            var user1 = cache.Get(_getUser, 104);
            var exists = cache.Exists(_getUser, 104);
            var doesNotExist = cache.Exists(_getUser, 1040000);

            Assert.IsNotNull(user1);
            Assert.IsTrue(exists);
            Assert.IsFalse(doesNotExist);
        }
       
    }
}
