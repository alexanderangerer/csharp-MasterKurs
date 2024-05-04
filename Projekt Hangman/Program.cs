

using System.Reflection;

namespace Projekt_Hangman;

class Program
{
    static string[] wordlist = null;

    static void Main(string[] args)
    {
        // Environment.CurrentDirectory: Enthält oder gibt das Arbeitsverzeichnis an.
        // Path.GetDirectoryName: Ermittelt Informationen über das angegebene Verzeichnis.
        // Assembly.GetEntryAssembly(): Ruft die ausführbare Prozessordatei auf.
        // ?.Location) ?? "~"
        // Diese Zeile Code setzt den in der App benutzten relativen Pfad auf jenen in welchen die
        // App gestartet wurde.
        Environment.CurrentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location) ?? "~";
        
        // In dieser Methode wird die Wordlist Datei eingelesen.
        WordsFileRead();
        // Startet das Spiel.
        MainMenu();
    }

    /// <summary>
    /// List die Datei Wordlist.txt im Verzeichnis Contents ein und 
    /// </summary>
    static void WordsFileRead()
    {
        string pathFile = "Contents/Wordlist.txt"; 
        string[] wordsArray = null;
        
        try
        {
            StreamReader srWordlist = new StreamReader(pathFile);
            string words = srWordlist.ReadToEnd();
            wordsArray = words.Split("\n");
        }
        catch (Exception ex)
        {  
            Console.WriteLine("Ein Fehler ist aufgetreten!");
            Console.WriteLine(ex.Message);
        }
        
        wordlist = WordsRead(wordsArray);
        if (wordlist.Length < 5)
        {
            int exitCode = 0;
            Console.WriteLine("Die Wortliste beinhaltet zu wenige Worte. 5 Ist das minimum.");
            Console.WriteLine("Das Programm wird beendet.");
            Console.ReadKey();
            Environment.Exit(exitCode);
        }
    }

    static string[] WordsRead(string[] words)
    {
        List <string> returnWords = new List<string>();
        
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].IndexOf("[") == -1)
            {
                returnWords.Add(words[i]);
            }
        }

        return returnWords.ToArray();
    }
    static void MainMenu()
    {
        int action = 0;
        
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
            try
            {
                action = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                continue;
                //throw;
            }
            
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
        Random rnd = new Random();
        int index = rnd.Next(0, wordlist.Length);
        string word = wordlist[index].ToLower();
        GameLoop(word);
    }

    static void GameLoop(string word)
    {
        int lives = 10;
        string hiddenWord = "";
        char character = ' ';

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
            try
            {
                character = Convert.ToChar(Console.ReadLine().ToLower());
            }
            catch (Exception e)
            {
                Console.WriteLine("Es darf nur ein Zeichen eingegeben werden!");
                Console.WriteLine("Alles klar?");
                Console.ReadKey();
                continue;
                // throw;
            }
            

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
            {
                
            }
        }
    }
}