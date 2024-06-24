namespace ShapeAreaCalculator.Helpers;

public static class TriangleValidator
{
    public static void ValidateTriangleSides(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Sides must be positive numbers.");
        }

        if (!TriangleHelper.IsValidTriangle(sideA, sideB, sideC))
        {
            throw new ArgumentException("The given sides does not form a valid triangle.");
        }
    }
}