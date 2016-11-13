namespace GofPatterns.AbstrFactory
{
    public abstract class PowerBlock
    {
        public string PowerBlockName { get; set; }
    }

    public class Bataries : PowerBlock
    {
        public Bataries()
        {
            PowerBlockName = "Bataries v1.0";
        }
    }

    public class OilTank : PowerBlock
    {
        public OilTank()
        {
            PowerBlockName = "OilTank v9000.0";
        }
    }
}
