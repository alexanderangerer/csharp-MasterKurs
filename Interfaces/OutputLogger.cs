namespace Interfaces;

public class OutputLogger : ILogger
{
    public void Log(string message)
    {
        System.Diagnostics.Debug.WriteLine(message);
    }
}