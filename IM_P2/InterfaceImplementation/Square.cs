namespace IM_P2.InterfaceImplementation;

public class Square(double size) : IShape
{
    public double CalculateArea()
    {
        return size * size;
    }
}