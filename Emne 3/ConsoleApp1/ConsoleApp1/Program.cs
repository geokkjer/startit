namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
       
        var name = MyConsole.Ask("What is your name?");
        Console.WriteLine($"Hello {name}!");
        var number = GetNumber();
    }

 
    static int GetNumber()
    {
        return 7;
    }
}