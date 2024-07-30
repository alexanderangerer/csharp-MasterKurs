namespace Abstract_Virtual;

public class Schreiner : Arbeiter
{
    public Schreiner(string name, decimal gehalt) : base(name, gehalt)
    {
    }

    public override void ArbeitVerrichten()
    {
        Console.WriteLine("Der Schreiner {0} geht in die Werkstatt.", Name);
        Console.WriteLine("Er bekommt für seine Arbeit ein Gehalt von {0}", Gehalt);
    }

    public override void PackeWerkzeug()
    {
        base.PackeWerkzeug();
        Console.WriteLine("Der Schreiner nimmt einen Hobel mit");
    }
}