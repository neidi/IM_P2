namespace IM_P2.InterfaceImplementation;

public class Circle(double radius) : IShape
{
    public double CalculateArea()
    {
        return radius * Math.PI;
    }
}