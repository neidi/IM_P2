namespace IM_P2;

public class Bestellposition
{
    private string _produktName;
    private decimal _produktPreis;
    private int _produktMenge;

    public Bestellposition(
        string produktName,
        decimal produktPreis,
        int produktMenge)
    {
        _produktName = produktName;
        _produktPreis = produktPreis;
        _produktMenge = produktMenge;
    }

    public decimal BerechneGesamtpreis()
    {
        return _produktPreis * _produktMenge;
    }
}