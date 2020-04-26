using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;

namespace DataStructures
{
    [TestClass]
    public class ConcurrentConcurrentStack
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            ConcurrentStack<string> concurrentStack = new ConcurrentStack<string>();
            concurrentStack.Push(expected);
            string actual;
            bool result = concurrentStack.TryPop(out actual);
            Assert.IsTrue(result);
            Assert.AreEqual(expected, actual);
        }
    }
}
