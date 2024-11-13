namespace ConsoleApp2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hei, hva heter du?");
        var input = Console.ReadLine();
        Console.WriteLine($"Velkommen {input}!");
        Console.WriteLine(NewClass.bokstav);
    }
}

