using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GofPatterns.StructuralPatterns.Adapter
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var navSystem = new NavigationSystem();
            ICoordinateProvider coordProvider = new CoordinatProviderAdapter(navSystem);
            var coordBoard = new CoordinatBoard(coordProvider);

            var boardOutput = coordBoard.GetCoordinates();

            System.Diagnostics.Trace.WriteLine(boardOutput);
        }
    }
}
