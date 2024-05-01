using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HalloWeltBeispiel;
internal class Program
{
    static void Main(string[] args)
    {
        // Modul1();
        // Modul2_Ganzzahlen();
        // Modul2_Fliesskommazahlen();
        // Modul2_Andere();
        // Modul2_UserEingabe();
        // Modul2_Aufgabe1();
        // Modul2_Aufgabe2();
        // Modul3_Aufgabe1();
        // Modul3_Operatoren();
        // Modul4_Aufgabe1und2();
        // Modul5_ifAbfragen();
        // Modul5_Bool();
        // Modul5_switch();
        // Modul5_Aufgabe1();
        // Modul5_Aufgabe2();
        // Modul5_Aufgabe3();
        // Modul6_1DArrays();
        // Modul6_2DArrays();
        // Modul6_Aufgabe1();
        // Modul6_Aufgabe2();
        // Modul7_While();
        // Modul7_DoWhile();
        // Modul7_forSchleife1();
        // Modul7_forSchleife2();
        // Modul7_forSchleife3();
        // Modul7_foreach();
        // Modul7_break();
        // Modul7_continue();
        // Modul7_Aufgabe1();
        // Modul7_Aufgabe2();
        // Modul7_Aufgabe3();
        // Modul7_Aufgabe4();
        // Modul7_Aufgabe5();
        // Modul7_Aufgabe6();
        // Modul7_Aufgabe7();
        // Modul7_Aufgabe8();
    }

    static void Modul9_Konvertierung()
    {
        // Implizite Konvertierung (Automatisch)
        float float1 = 123.12F;
        double double1 = float1;
        
        // Explizite Konvertierung (Manuell)
        double double2 = 213.2;
        float float2 = (float)double2;
        
        // Hilfsklassen zum Konvertieren
        float2 = Convert.ToSingle(double2);
    }
    
    static void Modul7_Aufgabe8()
    {
        Console.Write("Gib einen Satz ein: ");
        string input = Console.ReadLine();
        string output = "";

        foreach (char buchstabe in input)
        {
            if (char.IsLetter(buchstabe))
            {
                output += buchstabe;
            }
        }
        
        Console.WriteLine(output);
    }
    static void Modul7_Aufgabe7()
    {
        Console.Write("Gib ein Wort ein: ");
        string input = Console.ReadLine();
        string palindrom = "";

        for (int i = input.Length -1; i >= 0; i--)
        {
            palindrom += input[i];
        }

        Console.WriteLine(palindrom);
        
        if (input.ToLower() == palindrom.ToLower())
            Console.WriteLine("Es ist ein Palindrom");
        else
            Console.WriteLine("Es ist KEIN Palindrom");
    }
    static void Modul7_Aufgabe6()
    {
        Console.Write("Gib ein Wort oder Satz ein: ");
        string input = Console.ReadLine();

        Console.Clear();

        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input[i]);
            }
            
        }
    }
    static void Modul7_Aufgabe5()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0}*{1}={2}", j, i, j * i);

                for (int k = Console.CursorLeft; k <= j * 10; k++)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
    
    static void Modul7_Aufgabe4()
    {
        Console.Write("Breite des Rechtecks: ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Höhe des Rechtecks: ");
        int height = Convert.ToInt32(Console.ReadLine());
        DrawRectangle(width, height);
    }

    static void DrawRectangle(int width, int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                Console.Write('#');
            }
            Console.WriteLine();
        }
    }

    static void Modul7_Aufgabe3()
    {
        Console.Write("Gib eine Ganzzahl ein: ");
        int zahl = Convert.ToInt32(Console.ReadLine());
        MultiplicationList(zahl);
    }

    static void MultiplicationList(int zahl)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", zahl, i, zahl * i);
        }
    }
    static void Modul7_Aufgabe2()
    {
        bool endlos = true;
        while (endlos)
        {
            Console.Write("Gib die erste Zahl ein: ");
                    double zahl1 = Convert.ToDouble(Console.ReadLine());
            
                    Console.Write("Gib die zweite Zahl ein: ");
                    double zahl2 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.Write("Gib einen Operator ein (+, -, *, /): ");
                    char operand = Convert.ToChar(Console.ReadLine());

                    switch (operand)
                    {
                        case '+':
                            Console.WriteLine("{0} {1} {2} = {3}", zahl1, operand, zahl2, zahl1 + zahl2);
                            break;
                        case '-':
                            Console.WriteLine("{0} {1} {2} = {3}", zahl1, operand, zahl2, zahl1 - zahl2);
                            break;
                        case '*':
                            Console.WriteLine("{0} {1} {2} = {3}", zahl1, operand, zahl2, zahl1 * zahl2);
                            break;
                        case '/':
                            Console.WriteLine("{0} {1} {2} = {3}", zahl1, operand, zahl2, zahl1 / zahl2);
                            break;
                        case 'q':
                            endlos = false;
                            break;
                        default:
                            Console.WriteLine("Keine klare Eingabe!");
                            break;
                    }

                    Console.ReadKey();
                    Console.Clear();
        }
    }
    static void Modul7_Aufgabe1()
    {
        Console.Write("Gib die erste Zahl ein: ");
        int zahl1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Gib die zweite Zahl ein: ");
        int zahl2 = Convert.ToInt32(Console.ReadLine());
        
        AllEvenNumbers(zahl1, zahl2);
    }

    static void AllEvenNumbers(int zahl1, int zahl2)
    {
        while (zahl1 <= zahl2)
        {
            if (zahl1 % 2 == 0)
                Console.WriteLine(zahl1);
            
            zahl1++;
        }
    }
    static void Modul7_continue()
    {
        int zahl = 0;

        while (zahl < 10)
        {
            zahl++;
            
            if (zahl == 5)
                continue;
            
            Console.WriteLine(zahl);
            
            
            
        }
    }
    static void Modul7_break()
    {
        int zahl = 0;

        while (zahl < 10)
        {
            if (zahl == 5)
                break;
	
            Console.WriteLine(zahl);
            zahl++;
        }
    }

    static void Modul7_foreach()
    {
        string[] namen = new string[]
        {
            "Kerstin",
            "Lenia",
            "Malia",
            "Oma Angelika",
            "Oma Gitti",
            "Opa Wolfgang",
            "Alex"
        };

        foreach (var name in namen)
        {
            Console.WriteLine(name);

            // Wandelt den Namen zuerst in kleinbuchstaben um, um anschliessend zu Prüfen, ob das Wort "oma" 
            // in diesem String vorkommt.
            if (name.ToLower().Contains("oma"))
            {
                Console.WriteLine("Hier kommt eine Oma :-)");
            }
        }

        Console.WriteLine("Ich bin fertig");
    }
    static void Modul7_forSchleife3()
    {
        string[,] names = new string[,]
        {
            {
                "Name",
                "Kerstin",
                "Lenia",
                "Malia",
                "Alex"
            },
            {
                "Funktion",
                "Mutter",
                "Älteste Tochter",
                "Jüngste Tochter",
                "Vater"
            },
            {
                "Alter",
                "45",
                "7",
                "5",
                "44"
            }
        };

        for (int zeile = 0; zeile < names.GetLength(1); zeile++)
        {
            for (int spalte = 0; spalte < names.GetLength(0); spalte++)
            {
                Console.Write(names[spalte, zeile]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    static void Modul7_forSchleife2()
    {
        string[] names = new string[]
            { "Kerstin", "Lenia", "Malia", "Oma Angelika", "Oma Gitti", "Opa Wolfgang", "Alex" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
    }
    static void Modul7_forSchleife1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void Modul7_DoWhile()
    {
        string password = "HelloWorld";
        string input = "";

        do
        {
            Console.Write("Gebe das Passwort ein: ");
            input = Console.ReadLine();
            
        } while (input != password);
    }

    static void Modul7_While()
    {
        Console.Write("Gebe die erste Ganzzahl an: ");
        int zahl1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Gebe die zweite Ganzzahl an: ");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        while (zahl1 <= zahl2)
        {
            Console.WriteLine(zahl1);
            zahl1++;
        }
    }
    static void Modul6_Aufgabe2()
    {
        string[,] names = new string[2, 4];

        names[0, 0] = "Sabine";
        names[1, 0] = "Müller";
        
        names[0, 1] = "Sandra";
        names[1, 1] = "Maier";
        
        names[0, 2] = "Klaus";
        names[1, 2] = "Schmied";
        
        names[0, 3] = "Max";
        names[1, 3] = "Mustermann";

        string[,] names2 = new string[,]
        {
            {
                "Sabine",
                "Sandra",
                "Klaus",
                "Max"
            },
            { 
                "Müller",
                "Maier",
                "Schmied", 
                "Mustermann" 
            }
        };

        Console.WriteLine("Name1: Vorname {0}, Nachname {1}", names[0, 2], names[1, 2]);
        Console.WriteLine("Name2: Vorname {0}, Nachname {1}", names[0, 1], names[1, 1]);
    }

    static void Modul6_Aufgabe1()
    {
        string[] food = new string[4];

        food[0] = "Wasserflasche";
        food[1] = "Kaugummi";
        food[2] = "Nudeln";
        food[3] = "Kartoffel";

        string[] food2 = new string[] { "Wasserflasche", "Kaugummi", "Nudeln", "Kartoffel" };

        Console.WriteLine("Version 1: {0}", food[3]);
        Console.WriteLine("Version 2: {0}", food2[1]);
    }
    static void Modul6_2DArrays()
    {
        // Deklaration nach Werten
        string[,] names2 = new string[,]
        {
            // Spalte mit den Namen
            {
                "Name",
                "Kerstin",
                "Lenia",
                "Malia",
                "Alex"
            },
            {
                "Funktion",
                "Mutter",
                "Älteste Tocher",
                "Jüngste Tochter",
                "Vater"
            },
            {
                "Alter",
                "45",
                "7",
                "5",
                "44"
            }
        };
        Console.WriteLine("2. Art: {0}: {1}", names2[0,0], names2[0,3]);
        Console.WriteLine("2. Art: {0}: {1}", names2[1,0], names2[1,4]);
        
        // Normale deklarierung
        string[,] names = new string[3, 5];

        names[0, 0] = "Name";
        names[1, 0] = "Funktion";
        names[2,0] = "Alter";
        
        names[0, 1] = "Kerstin";
        names[1, 1] = "Mutter";
        names[2, 1] = "45";
        
        names[0, 2] = "Lenia";
        names[1, 2] = "Älteste Tochter";
        names[2, 2] = "7";
        
        names[0, 3] = "Malia";
        names[1, 3] = "Jüngste Tochter";
        names[2, 3] = "5";
        
        names[0, 4] = "Alex";
        names[1, 4] = "Vater";
        names[2, 4] = "44";

        Console.WriteLine("{0}: {1}", names[0,0], names[0,3]);
        Console.WriteLine("{0}: {1}", names[1,0], names[1,4]);
    }

    static void Modul6_1DArrays()
    {
        string[] names = new string[4];

        names[0] = "Kerstin";
        names[1] = "Lenia";
        names[2] = "Malia";
        names[3] = "Alex";

        string[] names2 = new string[] { "Malia", "Kerstin", "Lenia", "Alex" };

        string[] names3 = new string[]
        {
            "Lenia",
            "Malia",
            "Kerstin",
            "Alex"
        };

        Console.WriteLine("Deklaration 1 [0]: {0}", names[0]);
        Console.WriteLine("Deklaration 2 [1]: {0}", names2[1]);
        Console.WriteLine("Deklaration 3 [2]: {0}", names3[2]);
    }
    static void Modul5_Aufgabe3()
    {
        Console.Write("Gib die erste Zahl ein: ");
        int zahl1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Gib den Operator +, -, *, / ein: ");
        string mathOperator = Console.ReadLine();
        Console.WriteLine("Gib die zweite Zahl ein: ");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        switch (mathOperator)
        {
            case "+":
                Console.WriteLine("{0} {1} {2} = {3}", zahl1, mathOperator, zahl2, zahl1 + zahl2);
                break;
            case "-":
                Console.WriteLine("{0} {1} {2} = {3}", zahl1, mathOperator, zahl2, zahl1 - zahl2);
                break;
            case "*":
                Console.WriteLine("{0} {1} {2} = {3}", zahl1, mathOperator, zahl2, zahl1 * zahl2);
                break;
            case "/":
                Console.WriteLine("{0} {1} {2} = {3}", zahl1, mathOperator, zahl2, zahl1 / zahl2);
                break;
            default:
                Console.WriteLine("Ungültige Eingaben.");
                break;
        }
    }

    static void Modul5_Aufgabe2()
    {
        Console.Write("Gib bitte eine Jahreszahl ein: ");
        int year = Convert.ToInt32(Console.ReadLine());
        
        // Im MasterKurs wird die Prüfung auf ein Schaltjahr in einer Methode durchgeführt. Dabei wird die eigentliche
        // Prüfung in der return Anweisung verfasst.
        // return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)
        if (year % 4 == 0 && (!(year % 100 == 0) || (year % 400 == 0)))
        {
            Console.WriteLine("Das ist ein Schalttjahr.");
        }
        else
        {
            Console.WriteLine("Kein Schaltjahr.");
        }
    }

    static void Modul5_Aufgabe1()
    {
        Console.Write("Wie gross bist Du (in Metern)? ");
        double bodyHeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Wie schwer bist Du (in kg)? ");
        double bodyWeight = Convert.ToDouble(Console.ReadLine());
        double bmi = bodyWeight / (bodyHeight * bodyHeight);

        if (bmi <= 18.4)
        {
            Console.WriteLine("BMI {0}: Untergewichtig", bmi);
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            
            Console.WriteLine("BMI {0}: Normalgewichtig", bmi);
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            Console.WriteLine("BMI {0}: Übergewichtig", bmi);
        }
        else if (bmi >= 30 && bmi <= 34.9)
        {
            Console.WriteLine("BMI {0}: Adipositas Grad 1", bmi);
        }
        else if (bmi >= 35 && bmi <= 39.9)
        {
            Console.WriteLine("BMI {0}: Adipositas Grad 2", bmi);
        }
        else if (bmi >= 40)
        {
            Console.WriteLine("BMI {0}: Adipositas Grad 3", bmi);
        }
        else
        {
            Console.WriteLine("Deine Eingabe können nicht zugeordnet werden.");
        }
    }
    static void Modul5_switch()
    {
        Console.Write("Command: ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "SayHello":
                Console.WriteLine("Hallo!");
                break;
            case "SysGoodbye":
                Console.WriteLine("Auf Wiedersehen!");
                break;
            case "Smile":
                Console.WriteLine(":-)");
                break;
            default:
                Console.WriteLine("Ungültiger Befehl!");
                break;
        }
    }
    static void Modul5_Bool()
    {
        int alter = 18;
        bool mobil = true;
        bool qualifiziert = true;
        bool testBestanden = false;
        bool schüchtern = false;
        
        if ((alter >= 18) && (mobil) && (qualifiziert || testBestanden) && !schüchtern)
        {
            Console.WriteLine("Du bekommst den Job!");
        }
        else
        {
            Console.WriteLine("Du bekommst den Job leider nicht!");
        }
    }
    static void Modul5_ifAbfragen()
    {
        int age = 12;
        bool withParents = true;

        if (age >= 18)
        {
            Console.WriteLine("Du darfst den Film sehen!");
        }
        else if (withParents == true)
        {
            Console.WriteLine("Du darfst den Film danke Deiner Eltern sehen!");
        }
        else
        {
            Console.WriteLine("Du darfst den Film nicht sehen!");
        }
    }
    static void Modul4_Aufgabe1und2()
    {
        string text1 = "Gebe deinen Vornamen ein: ";
        string text2 = "Gebe deinen Nachnamen ein: ";
        string ergebnis1 = GetTextInput(text1);
        string ergebnis2 = GetTextInput(text2);

        Console.WriteLine("Hallo {0} {1}.",ergebnis1, ergebnis2 );
        
        Console.Write("Gib den Radius des Kreises in cm ein: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Die Fläche eines Kreises mit dem Radius {0}cm beträgt {1}cm2", radius, GetCircleArea(radius));
    }
    static string GetTextInput(string message)
    {
        Console.Write(message);
        string ergebnis = Console.ReadLine();

        return ergebnis;
    }
    static double GetCircleArea(double radius)
    {
        double PI = Math.PI;
        double ergebnis = PI * radius * radius;

        return ergebnis;
    }
    
    static void Modul3_Aufgabe1()
    {
        Console.Write("Erste Zahl: ");
        double zahl1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Zweite Zahl: ");
        double zahl2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", zahl1, zahl2, zahl1 + zahl2);
        Console.WriteLine("{0} - {1} = {2}", zahl1, zahl2, zahl1 - zahl2);
        Console.WriteLine("{0} * {1} = {2}", zahl1, zahl2, zahl1 * zahl2);
        Console.WriteLine("{0} / {1} = {2}", zahl1, zahl2, zahl1 / zahl2);
        Console.WriteLine("{0} % {1} = {2}", zahl1, zahl2, zahl1 % zahl2);
    }
    
    static void Modul3_Operatoren()
    {
        double zahl1 = 50;
        double zahl2 = 4;

        double ergebnis = zahl1 *= 5;
        Console.WriteLine(ergebnis);
    }
    static void Modul2_Aufgabe2()
    {
        Console.Write("Geben Sie Ihren Vornamen ein: ");
        string vorname = Console.ReadLine();
        
        Console.Write("Geben Sie Ihren Nachnamen ein: ");
        string nachname = Console.ReadLine();
        
        Console.Write("Geben Sie Ihren Alter ein: ");
        string alter = Console.ReadLine();

        Console.WriteLine(vorname);
        Console.WriteLine(nachname);
        Console.WriteLine(alter);

        Console.WriteLine("Hallo {0} {1}, willkommen zurück!", vorname, nachname);
        Console.WriteLine("Hallo " + vorname + " " + nachname + ", willkommen zurück!");
    }
    static void Modul2_Aufgabe1()
    {
        byte ageEmployees = 32; // employeeAge
        long assetRichestPeople = 185;
        bool isMarried = true;
        string myName = "Ales";
        char firstCharMyName = myName[0];
        decimal priceBreakfast = 4.98M;
    }
    static void Modul2_UserEingabe()
    {
        Console.Write("Gib Deinen Namen ein: ");
        string name = Console.ReadLine();

        Console.Write("Gib Dein Alter ein: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dein Name ist {0} und Du bist {1} Jahre alt.", name, age);
        Console.WriteLine("Dein Name ist " + name + " und Du bist " + age + " Jahre alt.");
    }
    static void Modul2_Andere()
    {
        string text = "Hallo Welt!";
        char zeichen = text[6];

        bool istEs = true;
        Console.WriteLine(zeichen);
        Console.WriteLine(istEs);
    }
    static void Modul2_Fliesskommazahlen()
    {
        float zahl1 = 2.25F;
        double zahl2 = 33.3245;
        decimal zahl3 = 32.45M;

        Console.WriteLine(zahl2);
    }
    static void Modul2_Ganzzahlen()
    {
        byte zahl1 = 255;
        short zahl2 = 20000;
        int zahl3 = 2000000;
        long zahl4 = 200000000;

        Console.WriteLine(zahl1);

        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
    }
    static void Modul1()
    {
        // Deklaration
        string username;
        int age = 18;
        
        // Initialisierung
        username = "Alex";
        Console.WriteLine("Name: " + username);
        Console.WriteLine("Alter: " + age);

        username = "Alexander";
        Console.WriteLine(username);
        
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Zweite Zeile hinzugefügt.");
        Console.WriteLine("Und noch eine Anpassun. Ausgeführt von aaPhoto.");
        Console.ReadKey();
    }
}

