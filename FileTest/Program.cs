namespace FileTest;

class Program
{
    static void Main(string[] args)
    {
        // @"C:\temp\test.txt" das @ sorgt dafür, dass die \ als Escape-Sequenz gelesen werden.
        // ansonsten müsste "C:\\temp\\test.txt" geschrieben werden.
        string path = "Macintosh HD/Users/alexangerer/test.mgi";
        string text = "Ich bin ein Testtext";

        if (File.Exists(path))
        {
            Console.WriteLine("Datei existiert.");
        }
        // File.WriteAllText(path, text);
        

        Console.WriteLine("Der Inhalt wurde in die Datei geschrieben.");

        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);

        foreach (string zeile in File.ReadLines(path))
        {
            if (zeile.IndexOf("[Einstellungen]") != -1)
            {
                Console.WriteLine("Einstellungen gefunden.");
            }

            Console.WriteLine(zeile);
        }
        
        string path2 = "test.girl";
        File.WriteAllText(path2, "Test Text");

        /*String line;
        try
        {
            StreamReader sr = new StreamReader("Beispiel.txt");//"Users/Dev/Beispiel.rtf");

            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            throw;
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

        try
        {
            StreamWriter sw = new StreamWriter("Beispiel.txt");
            sw.WriteLine("Neue Zeile hinzugefügt");
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            throw;
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }*/


    }
}