using ShapeAreaCalculator.Helpers;
using ShapeAreaCalculator.Validators;

namespace ShapeAreaCalculator.Shapes;

public class Triangle : Shape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    public bool IsRight { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        TriangleValidator.ValidateTriangleSides(sideA, sideB, sideC);

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        IsRight = TriangleHelper.IsTriangleRightBySides(sideA, sideB, sideC);
    }
    
    public override double CalculateArea()
    {
        return IsRight
            ? CalculateAreaRight()
            : CalculateAreaCommon();
    }

    private double CalculateAreaCommon()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;

        return Math.Sqrt(semiPerimeter *
                         (semiPerimeter - SideA) *
                         (semiPerimeter - SideB) *
                         (semiPerimeter - SideC));
    }

    private double CalculateAreaRight()
    {
        if (!TriangleHelper.FindHypotenuse(SideA, SideB, SideC, out double hypotenuse))
        {
            throw new ArgumentException("The given sides does not form a valid right triangle.");
        }

        (double legA, double legB) = TriangleHelper.FindLegs(hypotenuse, SideA, SideB, SideC);

        if (!TriangleHelper.IsTriangleRight(hypotenuse, legA, legB))
        {
            throw new ArgumentException("The given sides does not form a valid right triangle.");
        }
        return legA * legB / 2;
    }
}