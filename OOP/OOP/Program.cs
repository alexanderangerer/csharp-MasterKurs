using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        // KlassenInitialisieren();
        // Vererbung();
        // AsOperator();
        Hund fido = new Hund();
        fido.Name = "Fido";
        fido.Alter = 3;
        fido.IsRuede = true;
        fido.Rasse = "Schäferhund";
        fido.Bellen();
        fido.Fressen();

        Hund ronja = new Hund("Ronya", 4, "Schweizer", false);
        ronja.Bellen();
        ronja.Fressen();

        Console.WriteLine("Rechteck: {0}", AreaCalculator.Rechteck(10,4));
        Console.WriteLine("Quadrat: {0}", AreaCalculator.Quadrat(4));
        Console.WriteLine("Kreis: {0}", AreaCalculator.Kreis(10));
        Console.WriteLine("Dreieck: {0}", AreaCalculator.Dreieck(5, 12));

        Person[] peopleInClassroom = new Person[]
        {
            new Teacher("John", "Smith", 32),
            new Student("Sabrina", "Müller", 18),
            new Student("Anna", "Matt", 17),
            new Student("Peter", "Fredl", 18),
            new Student("Matthias", "Maier", 19)
        };

        foreach (var person in peopleInClassroom)
        {
            Student studi = person as Student;
            
            if (studi != null)
            {
                studi.ListenToTeacher();
            }
            else
            {
                Teacher teachi = person as Teacher;
                teachi.Teach();
            }
        }
    }

    static void AsOperator()
    {
        Object[] objekt = new Object[4];

        objekt[0] = "Erstes Array";
        objekt[1] = 14;
        objekt[2] = "Dritter Array und ein Strng";
        objekt[3] = true;

        foreach (Person obj in objekt)
        {
            obj.PrintInformation();

            if (obj is Teacher)
            {
                (obj as Teacher).Teach();
            }
            else if (obj is Student)
            {
                (obj as Student).ListenToTeacher();
            }
            // String inhalt = obj as string;
            //
            // if (inhalt != null)
            // {
            //     Console.WriteLine("Ist ein String, Inhalt: {0}", inhalt);
            // }
            // else
            // {
            //     Console.WriteLine("Kein String");
            // }
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

class Teacher : Person
{
    public Teacher(string firstname, string lastname, int age) : base(firstname, lastname, age)
    {
    }

    public void Teach()
    {
        Console.WriteLine("Herr/Frau {0} unterrichtet die Klasse!", LastName);
    }
}

class Student : Person
{
    public Student(string firstname, string lastname, int age) : base(firstname, lastname, age)
    {
    }

    public void ListenToTeacher()
    {
        Console.WriteLine("Der/Die Schüler/in {0} {1} hört dem Lehrer zu!", FirstName, LastName);
    }
}
class Person ()
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //Todo Warum braucht es hier ein : this()?
    public Person (string firstname, string lastname, int age) : this()
    {
        FirstName = firstname;
        LastName = lastname;
        Age = age;
    }

    public void PrintInformation()
    {
        Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        Console.WriteLine("Alter: {0}", Age);
    }
}
static class AreaCalculator
{
    public static decimal Rechteck(decimal hoehe, decimal breite)
    {
        return hoehe * breite;
    }

    public static decimal Quadrat(decimal seitenlaenge)
    {
        return seitenlaenge * seitenlaenge;
    }

    public static decimal Kreis(decimal radius)
    {
        return radius * radius * Convert.ToDecimal(Math.PI);
    }

    public static decimal Dreieck(decimal laenge, decimal hoehe)
    {
        return laenge * hoehe / 2;
    }
}
class Hund
{
    public Hund(string name, int alter, string rasse, bool ruede)
    {
        Name = name;
        Alter = alter;
        Rasse = rasse;
        IsRuede = ruede;
    }

    public Hund()
    {
        
    }
    
    public string Name { get; set; }
    public int Alter { get; set; }
    public string Rasse { get; set; }
    public bool IsRuede { get; set; }

    public void Bellen()
    {
        Console.WriteLine("{0} bellt.", Name);
    }

    public void Fressen()
    {
        Console.WriteLine("{0} frisst.", Name);
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