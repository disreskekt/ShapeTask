using ShapeAreaCalculator.Shapes;

namespace Tests;

public class PolymorphismTests
{
    [Fact]
    public void CalculateFewAreas()
    {
        //arrange
        Triangle triangle = new(5, 5, 5);
        const double triangleExpected = 10.825;

        Circle circle = new(10);
        const double circleExpected = 314.1593;

        //act
        double triangleArea = GetShapeArea(triangle);
        double circleArea = GetShapeArea(circle);
        
        //assert
        Assert.Equal(triangleExpected, triangleArea, 0.001);
        Assert.Equal(circleExpected, circleArea, 0.001);
    }
    
    private static double GetShapeArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}