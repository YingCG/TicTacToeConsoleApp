using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestLearning;
namespace UnitTestLearningTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Chili and Lime");
            testInstance.Sauces.Add("Tomyam");

            // expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Chili and Lime"));

            // expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Chili and Lame"));
        }
    }
}
