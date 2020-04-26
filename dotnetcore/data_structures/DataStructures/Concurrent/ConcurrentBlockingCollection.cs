using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;

namespace DataStructures
{
    [TestClass]
    public class ConcurrentBlockingCollection
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            BlockingCollection<string> blockingCollection = new BlockingCollection<string> { expected };
            string actual;
            bool result = blockingCollection.TryTake(out actual);
            Assert.IsTrue(result);
            Assert.AreEqual(expected, actual);
        }
    }
}
