namespace IM_P2.ClassInheritance;

/// <summary>
/// Employee in the role of a developer.
/// </summary>
/// <inheritdoc cref="Employee"/>
/// <param name="overtimeHours">
/// The overtime hours the developer has worked. The method CalculateBonus()
/// is dependent on the overtime hours worked.
/// </param>
public class Developer(string name, int id, int overtimeHours) : Employee(name, id)
{
    /// <summary>
    /// Developer get 100 for each overtime hour as a bonus.
    /// </summary>
    /// <returns>The overtime hourly rate * 100</returns>
    protected override decimal CalculateBonus()
    {
        return 100m * overtimeHours;
    }

    /// <summary>
    /// Displays the information of the developer.
    /// Adds developer-specific information to the base class method.
    /// </summary>
    public override void DisplayInfo()
    {
        // Aufruf der Methode der Basisklasse
        base.DisplayInfo();
        // Zusätzliche Informationen für Entwickler
        Console.WriteLine($"Role: Developer, Overtime Hours: {overtimeHours}");
    }
}