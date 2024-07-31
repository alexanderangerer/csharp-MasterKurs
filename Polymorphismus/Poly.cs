namespace Polymorphismus;

public class Poly
{
    public static double Sum(double a, double b)
    {
        return a + b;
    }

    public static double Sum(double[] numbers)
    {
        double summe = 0; 
        
        foreach (var number in numbers)
        {
            summe += number;
        }

        return summe;
    }
}