namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        Bankkonto konto = new Bankkonto();

        konto.Kontostand = 2500;
        konto.Besitzer = "Lenia Angerer";
        
        konto.Einzahlung(500);
        konto.Auszahlung(1000);
        Console.WriteLine("Fertig");

        Console.WriteLine(konto.Bankname);
        konto.Bankname = "";
        Console.WriteLine(konto.Bankname);
    }
}