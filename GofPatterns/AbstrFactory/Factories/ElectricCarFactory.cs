using System;

namespace GofPatterns.AbstrFactory
{
    public class ElectricCarFactory : CarFactory
    {
        public override Engine CreateEngine()
        {
            return new ElectroEngine();
        }

        public override PowerBlock CreatePowerBlock()
        {
            return new Bataries();
        }
    }
}
