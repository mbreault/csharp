using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericQueue
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(expected);
            string actual = queue.Dequeue();
            Assert.AreEqual(expected, actual);
        }
    }
}
