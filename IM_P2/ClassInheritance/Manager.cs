namespace IM_P2.ClassInheritance;

/// <summary>
/// Employee in the role of a manager.
/// </summary>
/// <inheritdoc cref="Employee"/>
public class Manager(string name, int id) : Employee(name, id)
{
    /// <summary>
    /// Managers get 2000 as a bonus.
    /// </summary>
    /// <returns>2000</returns>
    protected override decimal CalculateBonus()
    {
        return 2000m;
    }

    /// <summary>
    /// Displays the information of the manager.
    /// Extends the base class method to include manager-specific information.
    /// </summary>
    public override void DisplayInfo()
    {
        // Aufruf der Methode der Basisklasse
        base.DisplayInfo();
        // Zusätzliche Informationen für Manager
        Console.WriteLine("Role: Manager");
    }
}