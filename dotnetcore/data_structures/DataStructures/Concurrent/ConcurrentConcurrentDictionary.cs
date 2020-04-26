using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;

namespace DataStructures
{
    [TestClass]
    public class ConcurrentConcurrentDictionary
    {
        [TestMethod]
        public void Add()
        {
            string key = "foo";
            string expected = "bar";
            ConcurrentDictionary<string, string> concurrentDictionary = new ConcurrentDictionary<string, string>();
            bool result =  concurrentDictionary.TryAdd(key, expected);
            Assert.IsTrue(result);
            string actual;
            result = concurrentDictionary.TryGetValue(key,out actual);
            Assert.IsTrue(result);
            Assert.AreEqual(expected, actual);
        }
    }
}
