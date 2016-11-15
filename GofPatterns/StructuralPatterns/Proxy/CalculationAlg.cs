using System;

namespace GofPatterns.StructuralPatterns.Proxy
{
    public abstract class CalculationAlgBase
    {
        public abstract int Calculate();
    }

    public class CalculationAlg : CalculationAlgBase
    {
        public override int Calculate()
        {
            //It's should be very slow operation, right?
            System.Diagnostics.Trace.WriteLine("Making big calculation");
            return 1000000;
        }
    }

    public class CalculationAlgProxy : CalculationAlgBase
    {
        private CalculationAlg _calcAlgOriginal;
        private int _cachedValue;

        public override int Calculate()
        {
            if (_calcAlgOriginal == null)
            {
                _calcAlgOriginal = new CalculationAlg();
                _cachedValue = _calcAlgOriginal.Calculate();
            }

            return _cachedValue;
        }
    }
}
