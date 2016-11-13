namespace GofPatterns.AbstrFactory
{
    public abstract class Engine
    {
        public string EngineName { get; set; }
    }

    public class ElectroEngine : Engine
    {
        public ElectroEngine()
        {
            EngineName = "ElectroEngine v1.0";
        }
    }

    public class PetrolEngine : Engine
    {
        public PetrolEngine()
        {
            EngineName = "PetrolEngine v22.0";
        }
    }
}
