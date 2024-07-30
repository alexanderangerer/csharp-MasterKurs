namespace Abstract_Virtual;

class Program
{
    static void Main(string[] args)
    {
        Schreiner alex = new Schreiner("Alex", 120000);
        alex.PrintInformation();
        alex.ArbeitVerrichten();
        alex.PackeWerkzeug();
        Console.WriteLine();
        
        Console.WriteLine("Ab hier geht es los.");
        Console.WriteLine("####################");

        Rectangle rechteck = new Rectangle(23, 25);
        Circle kreis = new Circle(23);

        Console.WriteLine(rechteck.GetArea());
        Console.WriteLine(kreis.GetArea());

        Console.WriteLine(rechteck.ToString());
        Console.WriteLine(kreis.ToString());
    }
}