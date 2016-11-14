using System;

namespace GofPatterns.AbstrFactory
{
    public class PetrolCarFactory : CarFactory
    {
        public override Engine CreateEngine()
        {
            return new PetrolEngine();
        }

        public override PowerBlock CreatePowerBlock()
        {
            return new OilTank();
        }
    }
}
