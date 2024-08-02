namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> ortQueue = new Queue<string>();
      
        ortQueue.Enqueue("Safenwil");
        ortQueue.Enqueue("Kloten");
        ortQueue.Enqueue("Winden");

        Console.WriteLine(ortQueue.Dequeue());
        Console.WriteLine(ortQueue.Peek());
        Console.WriteLine(ortQueue.Dequeue());

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