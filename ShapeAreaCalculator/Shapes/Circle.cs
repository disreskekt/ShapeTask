namespace ShapeAreaCalculator.Shapes;

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be a positive number.");
        }

        Radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}