using System.Runtime.CompilerServices;

namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        // KlassenInitialisieren();
        Vererbung();
    }

    static void Vererbung()
    {
        Notebook mba = new Notebook("M1", 64);
        // mba.Prozessor = "M1";
        // mba.Arbeitspeicher = 64;
        // mba.Batteriestand = 55;
        
        mba.Einschalten();
        mba.Laden();
        mba.Ausschalten();
    }

    static void KlassenInitialisieren()
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
class Notebook : Computer
{
    public Notebook(string prozessor, int ram) : base(prozessor, ram)
    {
        Console.WriteLine("Konstruktor in der Notebook-Klasse.");
        Batteriestand = 100;
    }
    public int Batteriestand { get; set; }

    public void Laden()
    {
        Console.WriteLine("Notebook: Computer wird geladen.");
    }
}
class Computer
{
    public Computer(string prozessor, int ram)
    {
        Console.WriteLine("Konstruktor in der Computer-Klasse.");
        Prozessor = prozessor;
        Arbeitspeicher = ram;
    }
    public string Prozessor { get; set; }
    public int Arbeitspeicher { get; set; }

    public void Einschalten()
    {
        Console.WriteLine("Computer: Der Computer wurde eingeschaltet.");
    }

    public void Ausschalten()
    {
        Console.WriteLine("Computer: Der Computer wird ausgeschaltet.");
    }
}