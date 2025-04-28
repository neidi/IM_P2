using IM_P2.StaticPolymorphism;

namespace IM_P2.Tests.StaticPolymorphism;

public class CarTests
{
    [Theory]
    [InlineData(10, 5, 50)]
    [InlineData(20, 3, 60)]
    [InlineData(15, 4, 60)]
    [InlineData(0, 10, 0)]
    public void Accelerate_WhenSecondsDrivingProvided_CalculationIsCorrect(
        int speedGainPerSecond,
        int seconds,
        int expectedSpeed)
    {
        // Arrange
        var car = new Car(speedGainPerSecond);

        // Act
        car.Accelerate(seconds);

        // Assert
        Assert.Equal(expectedSpeed, car.CurrentSpeed);
    }
    
    [Theory]
    [InlineData(10, 5, 70, 20)]
    [InlineData(20, 3, 90, 30)]
    [InlineData(15, 4, 70, 10)]
    [InlineData(0, 10, 10, 10)]
    public void Accelerate_WhenSecondsDrivingAndAdditionalSpeedProvided_CalculationIsCorrect(
        int speedGainPerSecond,
        int seconds,
        int expectedSpeed,
        int additionalSpeed)
    {
        // Arrange
        var car = new Car(speedGainPerSecond);

        // Act
        car.Accelerate(seconds, additionalSpeed);

        // Assert
        Assert.Equal(expectedSpeed, car.CurrentSpeed);
    }
}