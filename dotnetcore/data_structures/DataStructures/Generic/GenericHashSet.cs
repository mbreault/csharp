using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericHashSet
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            HashSet<string> hashSet = new HashSet<string> { expected };
            string actual = hashSet.First();
            Assert.AreEqual(expected, actual);
        }
    }
}
