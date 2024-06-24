using ShapeAreaCalculator.Shapes;

namespace Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_RightTriangle5and4and3_6Returned()
    {
        //arrange
        const int a = 5;
        const int b = 4;
        const int c = 3;
        const double expected = 6;

        //act
        Triangle triangle = new(a, b, c);
        double actual = triangle.CalculateArea();

        //assert
        Assert.Equal(expected, actual, 0.001);
    }

    [Fact]
    public void CalculateArea_5and5and5_10point825Returned()
    {
        //arrange
        const int a = 5;
        const double expected = 10.825;

        //act
        Triangle triangle = new(a, a, a);
        double actual = triangle.CalculateArea();

        //assert
        Assert.Equal(expected, actual, 0.001);
    }

    [Fact]
    public void CalculateArea_13and13and10_60Returned()
    {
        //arrange
        const int a = 13;
        const int b = 10;
        const double expected = 60;

        //act
        Triangle triangleArea = new(a, a, b);
        double actual = triangleArea.CalculateArea();

        //assert
        Assert.Equal(expected, actual, 0.001);
    }
    
    [Fact]
    public void CalculateArea_0and0and0_ArgumentExceptionThrew()
    {
        //arrange
        const int a = 0;
        
        //act
        Action action = () => new Triangle(a, a, a);
        
        //assert
        Assert.Throws<ArgumentException>(action);
    }
    
    [Fact]
    public void CalculateArea_1and1and5_ArgumentExceptionThrew()
    {
        //arrange
        const int a = 1;
        const int b = 5;
        
        //act
        Action action = () => new Triangle(a, a, b);
        
        //assert
        Assert.Throws<ArgumentException>(action);
    }
}