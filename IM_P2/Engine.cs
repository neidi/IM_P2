using System.Globalization;

namespace IM_P2;

public class EngineSanityChecker
{
    private const int MaxCylinderCount = 16;
    private const int MinCylinderCount = 1;

    public static void SanityCheck(int cylinderCount)
    {
        if (cylinderCount > MaxCylinderCount || cylinderCount < MinCylinderCount)
        {
            throw new ArgumentOutOfRangeException(nameof(cylinderCount), "Cylinder count must be between 1 and 14.");
        }
    }
}

public class Engine
{
    private readonly int _cylinderCount;

    private Engine(int cylinderCount)
    {
        _cylinderCount = cylinderCount;
    }

    public static Engine Create(int cylinderCount)
    {
        EngineSanityChecker.SanityCheck(cylinderCount);

        return new Engine(cylinderCount);
    }
}