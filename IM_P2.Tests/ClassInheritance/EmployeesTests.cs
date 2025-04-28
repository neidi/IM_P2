namespace IM_P2.Tests.ClassInheritance;

using IM_P2.ClassInheritance;

public class EmployeesTests
{
    [Fact]
    public void Developer_ShouldBeAssignableToEmployee()
    {
        // Arrange
        var developer = new Developer("John Doe", 1, 100);

        // Act & Assert
        Assert.IsAssignableFrom<Employee>(developer);
    }
    
    [Fact]
    public void Manager_ShouldBeAssignableToEmployee()
    {
        // Arrange
        var manager = new Manager("Jane Doe", 2);

        // Act & Assert
        Assert.IsAssignableFrom<Employee>(manager);
    }
    
    [Fact]
    public void Developer_CalculateSalary_ShouldReturnCorrectValue()
    {
        // Arrange
        var developer = new Developer("John Doe", 1, 10);

        // Act
        var salary = developer.CalculateSalary();

        // Assert
        Assert.Equal(4000m, salary);
    }
    
    [Fact]
    public void Manager_CalculateSalary_ShouldReturnCorrectValue()
    {
        // Arrange
        var manager = new Manager("Jane Doe", 2);

        // Act
        var salary = manager.CalculateSalary();

        // Assert
        Assert.Equal(5000m, salary);
    }
}