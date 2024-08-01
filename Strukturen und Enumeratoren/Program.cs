namespace Strukturen_und_Enumeratoren;

class Program
{
    static void Main(string[] args)
    {
        Point punkt;
        Point punkt2 = new Point(20, 25);

        punkt.x = 10;
        punkt.y = 15;
        punkt.startRichtung = Himmelsrichtung.Nord;

        Console.WriteLine(punkt.startRichtung);
        Console.WriteLine((int)punkt.startRichtung);
        punkt.PrintPosition();
        punkt2.PrintPosition();
    }

    enum Himmelsrichtung
    {
        Nord = 2,
        Ost = 4,
        Süd = 6,
        West = 8
    }
    struct Point
    {
        public int x;
        public int y;
        public Himmelsrichtung startRichtung;
        
        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }

        public void PrintPosition()
        {
            Console.WriteLine("X Position: {0}, y Position: {1}", x, y);
        }
    }
}