namespace IM_P2.ClassInheritance;

/// <summary>
/// Employee class which serves as a base class for different types of employees.
/// </summary>
/// <param name="name">The name of the employee.</param>
/// <param name="id">The ID of the employee. This has to be unique.</param>
public abstract class Employee(string name, int id)
{
    private const decimal BaseSalary = 3000m;

    // Abstrakte Methode, die in den abgeleiteten Klassen implementiert werden muss
    /// <summary>
    /// Calculates the bonus for the employee. The implementation depends on the type of employee.
    /// </summary>
    /// <returns>The bonus amount.</returns>
    protected abstract decimal CalculateBonus();
    
    /// <summary>
    /// Calculates the total salary of the employee, including the base salary and any bonuses.
    /// </summary>
    /// <returns></returns>
    public decimal CalculateSalary()
    {
        return BaseSalary + CalculateBonus();
    }

    // Virtuelle Methode, die in den abgeleiteten Klassen erweitert werden kann
    /// <summary>
    /// Displays the information of the employee.
    /// </summary>
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Employee: {name} (ID: {id})");
    }
}