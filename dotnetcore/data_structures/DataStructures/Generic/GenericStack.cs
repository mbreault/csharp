using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    [TestClass]
    public class GenericStack
    {
        [TestMethod]
        public void Add()
        {
            string expected = "foo";
            Stack<string> stack = new Stack<string>();
            stack.Push(expected);
            string actual = stack.Pop();
            Assert.AreEqual(expected, actual);
        }
    }
}
