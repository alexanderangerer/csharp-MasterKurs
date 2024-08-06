namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();
        
        names.Add("Peter");
        names.Add("Alina");
        names.Add("Sabine");
        names.Add("Florian");

        Console.WriteLine("Unsortiert!");
        Console.WriteLine("_________________________");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        
        names.Sort();
        
        Console.WriteLine();
        Console.WriteLine("Sortiert!");
        Console.WriteLine("_________________________");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        // Dictionary<int, string> Orte = new Dictionary<int, string>();
        //
        // Orte.Add(8302, "Kloten");
        // Orte.Add(5745, "Safenwil");
        // Orte.Add(8952, "Schlieren");
        // Orte.Add(5036, "Oberentfelden");
        //
        // Console.WriteLine("Der Ort mit der PLZ 8952 heisst: {0}", Orte[8952]);
        //
        // if (Orte.ContainsKey(8745))
        // {
        //     Console.WriteLine("Der Ort mit der PLZ 8952 heisst: {0}", Orte[8745]);
        // }
        // else
        // {
        //     Console.WriteLine("Einen Key mit diesem Wert gefunden.");
        // }
        //
        // foreach (KeyValuePair<int, string> Ortschaften in Orte)
        // {
        //     Console.WriteLine(Ortschaften.Key + " " + Ortschaften.Value);
        // }
        //
        // Orte.Remove(8952);
        // Console.WriteLine("##################");
        // foreach (KeyValuePair<int, string> Ortschaften in Orte)
        // {
        //     Console.WriteLine(Ortschaften.Key + " " + Ortschaften.Value);
        // }
        // Queue<string> ortQueue = new Queue<string>();

        // ortQueue.Enqueue("Safenwil");
        // ortQueue.Enqueue("Kloten");
        // ortQueue.Enqueue("Winden");
        //
        // Console.WriteLine(ortQueue.Dequeue());
        // Console.WriteLine(ortQueue.Peek());
        // Console.WriteLine(ortQueue.Dequeue());

        // Stack<string> ortStack = new Stack<string>();
        //
        // ortStack.Push("Safenwil");
        // ortStack.Push("Kloten");
        // ortStack.Push("Winden");
        //
        // Console.WriteLine(ortStack.Count());
        //
        // Console.WriteLine(ortStack.Pop());
        // Console.WriteLine(ortStack.Peek());
        // Console.WriteLine(ortStack.Pop());
        // Console.WriteLine(ortStack.Peek());
        //
        // List<string> namensList = new List<string>();
        // List<string> ortList = new List<string>()
        // {
        //     "Norddeich",
        //     "Norden",
        //     "Winden",
        //     "Kloten",
        //     "Safenwil"
        // };
        //
        // namensList.Add("Kerstin");
        // namensList.Add("Lenia");
        // namensList.Add("Malia");
        // namensList.Add("Alex");
        //
        // Console.WriteLine(namensList[2]);
        // Console.WriteLine(ortList[2]);
        //
        // Console.WriteLine(namensList.First());
        // Console.WriteLine(ortList.Last());
        //
        // namensList[3] = "Angerer";
        // Console.WriteLine(namensList[3]);
        // namensList.Remove("Angerer");
        // Console.WriteLine(namensList.Count);
        //
        // Console.WriteLine(ortList.Count);
    }
}