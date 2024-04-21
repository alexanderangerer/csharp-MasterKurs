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
                    StartGame();
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
        GameLoop(word);
    }

    static void GameLoop(string word)
    {
        int lives = 10;
        string hiddenWord = "";

        for (int i = 0; i < word.Length; i++)
        {
            hiddenWord += "_";
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Gesuchtes Wort: {0}", hiddenWord);
            Console.Write("Noch übrige Versuche: ");

            for (int i = 0; i < lives; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('X');
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.Write("Buchstabe: ");
            char character = Convert.ToChar(Console.ReadLine().ToLower());

            bool foundCharacterInWord = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == character)
                {
                    foundCharacterInWord = true;
                    break;
                }
            }

            string tempHiddenWord = hiddenWord;
            hiddenWord = "";

            if (foundCharacterInWord)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == character)
                    {
                        hiddenWord += character;
                    }
                    else if (tempHiddenWord[i] != '_')
                    {
                        hiddenWord += tempHiddenWord[i];
                    }
                    else
                    {
                        hiddenWord += '_';
                    }
                }

                if (hiddenWord == word)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GEWONNEN!!!");
                    Console.WriteLine("Das Wort war: {0}", word);
                    Console.ReadKey();
                    Console.ResetColor();
                    break;
                }
                else
                {
                    hiddenWord = tempHiddenWord;

                    if (lives > 0)
                    {
                        lives -= 1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("GAME OVER!");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    }
                }
            }
            {
                
            }
        }
    }
}