using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GofPatterns.AbstrFactory
{
    [TestClass]
    public class CarFactoryTests
    {
        private CarFactory _carFactory;

        [TestMethod]
        public void CreatePetrolCar()
        {
            _carFactory = new PetrolCarFactory();
            var petrolCar = new Car(_carFactory);

            System.Diagnostics.Trace.WriteLine(petrolCar.Ride());
        }

        [TestMethod]
        public void CreateElectricCar()
        {
            _carFactory = new ElectricCarFactory();
            var petrolCar = new Car(_carFactory);

            System.Diagnostics.Trace.WriteLine(petrolCar.Ride());
        }
    }
}
