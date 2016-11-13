namespace Serialization.Models.Figures
{
    public abstract class Figure
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public class Circle : Figure
    {
        public double r { get; set; }
    }

    public class Rectangle : Figure
    {
        public double w { get; set; }
        public double h { get; set; }
    }

    public class Line : Figure
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
    }
}
