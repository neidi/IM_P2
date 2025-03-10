namespace IM_P2.People;

public class Person
{
    private int _age;

    public Person(string fullName, int heightInCm)
    {
        _age = 0;
        FullName = fullName;
        HeightInCm = heightInCm;
    }

    public string FullName { get; }

    public int HeightInCm { get; private set; }

    public void Grow(int cm)
    {
        HeightInCm = HeightInCm + cm;
    }

    public void Age(int years)
    {
        _age += years;
    }
}