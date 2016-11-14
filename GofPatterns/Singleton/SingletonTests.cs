using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GofPatterns.Singleton
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var singletonObject = Singleton.GetInstance();

            singletonObject.InternalValue = "Singleton#1";

            var anotherSingletonObject = Singleton.GetInstance();

            Assert.AreEqual(anotherSingletonObject.InternalValue, "Singleton#1");
        }
    }
}
