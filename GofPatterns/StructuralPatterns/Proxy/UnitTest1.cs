using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GofPatterns.StructuralPatterns.Proxy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calcAlg = new CalculationAlgProxy();

            for (var i = 0; i < 5; i++)
            {
                var calculatedValue = calcAlg.Calculate();
                System.Diagnostics.Trace.WriteLine(calculatedValue);
            }
        }
    }
}
