using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Xml.Schema;

namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        // KlassenInitialisieren();
        // Vererbung();
        AsOperator();
    }

    static void AsOperator()
    {
        Object[] objekt = new Object[4];

        objekt[0] = "Erstes Array";
        objekt[1] = 14;
        objekt[2] = "Dritter Array und ein Strng";
        objekt[3] = true;

        foreach (var obj in objekt)
        {
            String inhalt = obj as string;
            
            if (inhalt != null)
            {
                Console.WriteLine("Ist ein String, Inhalt: {0}", inhalt);
            }
            else
            {
                Console.WriteLine("Kein String");
            }
        }
    }

    static void Vererbung()
    {
        Computer pc = new Computer("X386", 1);
        Notebook mba = new Notebook("M1", 64);

        Console.WriteLine(mba is Computer);
        Console.WriteLine(mba is Notebook);
        Console.WriteLine(pc is Computer);
        Console.WriteLine(pc is Notebook);
        Console.WriteLine(pc is String);
        Console.WriteLine("Hallo" is String);
        
        
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