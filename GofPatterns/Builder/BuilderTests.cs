using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GofPatterns.Builder
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void TestBuilder()
        {
            var director = new DrinkDirector();

            var coffeeBuilder = new CoffeeBuilder();
            var teaBuilder = new TeaBuilder();

            //Director produces products in vuilders
            director.MakeDrink(teaBuilder);
            director.MakeDrink(coffeeBuilder);

            //builders return same product but coocked differently
            var cupOfTea = teaBuilder.GetDrink();
            var cupOfCoffee = coffeeBuilder.GetDrink();

            System.Diagnostics.Trace.WriteLine(cupOfTea.Cup);
            System.Diagnostics.Trace.WriteLine(cupOfCoffee.Cup);
        }
    }
}
