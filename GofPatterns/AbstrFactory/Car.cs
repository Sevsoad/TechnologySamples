using System;

namespace GofPatterns.AbstrFactory
{
    public class Car
    {
        private Engine _engine;
        private PowerBlock _powerBlock;

        public Car(CarFactory factory)
        {
            _engine = factory.CreateEngine();
            _powerBlock = factory.CreatePowerBlock();
        }

        public string Ride()
        {
            return string.Format("Riding using {0} and {1}",
                _engine.EngineName, _powerBlock.PowerBlockName);
        }

    }
}
