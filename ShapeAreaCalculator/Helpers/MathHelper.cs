namespace ShapeAreaCalculator.Helpers;

public static class MathHelper
{
    public static bool AreDoubleNumbersEqual(double firstNumber, double secondNumber, double epsilon)
    {
        return Math.Abs(firstNumber - secondNumber) < epsilon;
    }
}