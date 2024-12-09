using System.Text;
namespace Trafikklys;

internal class TrafikklysKonsoll
{
    public static void Show(bool red, bool yellow, bool green)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Gray;
        //Console.WriteLine("\u250f\u2501\u2513");
        Console.WriteLine("┏━┓");
        DrawLine(red ? ConsoleColor.Red : ConsoleColor.Black);
        DrawLine(yellow ? ConsoleColor.Yellow : ConsoleColor.Black);
        DrawLine(green ? ConsoleColor.Green : ConsoleColor.Black);
        Console.WriteLine("┗━┛");
        //Console.WriteLine("\u2517\u2501\u251b");
    }

    private static void DrawLine(ConsoleColor color)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("┃");
        //Console.Write("\u2503");
        Console.ForegroundColor = color;
        Console.Write("O");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("┃");
        //Console.Write("\u2503");
    }
}