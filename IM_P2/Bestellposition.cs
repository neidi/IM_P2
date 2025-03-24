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

    public decimal Gesamtpreis => _produktPreis * _produktMenge;
    
    public Adresse? Versandadresse { get; private set; }
    
    public void SetzeVersandadresse(
        string vorname,
        string name,
        string strasse,
        int plz,
        string ort)
    {
        if (Versandadresse != null)
        {
            throw new NotSupportedException("Changing the Versandadresse is not (yet) supported");
        }
        
        Versandadresse = new Adresse(vorname, name, strasse, plz, ort);
    }
}

public record Adresse(
    string Vorname,
    string Name,
    string Strasse,
    int Plz,
    string Ort); 