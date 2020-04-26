using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericSortedDictionary
    {
        [TestMethod]
        public void Add()
        {
            string key = "foo";
            string expected = "bar";
            SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string,string> { { key,expected } };
            string actual = sortedDictionary[key];
            Assert.AreEqual(expected, actual);
        }
    }
}
