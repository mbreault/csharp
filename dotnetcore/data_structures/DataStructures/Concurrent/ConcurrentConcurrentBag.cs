using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;

namespace DataStructures
{
    [TestClass]
    public class ConcurrentConcurrentBag
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            ConcurrentBag<string> concurrentBag = new ConcurrentBag<string> { expected };
            string actual;
            bool result =  concurrentBag.TryTake(out actual);
            Assert.IsTrue(result);
            Assert.AreEqual(expected, actual);
        }
    }
}
