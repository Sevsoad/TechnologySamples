using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GofPatterns.Prototype
{
    [TestClass]
    public class PrototypeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dev dev = new Dev();
            dev.Name = "Richard";
            dev.CodePerHour = 140;

            Qa qa = new Qa();
            qa.Name = "Paul";
            qa.BugsPerHour = 3;

            Qa qaClone = (Qa)qa.Clone();
            qaClone.Name = "Paul's clone";

            System.Diagnostics.Trace.WriteLine(qa.Name);
            System.Diagnostics.Trace.WriteLine(qaClone.Name);
            System.Diagnostics.Trace.WriteLine(qaClone.BugsPerHour);
        }
    }
}
