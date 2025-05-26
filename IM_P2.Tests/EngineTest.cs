using Shouldly;

namespace IM_P2.Tests;

public class EngineTest
{
    [Fact]
    public void Create_WhenCylinderCountIsSmallerThanMinCylinderCount_ThrowsException()
    {
        // Arrange
        int cylinderCount = 0;

        Action act = () => Engine.Create(cylinderCount);
        
        act.ShouldThrow<ArgumentOutOfRangeException>()
            .ParamName.ShouldBe("cylinderCount");
    }

    private void CreateEngine(int cylinderCount)
    {
        Engine.Create(cylinderCount);
    }
    
    [Fact]
    public void Create_WhenCylinderCountIsGreaterThanMaxCylinderCount_ThrowsException()
    {
        // Arrange
        int cylinderCount = 17;
        
        Action act = () => Engine.Create(cylinderCount);
        
        act.ShouldThrow<ArgumentOutOfRangeException>()
            .ParamName.ShouldBe("cylinderCount");
    }
    
    [Fact]
    public void Create_WhenSanityCheckPassed_CreatesEngine()
    {
        // Arrange
        int cylinderCount = 4;

        // Act
        var engine = Engine.Create(cylinderCount);
        
        // Assert
        engine.ShouldNotBeNull();
    }
}