namespace ConsoleApp1;

public class MyConsole
{
    
   public static string Ask(string question)
    {
        Console.Write(question);
        return Console.ReadLine();
    }
    
}