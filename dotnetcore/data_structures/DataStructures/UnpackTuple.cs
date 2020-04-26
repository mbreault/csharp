using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructures
{
    [TestClass]
    public class UnpackTuple
    {
        [TestMethod]
        public void FixedLength()
        {
            // Unpack a tuple into separate variables

            var tuple = Tuple.Create("foo", "bar");
            string foo = tuple.Item1;
            string bar = tuple.Item2;
            Assert.AreEqual("foo", foo);
            Assert.AreEqual("bar", bar);
        }
    }
}
