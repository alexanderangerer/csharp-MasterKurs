namespace Interfaces;

public class Katze : ITier
{
    public string Geschlecht { get; set; }
    public int Alter { get; set; }
    
    public Katze(string geschlecht, int alter)
    {
        Geschlecht = geschlecht;
        Alter = alter;
    }
    
    public void Fressen()
    {
        Console.WriteLine("Der Katze ist am fressen!");
    }

    public void Trinken()
    {
        Console.WriteLine("Der Katze ist am trinken!");
    }
}