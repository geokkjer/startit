namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
       
        var name = MyConsole.Ask("What is your name?");
        Console.WriteLine($"Hello {name}!");
        var number = GetNumber();
    }

    static Main2(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
 
    static int GetNumber()
    {
        return 7;
    }
}