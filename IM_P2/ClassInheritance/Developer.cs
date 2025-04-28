namespace IM_P2.ClassInheritance;

/// <summary>
/// Employee in the role of a developer.
/// </summary>
/// <param name="name"><inheritdoc cref="Employee"/></param>
/// <param name="id"><inheritdoc cref="Employee"/></param>
/// <param name="overtimeHours">
/// The overtime hours the developer has worked. The method CalculateBonus()
/// is dependent on the overtime hours worked.
/// </param>
public class Developer(string name, int id, int overtimeHours) : Employee(name, id)
{
    protected override decimal CalculateBonus()
    {
        return 100m * overtimeHours;
    }

    public override void DisplayInfo()
    {
        // Aufruf der Methode der Basisklasse
        base.DisplayInfo();
        // Zusätzliche Informationen für Entwickler
        Console.WriteLine($"Role: Developer, Overtime Hours: {overtimeHours}");
    }
}