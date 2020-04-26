using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericList
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            List<string> list = new List<string> { expected };
            string actual = list[0];
            Assert.AreEqual(expected, actual);
        }
    }
}
