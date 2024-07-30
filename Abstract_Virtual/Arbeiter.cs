namespace Abstract_Virtual;

public abstract class Arbeiter
{
    public String Name { get; set; }
    public Decimal Gehalt { get; set; }

    public Arbeiter(string name, Decimal gehalt)
    {
        Name = name;
        Gehalt = gehalt;
    }

    public void PrintInformation()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Gehalt: {0}", Gehalt);
    }

    public abstract void ArbeitVerrichten();

    public virtual void PackeWerkzeug()
    {
        Console.WriteLine("Ich nehme einen Hammer mit.");
    }
}