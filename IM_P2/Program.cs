// See https://aka.ms/new-console-template for more information

using IM_P2;
using IM_P2.People;

Console.WriteLine("Hello, World!");

Car x = new Car();

x.Accelerate(15);

Circuit.AccelerateCar();

Person a;
Student s;



public class Circuit
{
    public static readonly Car Car = new Car();
    
    public static void AccelerateCar()
    {
        Car.Accelerate(10);
        Car = new Car();
    }
}