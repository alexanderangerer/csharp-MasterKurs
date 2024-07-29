namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Name = "Alex";
        Console.WriteLine(person1.Name);


        Console.WriteLine("##################");
        Console.WriteLine("Jetzt geht es los:");
        Console.WriteLine("##################");
        
        Hund hund1 = new Hund("Männlich", 4);
        Katze katz1 = new Katze("Weiblich", 9);
        Maus maus1 = new Maus("Weiblich", 7);
        
        ITier[] alleTiere = new ITier[3];
        alleTiere[0] = hund1;
        alleTiere[1] = katz1;
        alleTiere[2] = maus1;
        
        foreach (var tier in alleTiere)
        {
            Console.WriteLine("Geschlecht: {0}", tier.Geschlecht);
            Console.WriteLine("Alter: {0}", tier.Alter);
            tier.Fressen();
            tier.Trinken();
            Console.WriteLine();
        }
    }
}