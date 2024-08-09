using System.Threading.Channels;

namespace Generic;

class Program
{
    static void Main(string[] args)
    {
        WerteBehälter<string> generisch = new WerteBehälter<string>("Alex");
        generisch.Ausgabe();

        WerteBehälter<int> genInt = new WerteBehälter<int>(23);
        genInt.Ausgabe();

        List<string> namensListe = new List<string>();
        AddMultiple<string>(namensListe, 23, "Angerer");

        foreach (var name in namensListe)
        {
            Console.WriteLine(name);
        }
    }

    static void AddMultiple<T>(List<T> list, int anzahl, T wert)
    {
        for (int i = 0; i < anzahl; i++)
        {
            list.Add(wert);
        }
    }
}

class WerteBehälter<T>
{
    private T meinWert;

    public WerteBehälter(T _wert)
    {
        meinWert = _wert;
    }

    public void Ausgabe()
    {
        Console.WriteLine(meinWert.ToString());
    }
}