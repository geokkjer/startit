namespace Trafikklys.Demo2;

internal class Demo2
{
    public static void Run()
    {
        var trafikklys = new Trafikklys();
        while (true)
        {
            Console.Clear();
            trafikklys.Show();
            Console.ReadKey(true);
            trafikklys.GoToNextPhase();
        }
    }
}

