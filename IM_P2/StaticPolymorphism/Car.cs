namespace IM_P2.StaticPolymorphism;

public class Car
{
    private readonly int _speedGainPerSecond;

    public Car(int speedGainPerSecond)
    {
        _speedGainPerSecond = speedGainPerSecond;
    }

    public int CurrentSpeed { get; private set; }

    public void Accelerate(int seconds)
    {
        CurrentSpeed += _speedGainPerSecond * seconds;
    }

    public void Accelerate(int seconds, int additionalSpeed)
    {
        CurrentSpeed += (_speedGainPerSecond * seconds) + additionalSpeed;
    }
    
    public sealed override string ToString()
    {
        return $"Current speed: {CurrentSpeed} km/h";
    }
}