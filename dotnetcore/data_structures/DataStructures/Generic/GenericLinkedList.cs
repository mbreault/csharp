using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericLinkedList
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddFirst(expected);
            string actual = linkedList.First();
            Assert.AreEqual(expected, actual);
        }
    }
}
