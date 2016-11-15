using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GofPatterns.StructuralPatterns.Facade
{
    [TestClass]
    public class FacadeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var advService = new LetterAdvertisingService();
            var prcSvc = new LetterPricesService();
            var footSvc = new LetterFooterService();

            var letterSender = new LetterSenderFacade(advService, prcSvc, footSvc);

            var letter = letterSender.ComposeLetter();

            System.Diagnostics.Trace.WriteLine(letter);
        }
    }
}
