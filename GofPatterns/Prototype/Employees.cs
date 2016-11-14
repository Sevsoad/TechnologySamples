namespace GofPatterns.Prototype
{
    public abstract class Employee
    {
        public string Name;
        public abstract Employee Clone();
    }

    public class Qa : Employee
    {
        public int BugsPerHour;
        public override Employee Clone()
        {
            return (Qa)MemberwiseClone();
        }
    }

    public class Dev : Employee
    {
        public int CodePerHour;
        public override Employee Clone()
        {
            return (Dev)MemberwiseClone();
        }
    }
}
