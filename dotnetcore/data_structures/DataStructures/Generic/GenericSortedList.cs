using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericSortedList
    {
        [TestMethod]
        public void Add()
        {
            string key = "foo";
            string expected = "bar";
            SortedList<string,string> sortedList = new SortedList<string,string> { { key, expected } };
            string actual = sortedList[key];
            Assert.AreEqual(expected, actual);
        }
    }
}
