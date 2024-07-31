namespace Polymorphismus;

public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public Person(string firstname, string lastname)
    {
        firstName = firstname;
        lastName = lastname;
    }

    public void Greet()
    {
        Console.WriteLine("Guten Morgen");
    }

    public void Greet(bool mitName)
    {
        Console.WriteLine("Guten Morgen {0} {1}", firstName, lastName);
    }

    public void Greet(Person person)
    {
        Console.WriteLine("Guten Morgen {0} {1}", person.firstName, person.lastName);
    }
}