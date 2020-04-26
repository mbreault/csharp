using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;

namespace DataStructures
{
    [TestClass]
    public class ConcurrentConcurrentQueue
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
            concurrentQueue.Enqueue(expected);
            string actual;
            bool result = concurrentQueue.TryDequeue(out actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
