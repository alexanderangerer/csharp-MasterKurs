namespace Interfaces;

public interface ITier
{ 
    string Geschlecht { get; set; }
    int Alter { get; set; }

    void Fressen();
    void Trinken();
} 