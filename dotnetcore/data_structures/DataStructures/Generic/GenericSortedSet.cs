using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericSortedSet
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            SortedSet<string> sortedSet = new SortedSet<string> { expected };
            string actual = sortedSet.First();
            Assert.AreEqual(expected, actual);
        }
    }
}
