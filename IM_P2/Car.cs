namespace IM_P2;

internal class Car
{
    
    private int speed;

    public int Speed
    {
        get { return speed; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            speed = value;
        }
    }

    public void Accelerate(int value)
    {
        int x = 15;

        Console.WriteLine($"{this.Speed}");

        Console.WriteLine($"{x}");
    }

    void SetSpeed(int speed)
    {
        this.Speed = speed;
    }

}