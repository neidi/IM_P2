namespace IM_P2.Abgabearbeit;

public class Cat : IAnimal
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private int _vaccinesReceived;
    private DateTime _lastVaccineReceived;

    public Cat(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }

    public bool IsImmune => _vaccinesReceived >= 2 && _lastVaccineReceived.AddDays(365) > _dateTimeProvider.Now;

    public void ReceiveVaccine()
    {
        _vaccinesReceived++;
        _lastVaccineReceived = _dateTimeProvider.Now;
    }
}