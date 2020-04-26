using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class LastNElements
    {
        [TestMethod]
        public void TestMethod()
        {
            // Take last N elements from a list
            List<int> expected = new List<int> { 6, 7, 8, 9, 10 };
            List<int> list = new List<int>{1,2,3,4,5,6,7,8,9,10};
            List<int> actual = list.TakeLast(5).ToList();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
