using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDpractice;

namespace TDDpracticeTest
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.TodoList.Length, 5);
            Assert.AreEqual(testInstance.TodoList[1], "programming");
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("Everday"));
        }
    }
}
