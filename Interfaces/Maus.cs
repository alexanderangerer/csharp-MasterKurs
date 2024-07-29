namespace Interfaces;

public class Maus : ITier
{
    public string Geschlecht { get; set; }
    public int Alter { get; set; }
    
    public Maus(string geschlecht, int alter)
    {
        Geschlecht = geschlecht;
        Alter = alter;
    }
    
    public void Fressen()
    {
        Console.WriteLine("Der Maus ist am fressen!");
    }

    public void Trinken()
    {
        Console.WriteLine("Der Maus ist am trinken!");
    }
}