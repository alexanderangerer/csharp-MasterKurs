namespace OOP;

public class Bankkonto
{
    // Eigenschaften
    public decimal Kontostand { get; set; }
    public String Besitzer { get; set; }

    private string bankname = "";

    public string Bankname
    {
        get
        {
            if (bankname == "")
            {
                return "Kein Name angegeben.";
            }

            return bankname;
        }
        set
        {
            if (value == "")
            {
                bankname = "Keine";
            }
            else
            {
                bankname = value;
            }
        }
    }
    
    // Methoden
    public void Einzahlung(decimal betrag)
    {
        Kontostand += betrag;
        Console.WriteLine("Es wurde " + betrag + " Euro auf das Konto eingezahlt!");
        Console.WriteLine("Der neue Kontostand beträgt " + Kontostand + " Euro!");
    }

    public void Auszahlung(decimal betrag)
    {
        Kontostand -= betrag;
        Console.WriteLine("Es wurde " + betrag + " Euro vom Konto abgehoben!");
        Console.WriteLine("Der neue Kontostand beträgt " + Kontostand + " Euro!");
    }
}