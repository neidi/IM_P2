namespace IM_P2.InterfaceImplementation_Shapes;

public class Rectangle(double length, double width) : IShape
{
    public double CalculateArea()
    {
        return length * width;
    }
}