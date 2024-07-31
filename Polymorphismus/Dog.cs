namespace Polymorphismus;

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Owner { get; set; }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
        Owner = "No owener";
    }
    
    public Dog(string name, int age, string owner)
    {
        Name = name;
        Age = age;
        Owner = owner;
    }

    public void PrintInformation()
    {
        Console.WriteLine("Name: {0}, Alter: {1}, Besitzer: {2}.", Name, Age, Owner);
    }
}