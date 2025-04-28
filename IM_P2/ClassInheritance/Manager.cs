namespace IM_P2.ClassInheritance;

/// <summary>
/// Employee in the role of a manager.
/// </summary>
/// <param name="name"><inheritdoc cref="Employee"/></param>
/// <param name="id"><inheritdoc cref="Employee"/></param>
public class Manager(string name, int id) : Employee(name, id)
{
    protected override decimal CalculateBonus()
    {
        return 2000m;
    }

    public override void DisplayInfo()
    {
        // Aufruf der Methode der Basisklasse
        base.DisplayInfo();
        // Zusätzliche Informationen für Manager
        Console.WriteLine("Role: Manager");
    }
}