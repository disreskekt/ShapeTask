namespace ShapeAreaCalculator.Helpers;

public static class TriangleHelper
{
    public static bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC &&
               sideA + sideC > sideB &&
               sideB + sideC > sideA;
    }

    public static bool IsTriangleRightBySides(double sideA, double sideB, double sideC)
    {
        if (!FindHypotenuse(sideA, sideB, sideC, out double hypotenuse))
        {
            return false;
        }

        (double legA, double legB) = FindLegs(hypotenuse, sideA, sideB, sideC);

        if (!IsTriangleRight(hypotenuse, legA, legB))
        {
            return false;
        }

        return true;
    }
    
    public static bool IsTriangleRight(double hypotenuse, double legA, double legB)
    {
        if (MathHelper.AreDoubleNumbersEqual(
                Math.Pow(hypotenuse, 2),
                Math.Pow(legA, 2) + Math.Pow(legB, 2),
                0.001))
        {
            return true;
        }

        return false;
    }

    public static bool FindHypotenuse(double first, double second, double third, out double hypotenuse)
    {
        if (first > second && first > third)
        {
            hypotenuse = first;
            return true;
        }

        if (second > first && second > third)
        {
            hypotenuse = second;
            return true;
        }

        if (third > first && third > second)
        {
            hypotenuse = third;
            return true;
        }

        hypotenuse = 0;
        return false;
    }
    
    public static (double legA, double legB) FindLegs(double hypotenuse, double sideA, double sideB, double sideC)
    {
        if (MathHelper.AreDoubleNumbersEqual(sideA, hypotenuse, 0.001))
        {
            return (sideB, sideC);
        }
        
        if (MathHelper.AreDoubleNumbersEqual(sideB, hypotenuse, 0.001))
        {
            return (sideA, sideC);
        }
        
        return (sideA, sideB);
    }
}