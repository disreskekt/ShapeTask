using ShapeAreaCalculator.Shapes;

namespace Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_10_314returned()
    {
        //arrange
        const int radius = 10;
        const double expected = 314.1593;

        //act
        Circle circle = new(radius);
        double actual = circle.CalculateArea();

        //assert
        Assert.Equal(expected, actual, 0.001);
    }
    
    [Fact]
    public void CalculateArea_0_ArgumentExceptionThrew()
    {
        //arrange
        const int radius = 0;
        
        //act
        Action action = () => new Circle(radius);
        
        //assert
        Assert.Throws<ArgumentException>(action);
    }
}