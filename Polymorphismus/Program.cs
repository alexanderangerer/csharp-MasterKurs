using System.Diagnostics.CodeAnalysis;

namespace Polymorphismus;

class Program
{
    static void Main(string[] args)
    {
        Dog hund1 = new Dog("Wuffi", 4);
        Dog hund2 = new Dog("Waldi", 3, "Ich");
        
        hund1.PrintInformation();
        hund2.PrintInformation();
        
        double[] numbers = new double[] {23.1, 3, 123.55, 5, 90.1};
        Console.WriteLine(Poly.Sum(23.4, 12.6));
        Console.WriteLine(Poly.Sum(numbers));
        
        Console.WriteLine();
        Person hans = new Person("Hans", "Meier");
        Person anna = new Person("Anna", "Peterson");
        
        hans.Greet();
        hans.Greet(true);
        hans.Greet(anna);
    }

    
}