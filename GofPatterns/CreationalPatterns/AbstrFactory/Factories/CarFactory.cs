namespace GofPatterns.AbstrFactory
{
    public abstract class CarFactory
    {
        public abstract Engine CreateEngine();
        public abstract PowerBlock CreatePowerBlock();
    }
}
