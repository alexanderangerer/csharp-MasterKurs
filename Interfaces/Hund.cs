namespace Interfaces;

public class Hund : ITier
{
    public string Geschlecht { get; set; }
    public int Alter { get; set; }

    public Hund(string geschlecht, int alter)
    {
        Geschlecht = geschlecht;
        Alter = alter;
    }
    
    public void Fressen()
    {
        Console.WriteLine("Der Hund ist am fressen!");
    }

    public void Trinken()
    {
        Console.WriteLine("Der Hund ist am trinken!");
    }
}