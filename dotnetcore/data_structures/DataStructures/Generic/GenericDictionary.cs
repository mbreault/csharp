using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericDictionary
    {
        [TestMethod]
        public void Add()
        {
            string key = "foo";
            string expected = "bar";
            Dictionary<string, string> dictionary = new Dictionary<string,string> { { key,expected } };
            string actual = dictionary[key];
            Assert.AreEqual(expected, actual);
        }
    }
}
