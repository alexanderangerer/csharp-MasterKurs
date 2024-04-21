namespace Projekt_Hangman;

class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }
    static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("### HANGMAN ###");
            Console.WriteLine("###############");
            Console.WriteLine();

            Console.WriteLine("Wähle eine Aktion aus:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[1] Spielen");
            Console.WriteLine("[2] Beenden");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Aktion: ");
            int action = Convert.ToInt32(Console.ReadLine());
            bool end = false;

            switch (action)
            {
                case 1:
                    // StartGame();
                    break;
                case 2:
                    end = true;
                    break;
            }

            if (end)
            {
                break;
            }
                
            Console.Clear();
        }
    }

    static void StartGame()
    {
        string[] words = new string[]
        {
            "Apfelkuchen",
            "Programmiercode",
            "Schreiner48",
            "Lebensmittel",
            "Unterhose",
            "Küchenschrank",
            "Schallschutzfenster",
            "Toilettentüre"
        };

        Random rnd = new Random();
        int index = rnd.Next(0, words.Length);
        string word = words[index].ToLower();
        // GameLoop();
    }
}